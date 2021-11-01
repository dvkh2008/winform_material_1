using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json.Serialization;

namespace SKCT.Entity
{
    public enum EntityState
    {
        Normal,
        Add,
        Modified
    }

    public enum PrepareEntityForDBType
    {
        String,
        Int,
        Float
    }

    internal class PrepareEntityForDB
    {
        public string PropertyName { get; set; }
        public string JsonPropertyName { get; set; }
        public PrepareEntityForDBType DbType { get; set; }
        public object Value { get; set; }

        public string DbColumnName => string.IsNullOrEmpty(JsonPropertyName) ? PropertyName.ToLower() : JsonPropertyName;
        public string ParameterName => $"@{PropertyName}";
    }

    internal static class DbSetEntryExtension
    {
        internal static IEnumerable<PrepareEntityForDB> GetSchemaOfEntity<T>() where T : class
        {
            var result = new List<PrepareEntityForDB>();
            var entityType = typeof(T);
            var props = entityType.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                var notMappedAttribute = prop.GetCustomAttribute<NotMappedAttribute>();
                if (notMappedAttribute != null)
                {
                    continue;
                }
                var att = prop.GetCustomAttribute<JsonPropertyNameAttribute>();

                result.Add(new PrepareEntityForDB
                {
                    PropertyName = prop.Name,
                    JsonPropertyName = att?.Name,
                    DbType = prop.PropertyType == typeof(int) ? PrepareEntityForDBType.Int : prop.PropertyType == typeof(float) ? PrepareEntityForDBType.Float : PrepareEntityForDBType.String
                });
            }
            return result;
        }

        internal static IEnumerable<PrepareEntityForDB> GetSchemaOfEntity<T>(this T entity, bool ignoreIdColumn) where T : class
        {
            var result = new List<PrepareEntityForDB>();
            var entityType = typeof(T);
            var props = entityType.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                var notMappedAttribute = prop.GetCustomAttribute<NotMappedAttribute>();
                if (notMappedAttribute != null)
                {
                    continue;
                }
                var propName = prop.Name;
                var att = prop.GetCustomAttribute<JsonPropertyNameAttribute>();

                result.Add(new PrepareEntityForDB
                {
                    PropertyName = prop.Name,
                    JsonPropertyName = att?.Name,
                    DbType = prop.PropertyType == typeof(int) ? PrepareEntityForDBType.Int : prop.PropertyType == typeof(float) ? PrepareEntityForDBType.Float : PrepareEntityForDBType.String,
                    Value = prop.GetValue(entity)
                });
            }

            if (ignoreIdColumn)
            {
                return result.Where(x => x.DbColumnName != "id");
            }

            return result;
        }

        private static Type GetUnderlyingType(this MemberInfo member)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Event:
                    return ((EventInfo)member).EventHandlerType;
                case MemberTypes.Field:
                    return ((FieldInfo)member).FieldType;
                case MemberTypes.Method:
                    return ((MethodInfo)member).ReturnType;
                case MemberTypes.Property:
                    return ((PropertyInfo)member).PropertyType;
                default:
                    throw new ArgumentException
                    (
                     "Input MemberInfo must be if type EventInfo, FieldInfo, MethodInfo, or PropertyInfo"
                    );
            }
        }

        internal static IEnumerable<PrepareEntityForDB> GetSchemaOfEntity<T>(Expression<Func<T, object>> fieldsExpression) where T : class
        {
            var result = new List<PrepareEntityForDB>();

            if (fieldsExpression.Body is MemberExpression body)
            {
                var memberInfo = body.Member;
                var att = memberInfo.GetCustomAttribute<JsonPropertyNameAttribute>();

                result.Add(new PrepareEntityForDB
                {
                    PropertyName = memberInfo.Name,
                    JsonPropertyName = att?.Name,
                    DbType = memberInfo.DeclaringType == typeof(int) ? PrepareEntityForDBType.Int : memberInfo.DeclaringType == typeof(float) ? PrepareEntityForDBType.Float : PrepareEntityForDBType.String
                });
            }
            else if (fieldsExpression.Body is NewExpression newBody)
            {
                foreach (MemberExpression item in newBody.Arguments)
                {
                    var memberInfo = item.Member;
                    var att = memberInfo.GetCustomAttribute<JsonPropertyNameAttribute>();

                    result.Add(new PrepareEntityForDB
                    {
                        PropertyName = memberInfo.Name,
                        JsonPropertyName = att?.Name,
                        DbType = memberInfo.DeclaringType == typeof(int) ? PrepareEntityForDBType.Int : memberInfo.DeclaringType == typeof(float) ? PrepareEntityForDBType.Float : PrepareEntityForDBType.String
                    });
                }
            }
            else
            {
                throw new Exception("Error while try search property to update.");
            }

            return result;
        }
    }

    public class DbSetEntry<T> where T : class
    {
        public DbSetEntry()
        {

        }

        public DbSetEntry(EntityState state, T entity, bool trackNewId = false)
        {
            State = state;
            Entity = entity;
            TrackNewId = trackNewId;
        }
        public EntityState State { get; set; }
        public bool TrackNewId { get; set; }
        public T Entity { get; set; }
    }

    public class DbSet<T> where T : class
    {
        private readonly DbContextDriver _dbContextDriver;
        private readonly string _tableName;

        private List<DbSetEntry<T>> Entities { get; set; } = new List<DbSetEntry<T>>();

        public DbSet(DbContextDriver dbContextDriver, string tableName)
        {
            _dbContextDriver = dbContextDriver;
            _tableName = tableName;
        }

        public void Reset()
        {
            Entities = new List<DbSetEntry<T>>();
        }

        public IEnumerable<T> EntitiesAdding => Entities.Where(e => e.State == EntityState.Add).Select(e => e.Entity).ToArray();
        public IEnumerable<T> EntitiesModified => Entities.Where(e => e.State == EntityState.Modified).Select(e => e.Entity).ToArray();

        public void SaveChange()
        {
            Adding();
            Update();
        }

        #region [SaveChange]
        private void Adding()
        {
            var hasAdding = Entities.Any(e => e.State == EntityState.Add);
            if (!hasAdding)
            {
                return;
            }

            foreach (var item in Entities.Where(e => e.State == EntityState.Add && e.TrackNewId))
            {
                var data = DbSetEntryExtension.GetSchemaOfEntity(item.Entity, true);
                var query = $@"insert into {_tableName} ({string.Join(',', data.Select(d => d.DbColumnName))}) values ({string.Join(',', data.Select(d => d.ParameterName))}) returning id;";

                using var cmd = _dbContextDriver.GetCommand();
                cmd.CommandText = query;

                cmd.Parameters.AddRange(data.Select(d => new SQLiteParameter(d.ParameterName, d.Value)).ToArray());

                ((dynamic)item.Entity).Id = int.Parse(cmd.ExecuteScalar().ToString());

                item.State = EntityState.Normal;
            }

            if (Entities.Any(e => e.State == EntityState.Add && !e.TrackNewId))
            {
                var entitySchema = DbSetEntryExtension.GetSchemaOfEntity(Entities.First().Entity, true);
                var paramCounter = 0;
                using var cmd = _dbContextDriver.GetCommand();

                var insertValues = new List<string>();


                foreach (var item in Entities.Where(e => e.State == EntityState.Add && !e.TrackNewId))
                {
                    paramCounter += 1;
                    entitySchema = DbSetEntryExtension.GetSchemaOfEntity(item.Entity, true);
                    insertValues.Add($"({string.Join(',', entitySchema.Select(d => $"{d.ParameterName}{paramCounter}"))})");
                    cmd.Parameters.AddRange(entitySchema.Select(d => new SQLiteParameter($"{d.ParameterName}{paramCounter}", d.Value)).ToArray());

                    item.State = EntityState.Normal;
                }
                var query = $@"insert into {_tableName} ({string.Join(',', entitySchema.Select(d => d.DbColumnName))}) values {string.Join(',', insertValues)};";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }

        }

        private void Update()
        {
            var hasUpdate = Entities.Any(e => e.State == EntityState.Modified);
            if (!hasUpdate)
            {
                return;
            }

            var paramCounter = 0;
            using var cmd = _dbContextDriver.GetCommand();

            var updateQueries = new List<string>();


            foreach (var item in Entities.Where(e => e.State == EntityState.Modified))
            {
                paramCounter += 1;
                var entitySchema = DbSetEntryExtension.GetSchemaOfEntity(item.Entity, false);
                string sets = string.Join(',', entitySchema.Where(x => x.DbColumnName != "id").Select(x => $"{x.DbColumnName}={x.ParameterName}{paramCounter}"));
                updateQueries.Add($"update {_tableName} set {sets} where id = @id{paramCounter}");

                cmd.Parameters.AddRange(entitySchema.Select(d => new SQLiteParameter($"{d.ParameterName}{paramCounter}", d.Value)).ToArray());

                item.State = EntityState.Normal;
            }
            //updateQueries.Add("select 1 as result;");
            var query = string.Join(';', updateQueries);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        #endregion

        public void Add(T entity, bool trackNewId = true)
        {
            Entities.Add(new DbSetEntry<T>(EntityState.Add, entity, trackNewId));
        }

        public void AddRange(IEnumerable<T> entities, bool trackNewId = false)
        {
            foreach (var item in entities)
            {
                Add(item, trackNewId);
            }
        }

        public void Update(T entity)
        {
            Entities.Add(new DbSetEntry<T>(EntityState.Modified, entity));
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Entities.Add(new DbSetEntry<T>(EntityState.Modified, entity));
            }
        }

        public IEnumerable<T> Get(int limit = 50, int offset = -1)
        {
            var columns = DbSetEntryExtension.GetSchemaOfEntity<T>().ToList();
            string stm = $"SELECT {string.Join(',', columns.Select(c => c.DbColumnName))} FROM {_tableName}";
            if (offset >= 0)
            {
                stm += $" LIMIT {limit} OFFSET {offset}";
            }

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;

            using SQLiteDataReader rdr = cmd.ExecuteReader();
            //Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            var typeOfEntity = typeof(T);
            ConstructorInfo ctor = typeOfEntity.GetConstructor(Type.EmptyTypes);
            if (ctor == null)
            {
                throw new InvalidOperationException($"Type {typeOfEntity.Name} does not have a default constructor.");
            }
            var result = new List<T>();

            while (rdr.Read())
            {
                T item = (T)ctor.Invoke(null);
                MappingFromDataReader(item, typeOfEntity, columns, rdr);
                result.Add(item);
            }
            return result;
        }

        public IEnumerable<T> Get(Expression<Func<T, object>> fieldsExpression)
        {
            var columns = DbSetEntryExtension.GetSchemaOfEntity<T>(fieldsExpression).ToList();

            string stm = $"SELECT DISTINCT {string.Join(',', columns.Select(c => c.DbColumnName))} FROM {_tableName}";
            //LIMIT 10 OFFSET 10;

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;

            using SQLiteDataReader rdr = cmd.ExecuteReader();
            //Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),8}");

            var typeOfEntity = typeof(T);
            ConstructorInfo ctor = typeOfEntity.GetConstructor(Type.EmptyTypes);
            if (ctor == null)
            {
                throw new InvalidOperationException($"Type {typeOfEntity.Name} does not have a default constructor.");
            }
            var result = new List<T>();

            while (rdr.Read())
            {
                T item = (T)ctor.Invoke(null);
                MappingFromDataReader(item, typeOfEntity, columns, rdr);
                result.Add(item);
            }
            return result;
        }

        public IEnumerable<T> SearchWithEnterprise(string searchText, bool includeGroupBy, int limit, int offset)
        {
            var groupBy = includeGroupBy ? "GROUP BY monthregister, yearregister, hsc" : "";

            var columns = DbSetEntryExtension.GetSchemaOfEntity<T>().ToList();
            string stm = $@"SELECT {string.Join(',', columns.Select(c => c.DbColumnName))}
FROM {_tableName}
WHERE enterprisemst LIKE @searchText OR enterprisename LIKE @searchText OR hsc LIKE @searchText
{groupBy}
LIMIT {limit} OFFSET {offset}";

            return Get(stm, new SQLiteParameter("@searchText", $"%{searchText}%"));
        }

        public IEnumerable<T> Get(string query, params SQLiteParameter[] parameters)
        {
            var columns = DbSetEntryExtension.GetSchemaOfEntity<T>().ToList();

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = query;

            if (parameters.Any())
            {
                cmd.Parameters.AddRange(parameters);
            }

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            var typeOfEntity = typeof(T);
            ConstructorInfo ctor = typeOfEntity.GetConstructor(Type.EmptyTypes);
            if (ctor == null)
            {
                throw new InvalidOperationException($"Type {typeOfEntity.Name} does not have a default constructor.");
            }
            var result = new List<T>();

            while (rdr.Read())
            {
                T item = (T)ctor.Invoke(null);
                MappingFromDataReader(item, typeOfEntity, columns, rdr);
                result.Add(item);
            }
            return result;
        }

        private void MappingFromDataReader(T item, Type typeOfEntity, List<PrepareEntityForDB> columns, SQLiteDataReader rdr)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                var clName = columns[i];

                PropertyInfo propInfo = typeOfEntity.GetProperty(clName.PropertyName);
                if (propInfo != null)
                {
                    if (clName.DbType == PrepareEntityForDBType.Int)
                    {
                        var value = rdr.GetInt32(i);
                        propInfo.SetValue(item, value);
                    }
                    else if (clName.DbType == PrepareEntityForDBType.Float)
                    {
                        var value = rdr.GetFloat(i);
                        propInfo.SetValue(item, value);
                    }
                    else
                    {
                        var value = rdr.GetString(i);
                        propInfo.SetValue(item, value);
                    }
                }
            }
        }
    }

}

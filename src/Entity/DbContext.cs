using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;

namespace SKCT.Entity
{
    public class DbContext : IDisposable
    {
        private static string sqlitePath = Path.Combine(Directory.GetCurrentDirectory(), "store");
        private static string sqliteFile = Path.Combine(sqlitePath, "skct.db");
        //private readonly string cs = "Data Source=:memory:";
        private readonly string cs = $"URI=file:{sqliteFile}";

        private readonly DbContextDriver _dbContextDriver;

        public DbSet<Product> Products { get; set; }
        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<CustomsDeclaration> CustomsDeclarations { get; set; }
        public DbSet<CustomsDeclarationView> CustomsDeclarationViews { get; set; }
        public DbSet<MainScreenView> MainScreenViews { get; set; }
        public DbSet<StatisticalView> StatisticalViews { get; set; }
        public DbSet<StatisticalView> StatisticalSearchViews { get; set; }

        public DbContext()
        {
            _dbContextDriver = new DbContextDriver(cs);

            Products = new DbSet<Product>(_dbContextDriver, "product");
            Enterprises = new DbSet<Enterprise>(_dbContextDriver, "enterprise");
            CustomsDeclarations = new DbSet<CustomsDeclaration>(_dbContextDriver, "customsdeclaration");
            CustomsDeclarationViews = new DbSet<CustomsDeclarationView>(_dbContextDriver, "customsdeclarationview");
            MainScreenViews = new DbSet<MainScreenView>(_dbContextDriver, "mainscreenview");
            StatisticalViews = new DbSet<StatisticalView>(_dbContextDriver, "statisticalview");
            StatisticalSearchViews = new DbSet<StatisticalView>(_dbContextDriver, "statisticalsearchview");
        }

        #region [Get Total]
        public int TotalOfEnterprise()
        {
            string stm = "SELECT COUNT(*) FROM enterprise";

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;
            var count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }

        public int TotalOfCustomsDeclarationView(string searchtext)
        {
            var hasSearch = !string.IsNullOrEmpty(searchtext);
            string where = hasSearch ? " WHERE enterprisemst LIKE @searchtext OR enterprisename LIKE @searchtext  OR hsc LIKE @searchtext" : "";
            string stm = $"SELECT COUNT(*) FROM customsdeclarationview{where}";

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;

            if (hasSearch)
            {
                cmd.Parameters.Add(new SQLiteParameter("@searchtext", $"%{searchtext}%"));
            }

            var count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }

        public int TotalOfMainScreenView()
        {
            string stm = "SELECT COUNT(*) FROM mainscreenview";

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;
            var count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }

        public int TotalOfStatisticalView()
        {
            string stm = "SELECT COUNT(*) FROM statisticalview";

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;
            var count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }

        public int TotalOfStatisticalSearchView(string searchtext)
        {
            string stm = @"SELECT COUNT(*) FROM (
SELECT COUNT(*)
 FROM statisticalsearchview
 WHERE enterprisemst LIKE @searchtext OR enterprisename LIKE @searchtext OR hsc LIKE @searchtext
 GROUP BY monthregister, yearregister, hsc
)";

            using var cmd = _dbContextDriver.GetCommand();
            cmd.CommandText = stm;
            cmd.Parameters.Add(new SQLiteParameter("@searchtext", $"%{searchtext}%"));

            var count = int.Parse(cmd.ExecuteScalar().ToString());
            return count;
        }
        #endregion

        #region [SeedDbContext]
        private void GrantAccess(string file)
        {
            bool exists = Directory.Exists(file);
            if (!exists)
            {
                Directory.CreateDirectory(file);
            }
            else
            {
                return;
            }
            DirectoryInfo dInfo = new DirectoryInfo(file);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(
                    new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                    FileSystemRights.FullControl,
                    InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                    PropagationFlags.NoPropagateInherit,
                    AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);

        }

        public void CleanDatabase()
        {
            if (File.Exists(sqliteFile))
            {
                File.Delete(sqliteFile);
                SeedDbContext();
            }
        }

        public void SeedDbContext()
        {
            if (File.Exists(sqliteFile))
            {
                return;
            }
            GrantAccess(sqlitePath);

            SQLiteConnection.CreateFile(sqliteFile);
            using var con = new SQLiteConnection(cs);
            con.Open();
            InitEnterprise(con);
            InitProduct(con);
            InitCustomsDeclaration(con);
            InitCustomsDeclarationView(con);
            InitMainScreenView(con);
            InitStatisticalView(con);
            InitStatisticalSearchView(con);
        }
        private void InitEnterprise(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS enterprise";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE enterprise(id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT, mst TEXT)";
            cmd.ExecuteNonQuery();
        }

        private void InitProduct(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS product";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE product(id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT, description TEXT)";
            cmd.ExecuteNonQuery();
        }

        private void InitCustomsDeclaration(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = "DROP TABLE IF EXISTS customsdeclaration";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE customsdeclaration(id INTEGER PRIMARY KEY AUTOINCREMENT,
            no_declare TEXT, hsc TEXT, productid INTEGER, enterpriseid INTEGER, dayregister INTEGER, monthregister INTEGER, yearregister INTEGER, type_lh TEXT, quantity REAL, unit TEXT)";
            cmd.ExecuteNonQuery();
        }
        private void InitCustomsDeclarationView(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE VIEW customsdeclarationview 
AS 
SELECT
	customsdeclaration.id as id, no_declare, hsc, product.name as productname,
    enterprise.name as enterprisename, enterprise.mst as enterprisemst,
    dayregister, monthregister, yearregister, type_lh, quantity, unit
FROM
	customsdeclaration
INNER JOIN enterprise ON enterprise.id = customsdeclaration.enterpriseid
INNER JOIN product ON product.id = customsdeclaration.productid";
            cmd.ExecuteNonQuery();
        }

        private void InitMainScreenView(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE VIEW mainscreenview 
AS 
SELECT
	COUNT(customsdeclaration.id) as nodeclare, hsc,
    enterprise.name as enterprisename, enterprise.mst as enterprisemst
FROM
	customsdeclaration
INNER JOIN enterprise ON enterprise.id = customsdeclaration.enterpriseid
INNER JOIN product ON product.id = customsdeclaration.productid
GROUP BY hsc, enterprisename, enterprisemst";
            cmd.ExecuteNonQuery();
        }

        private void InitStatisticalView(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE VIEW statisticalview 
AS 
SELECT
	COUNT(customsdeclaration.id) as nodeclare, hsc,
     monthregister, yearregister
FROM
	customsdeclaration
INNER JOIN product ON product.id = customsdeclaration.productid
GROUP BY monthregister, yearregister, hsc";
            cmd.ExecuteNonQuery();
        }

        private void InitStatisticalSearchView(SQLiteConnection con)
        {
            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE VIEW statisticalsearchview 
AS 
SELECT
	COUNT(customsdeclaration.id) as nodeclare, hsc,
     monthregister, yearregister,
     enterprise.mst as enterprisemst, enterprise.name as enterprisename
FROM
	customsdeclaration
INNER JOIN enterprise ON enterprise.id = customsdeclaration.enterpriseid
INNER JOIN product ON product.id = customsdeclaration.productid
GROUP BY monthregister, yearregister, hsc, mst, enterprisename";
            cmd.ExecuteNonQuery();
        }
        #endregion

        public void SaveChange()
        {
            #region [Product]
            Products.SaveChange();
            Enterprises.SaveChange();
            CustomsDeclarations.SaveChange();
            #endregion
        }

        public string GetVersion()
        {
            string stm = "SELECT SQLITE_VERSION()";
            using var con = new SQLiteConnection(cs);
            con.Open();

            using var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();
            return version;
        }

        public void Dispose()
        {
            _dbContextDriver.Dispose();
        }
    }
}

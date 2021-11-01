using SKCT.Entity;

namespace SKCT.Dto
{
    public class EnterpriseDto
    {
        public EnterpriseDto(int id, string name, string mst)
        {
            Id = id;
            Name = name;
            MST = mst;
            FullName = $"{name} - {MST}";
        }

        public EnterpriseDto(Enterprise entity) : this(entity.Id, entity.Name, entity.MST)
        {
        }

        public int Id { get; set; }
        public string MST { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}

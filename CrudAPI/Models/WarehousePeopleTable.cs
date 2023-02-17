using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class WarehousePeopleTable
    {
        [Key]
        public Guid WarehousePeopleID { get; set; }
        public PeopleTable PeopleID { get; set; }
        public WarehouseTable WarehouseID { get; set; }

    }
}

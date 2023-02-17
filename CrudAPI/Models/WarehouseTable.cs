using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class WarehouseTable
    {
        [Key]
        public Guid WarehouseID { get; set; }
        public string WarehouseName { get;set; }
        public Guid WarehouseCode { get; set; }

    }
}

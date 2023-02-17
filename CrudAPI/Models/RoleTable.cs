using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class RoleTable
    {
        [Key]
        public Guid RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
    }
}

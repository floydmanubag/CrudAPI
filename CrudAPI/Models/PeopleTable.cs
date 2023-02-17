using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class PeopleTable
    {
        [Key]
        public Guid PeopleID { get; set; }
        public string PeopleName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public AddressTable AddressID { get; set; }
        public RoleTable RoleID { get; set; }
    }
}

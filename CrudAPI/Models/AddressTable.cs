using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class AddressTable
    {
        [Key]
        public Guid AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}

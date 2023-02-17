using System.ComponentModel.DataAnnotations;

namespace CrudAPI.DTO
{
    public class AddressDTO
    {
        public Guid ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}

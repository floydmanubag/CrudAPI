namespace CrudAPI.Models
{
    public class People
    {
        public string PeopleID { get; set; }
        public string PeopleName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public Address AddressID { get; set; }
        public Role RoleID { get; set; }
    }
}

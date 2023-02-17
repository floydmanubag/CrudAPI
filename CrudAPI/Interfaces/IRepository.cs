using CrudAPI.Models;

namespace CrudAPI.Interfaces
{
    public interface IRepository
    {
        ICollection <RoleTable> GetRoles();
        RoleTable GetRoleName (string name);
        RoleTable GetRoleCode (string code);

        ICollection <AddressTable> GetAddresses ();
        AddressTable GetAddressID (Guid id);
        AddressTable GetStreet (string street);
        AddressTable GetCity (string city);
        AddressTable GetState (string state);
        AddressTable GetPostalCode (string postalCode);
        AddressTable GetCountry (string country);

    }
}

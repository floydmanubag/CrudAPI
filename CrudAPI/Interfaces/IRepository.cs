using CrudAPI.Models;

namespace CrudAPI.Interfaces
{
    public interface IRepository
    {
        ICollection <Role> GetRoles();

        Role GetRoles (string id);


    }
}

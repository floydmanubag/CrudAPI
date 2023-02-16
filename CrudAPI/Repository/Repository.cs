using Microsoft.EntityFrameworkCore.Query.Internal;
using DBDataContext;
using CrudAPI.Interfaces;
using CrudAPI.Models;

namespace CrudAPI.Repository
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Role> GetRoles()
        {
            return _context.RoleModel.OrderBy(p=>p.RoleID).ToList();
        }
        public ICollection<Role> GetRolesID(string id)
        {
           
        }

        public Role GetRolesID(int id)
        {
            return _context.RoleModel.Where(r => r.RoleID == id).FirstOrDefault();
        }
    }
}

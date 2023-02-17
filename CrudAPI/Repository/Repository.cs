using Microsoft.EntityFrameworkCore.Query.Internal;
using DBDataContext;
using CrudAPI.Interfaces;
using CrudAPI.Models;
using CrudAPI.DTO;

namespace CrudAPI.Repository
{
    public class Repository : IRepository //logic
    {
        private readonly DataContext _context;

        public List<RoleDTO> ToRoleDTO()
        {
            var x = new List<RoleDTO>();
            var y = _context.RoleTable.ToList();

            foreach (var role in y)
            {
                var roledto = new RoleDTO();
                roledto.Id = role.RoleID;
                roledto.Name = role.RoleName;
                roledto.Code = role.RoleCode;
                x.Add(roledto);
            }
            return x;
        }

        public List<AddressDTO> ToAddressDTO() 
        {
            var x = new List<AddressDTO>();
            var y = _context.AddressTable.ToList();

            foreach (var a in y)
            {
                var addressdto = new AddressDTO();
                addressdto.ID = a.AddressID;
                addressdto.Street = a.Street;
                addressdto.City = a.City;
                x.Add(roledto);
            }
            return x;
        }

        #region
        public RoleTable GetRoleCode(string code)
        {
            return _context.RoleTable.Where(r => r.RoleCode == code).FirstOrDefault();
        }

        public RoleTable GetRoleID(Guid id)
        {
            return _context.RoleTable.Where(r => r.RoleID == id).FirstOrDefault();
        }

        public RoleTable GetRoleName(string name)
        {
            return _context.RoleTable.Where(r => r.RoleName == name).FirstOrDefault();
        }

        public ICollection<RoleTable> GetRoles()
        {
            return _context.RoleTable.OrderBy(p=>p.RoleID).ToList();
        }

        public AddressTable GetState(string state)
        {
            throw new NotImplementedException();
        }

        public AddressTable GetStreet(string street)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region
       

        public ICollection<AddressTable> GetAddresses()
        {
            throw new NotImplementedException();
        }

        public AddressTable GetAddressID(Guid id)
        {
            throw new NotImplementedException();
        }

        public AddressTable GetCity(string city)
        {
            throw new NotImplementedException();
        }

        public AddressTable GetCountry(string country)
        {
            throw new NotImplementedException();
        }

        public AddressTable GetPostalCode(string postalCode)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}

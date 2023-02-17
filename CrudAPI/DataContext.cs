using Microsoft.EntityFrameworkCore;
using CrudAPI;
using CrudAPI.Models;

namespace DBDataContext
{ 
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet <AddressTable> AddressTable { get; set; }
        public DbSet <PeopleTable> PeopleTable { get; set; }
        public DbSet <RoleTable> RoleTable { get; set; }

        public DbSet <WarehouseTable> WarehouseTable { get; set;}
        public DbSet <WarehousePeopleTable> WarehousePeopleTable { get;set; }



    }
}
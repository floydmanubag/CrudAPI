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

        public DbSet <AddressTable> AddressModel { get; set; }
        public DbSet <PeopleTable> PeopleModel { get; set; }
        public DbSet <RoleTable> RoleTable { get; set; }

        public DbSet <WarehouseTable> WarehouseModel { get; set;}
        public DbSet <WarehousePeopleTable> WarehousePeopleModel { get;set; }



    }
}
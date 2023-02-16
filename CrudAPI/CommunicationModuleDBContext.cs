﻿using Microsoft.EntityFrameworkCore;
using CrudAPI;
using CrudAPI.Models;

namespace CommunicationModule
{
    public class CommunicationModuleDBContext : DbContext
    {
        public CommunicationModuleDBContext(DbContextOptions<CommunicationModuleDBContext> options) : base(options)
        {

        }

        public DbSet <Address> AddressModel { get; set; }
        public DbSet <People> PeopleModel { get; set; }
        public DbSet <Role> RoleModel { get; set; }
        public DbSet <Warehouse> WarehouseModel { get; set;}
        public DbSet <WarehousePeople> WarehousePeopleModel { get;set; }

    }
}
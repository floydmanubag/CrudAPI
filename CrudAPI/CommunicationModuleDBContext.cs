using Microsoft.EntityFrameworkCore;
using CrudAPI;

namespace CommunicationModule
{
    public class CommunicationModuleDBContext : DbContext
    {
        public CommunicationModuleDBContext(DbContextOptions<CommunicationModuleDBContext> options) : base(options)
        {
        }

        public DbSet<> People { get; set; }
    }
}
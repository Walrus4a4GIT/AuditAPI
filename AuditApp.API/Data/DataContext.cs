using AuditApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AuditApp.API.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Audit> Audit { get; set; }
    }
}
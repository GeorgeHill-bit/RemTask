using RemTask.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RemTask.DAL
{
    public class BusinessContext : DbContext
    {
        public BusinessContext() : base ("BusinessContext")
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<TaskD> TaskDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
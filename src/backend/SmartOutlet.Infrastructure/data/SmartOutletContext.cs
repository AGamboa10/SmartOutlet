using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SmartOutlet.Core.models;
using Microsoft.Data.SqlClient.Server;


namespace SmartOutlet.Infrastructure.data
{
    public class SmartOutletContext: DbContext
    {
        public SmartOutletContext(DbContextOptions<SmartOutletContext>options): base(options)
        {
        }
        public DbSet<User> Users {get; set;}
        public DbSet<Regulator> Regulators {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
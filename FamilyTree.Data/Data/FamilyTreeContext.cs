using System.Data.Entity;
using FamilyTree.ApplicationCore.Entities;

namespace FamilyTree.Data.Data
{
    public class FamilyTreeContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Child> Children { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FamilyTreeContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}

using System.Data.Entity;
using Crystal_Stevens_Lab_3_Week_4.Data.Entities;
using System;

namespace Crystal_Stevens_Lab_3_Week_4.Data
{
    public class DbInfo : DbContext
    {
        public AppDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public virtual DbSet<User> Users { get; set; }
    }

    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppContext>
    {
    }
}

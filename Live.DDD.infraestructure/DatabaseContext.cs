using Live.DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Live.DDD.infraestructure
{

    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(o =>
            {
                o.HasKey(o => o.Id);

            });
            modelBuilder.Entity<Person>().OwnsOne(o=>o.Name,conf =>
            {
                conf.Property(x=>x.Value).HasColumnName("Name");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
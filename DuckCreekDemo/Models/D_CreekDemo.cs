namespace DuckCreekDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class D_CreekDemo : DbContext
    {
        public D_CreekDemo()
            : base("name=D_CreekDemo")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);
        }
    }
}

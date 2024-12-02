using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace solution5
{
    public partial class dbContact : DbContext
    {
        public dbContact()
            : base("name=dbContact")
        {
        }

        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<publisher> publishers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<book>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<book>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<publisher>()
                .Property(e => e.publisher_name)
                .IsUnicode(false);
        }
    }
}

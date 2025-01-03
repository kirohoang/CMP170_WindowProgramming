using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace solution5
{
    public partial class dbContact : DbContext
    {
        public dbContact()
            : base("name=dbContact1")
        {
        }

        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<publisher> publishers { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<author>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<author>()
                .Property(e => e.bio)
                .IsUnicode(false);

            modelBuilder.Entity<author>()
                .Property(e => e.nationality)
                .IsUnicode(false);

            modelBuilder.Entity<book>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<book>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .HasOptional(e => e.order_details)
                .WithRequired(e => e.order);

            modelBuilder.Entity<publisher>()
                .Property(e => e.publisher_name)
                .IsUnicode(false);

            modelBuilder.Entity<order_details>()
                .Property(e => e.price)
                .HasPrecision(10, 2);
        }
    }
}

using CMS.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data
{
    public class CMSContext : DbContext
    {
        public CMSContext() : base("name=CMSConnection")
        {
        }

        DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Category fields

            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Category>().Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(0);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().Property(c => c.Name)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnOrder(1);

            modelBuilder.Entity<Category>().Property(c => c.Slug)
                .HasMaxLength(250)
                .IsRequired()
                .HasColumnOrder(2);

            modelBuilder.Entity<Category>().Property(c => c.Description)
                .IsMaxLength()
                .HasColumnOrder(3);
        }
    }
}

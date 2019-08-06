using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RMFApi.Models
{
    public partial class rmfContext : DbContext
    {
        public rmfContext()
        {
        }

        public rmfContext(DbContextOptions<rmfContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invitation> Invitation { get; set; }
        public virtual DbSet<Rmfuser> Rmfuser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Invitation>(entity =>
            {
                entity.HasKey(e => e.Iid);

                entity.Property(e => e.Iid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(replace(newid(),'-',''))");

                entity.Property(e => e.Icode).HasMaxLength(50);

                entity.Property(e => e.Idate)
                    .HasColumnName("idate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isign)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Rmfuser>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("RMFUser");

                entity.Property(e => e.Rid)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(replace(newid(),'-',''))");

                entity.Property(e => e.Rname).HasMaxLength(50);

                entity.Property(e => e.Rpwd).HasMaxLength(50);

                entity.Property(e => e.Rsign)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");
            });
        }
    }
}

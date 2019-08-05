﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstCore.Model
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
                    .HasDefaultValueSql("(replace(newid(),'-',''))");

                entity.Property(e => e.Icode).HasMaxLength(50);

                entity.Property(e => e.Idate)
                    .HasColumnName("idate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isign)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace bier_backend.Models
{
    public partial class bierContext : DbContext
    {
        public bierContext()
        {
        }

        public bierContext(DbContextOptions<bierContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bier> Biers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=.\\bier.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bier>(entity =>
            {
                entity.ToTable("bier");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .HasColumnName("id");

                entity.Property(e => e.Brouwer)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("brouwer");

                entity.Property(e => e.Gisting)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("gisting");

                entity.Property(e => e.InkoopPrijs)
                    .HasColumnType("decimal(5,2)")
                    .HasColumnName("inkoop_prijs");

                entity.Property(e => e.Naam)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("naam");

                entity.Property(e => e.Perc)
                    .HasColumnType("float")
                    .HasColumnName("perc");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

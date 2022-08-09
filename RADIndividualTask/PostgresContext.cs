using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RADIndividualTask.Models1;


public partial class PostgresContext : DbContext
    {
        public PostgresContext()
        {
        }

        public PostgresContext(DbContextOptions<PostgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InputReport> InputReports { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<OutputReport> OutputReports { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pg_catalog", "adminpack");

            modelBuilder.Entity<InputReport>(entity =>
            {
                entity.ToTable("InputReport");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.CostPerUnit).HasColumnName("cost_per_unit");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.TotalCost).HasColumnName("total_cost");

                entity.Property(e => e.Units).HasColumnName("units");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.InputReports)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("InputReport_material_id_fkey");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Material_provider_id_fkey");
            });

            modelBuilder.Entity<OutputReport>(entity =>
            {
                entity.ToTable("OutputReport");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.PricePerUnit).HasColumnName("price_per_unit");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.TotalProfit).HasColumnName("total_profit");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OutputReports)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OutputReport_product_id_fkey");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Materials).HasColumnName("materials");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Loan).HasColumnName("loan");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }


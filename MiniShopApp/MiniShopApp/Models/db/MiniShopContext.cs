using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models.db
{
    public partial class MiniShopContext : DbContext
    {
        public MiniShopContext()
        {
        }

        public MiniShopContext(DbContextOptions<MiniShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<SalesDtl> SalesDtl { get; set; }
        public virtual DbSet<Shelfs> Shelfs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning
                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=MiniShop;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatCreate).HasColumnType("datetime");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CatUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId).HasMaxLength(13);

                entity.Property(e => e.EmpAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EmpBirthday).HasColumnType("date");

                entity.Property(e => e.EmpCraete).HasColumnType("datetime");

                entity.Property(e => e.EmpGender)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EmpPassword)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmpPhon)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmpPhoto).HasMaxLength(18);

                entity.Property(e => e.EmpRole)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.EmpState)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.EmpTitle)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.EmpUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.Property(e => e.ProId).HasMaxLength(13);

                entity.Property(e => e.ProCreate).HasColumnType("datetime");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ProPhoto).HasMaxLength(18);

                entity.Property(e => e.ProSize)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProState)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ProUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Shf)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ShfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Shelfs");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.SaleCreate).HasColumnType("datetime");

                entity.Property(e => e.SaleUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Employees");
            });

            modelBuilder.Entity<SalesDtl>(entity =>
            {
                entity.HasKey(e => e.SdtId);

                entity.Property(e => e.ProId)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.SalesDtl)
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDtl_Products");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalesDtl)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDtl_Sales");
            });

            modelBuilder.Entity<Shelfs>(entity =>
            {
                entity.HasKey(e => e.ShfId);

                entity.Property(e => e.ShfCreate).HasColumnType("datetime");

                entity.Property(e => e.ShfName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShfUpdate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MiniShopApp.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SaleDtl> SaleDtl { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Shelf> Shelf { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\MiniShopApp\Database\minishop.mdf;Integrated Security=True;Connect Timeout=30;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Category__17B6DD2693591EDF");

                entity.Property(e => e.CatId).HasColumnName("catID");

                entity.Property(e => e.CatCreate)
                    .HasColumnName("catCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasColumnName("catName")
                    .HasMaxLength(150);

                entity.Property(e => e.CatUpdate)
                    .HasColumnName("catUpdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId)
                    .HasColumnName("empID")
                    .HasMaxLength(13);

                entity.Property(e => e.EmpAddress)
                    .IsRequired()
                    .HasColumnName("empAddress")
                    .HasMaxLength(200);

                entity.Property(e => e.EmpAge).HasColumnName("empAge");

                entity.Property(e => e.EmpBirthday)
                    .HasColumnName("empBirthday")
                    .HasColumnType("date");

                entity.Property(e => e.EmpCraete)
                    .HasColumnName("empCraete")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpGender)
                    .IsRequired()
                    .HasColumnName("empGender")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasColumnName("empName")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpPassword)
                    .IsRequired()
                    .HasColumnName("empPassword")
                    .HasMaxLength(30);

                entity.Property(e => e.EmpPhone)
                    .IsRequired()
                    .HasColumnName("empPhone")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpPhoto)
                    .HasColumnName("empPhoto")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpRole)
                    .IsRequired()
                    .HasColumnName("empRole")
                    .HasMaxLength(10);

                entity.Property(e => e.EmpState)
                    .IsRequired()
                    .HasColumnName("empState")
                    .HasMaxLength(8);

                entity.Property(e => e.EmpTitle)
                    .IsRequired()
                    .HasColumnName("empTitle")
                    .HasMaxLength(100);

                entity.Property(e => e.EmpUpdate)
                    .HasColumnName("empUpdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.Property(e => e.ProId)
                    .HasColumnName("proID")
                    .HasMaxLength(13);

                entity.Property(e => e.CatId).HasColumnName("catID");

                entity.Property(e => e.ProCost).HasColumnName("proCost");

                entity.Property(e => e.ProCraete)
                    .HasColumnName("proCraete")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasColumnName("proName")
                    .HasMaxLength(100);

                entity.Property(e => e.ProPhoto)
                    .HasColumnName("proPhoto")
                    .HasMaxLength(18);

                entity.Property(e => e.ProPrice).HasColumnName("proPrice");

                entity.Property(e => e.ProQuantity).HasColumnName("proQuantity");

                entity.Property(e => e.ProSize)
                    .HasColumnName("proSize")
                    .HasMaxLength(20);

                entity.Property(e => e.ProUpdate)
                    .HasColumnName("proUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShfId).HasColumnName("shfID");
            });

            modelBuilder.Entity<SaleDtl>(entity =>
            {
                entity.HasKey(e => e.SdtlId);

                entity.Property(e => e.SdtlId).HasColumnName("sdtlID");

                entity.Property(e => e.ProId)
                    .IsRequired()
                    .HasColumnName("proID")
                    .HasMaxLength(13);

                entity.Property(e => e.SaleId).HasColumnName("saleID");

                entity.Property(e => e.SdtdlQty).HasColumnName("sdtdlQty");

                entity.Property(e => e.SdtlAmount).HasColumnName("sdtlAmount");

                entity.Property(e => e.SdtlCraete)
                    .HasColumnName("sdtlCraete")
                    .HasColumnType("datetime");

                entity.Property(e => e.SdtlUpdate)
                    .HasColumnName("sdtlUpdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.Property(e => e.SaleId).HasColumnName("saleID");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("empID")
                    .HasMaxLength(13);

                entity.Property(e => e.SaleAmount).HasColumnName("saleAmount");

                entity.Property(e => e.SaleCraete)
                    .HasColumnName("saleCraete")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaleUpdate)
                    .HasColumnName("saleUpdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.HasKey(e => e.ShfId)
                    .HasName("PK__Shelf__043343D1ABA224E0");

                entity.Property(e => e.ShfId).HasColumnName("shfID");

                entity.Property(e => e.ShfCraete)
                    .HasColumnName("shfCraete")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShfName)
                    .IsRequired()
                    .HasColumnName("shfName")
                    .HasMaxLength(100);

                entity.Property(e => e.ShfNumber)
                    .IsRequired()
                    .HasColumnName("shfNumber")
                    .HasMaxLength(20);

                entity.Property(e => e.ShfUpdate)
                    .HasColumnName("shfUpdate")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }
}

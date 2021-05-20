using Burak_CoreEntityCodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burak_CoreEntityCodeFirst.DataContext
{
    /// Bazi kisimlar IEntityTypeConfiguration objelerinin icine alindi, kodu temiz tutmak icin.
    /// Buradan ne olduklarina bakabilirsiniz. <seealso cref="CourseMap"/> <seealso cref="ProductMap"/>
    /// https://stackoverflow.com/questions/43070306/entity-framework-core-configurations
    /// PostgreSQL indirme linki: https://www.enterprisedb.com/downloads/postgres-postgresql-downloads
    public class CoreDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; } // Table splitting.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }


        /// Cakma entity splitting <see cref="EntitySplitting"/>
        public DbSet<AppUser> Users { get; set; } 

        // Private yapmamizin sebebi zaten Users icinden bunlara erisebilecegiz.
        // TPT native olarak desteklenmedigi icin yazmamiz gerekiyor.
        // One-to-One iliski olusturuyoruz aslinda yani.
        private DbSet<AppUserLoginDetails> UserLoginDetails { get; set; }
        private DbSet<AppUserContactDetails> UserContactDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=burak_db;Username=postgres;Password=123");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //EntitySplitting(modelBuilder);
            TableSplitting(modelBuilder);
            ManyToMany(modelBuilder);
            ConditionalMapping(modelBuilder);
        }

        // Bunun Core versiyonunu bir turlu beceremedim. Hocamiz ile beraber bakabiliriz.
        private void ConditionalMapping(ModelBuilder modelBuilder)
        {
            // Yeni versiyon.
            //modelBuilder.ApplyConfiguration(new ProductMap());

            // Eski versiyon
            //modelBuilder.Entity<Product>()
            //    .Map(p => p.Requires("IsActive").HasValue(true))
            //    .Ignore(m => m.IsActive);
        }

        private void ManyToMany(ModelBuilder modelBuilder)
        {
            // Yeni versiyon CourseMap'in icinde.
            modelBuilder.ApplyConfiguration(new CourseMap());
            
            // Eski versiyon
            //modelBuilder.Entity<Course>()
            //    .HasMany(course => course.Students)
            //    .WithMany(student => student.Courses)
            //    .Map(map =>
            //    {
            //        map.ToTable("CoursesStudents");
            //        map.MapLeftKey("CourseID");
            //        map.MapRightKey("StudentID");
            //    });
        }

        // https://www.learnentityframeworkcore.com/configuration/one-to-one-relationship-configuration
        // EntityFrameworkCore.Relational yuklu degilse hata verecektir.
        private void TableSplitting(ModelBuilder modelBuilder)
        {
            var employee = modelBuilder.Entity<Employee>();
            var contactDetail = modelBuilder.Entity<EmployeeContactDetail>();

            // Yeni versiyon
            // One to One iliski tanimlamasi
            employee
                .HasOne(p => p.EmployeeContactDetail)
                .WithOne(y => y.Employee)
                .HasForeignKey<EmployeeContactDetail>(detail => detail.EmployeeID);

            // Core'da HasKey ile ToTable zincirlenemiyor, ama tam tersi oluyor.
            employee
                .ToTable("Employees")
                .HasKey(e => e.EmployeeID);
            contactDetail
                .ToTable("Employees")
                .HasKey(e => e.EmployeeID);

            // Eski versiyon
            // One to One iliski tanimlamasi.
            //modelBuilder.Entity<Employee>()
            //    .HasRequired(p => p.EmployeeContactDetail)
            //    .WithRequiredPrincipal(y => y.Employee);

            //employee
            //    .HasKey(k => k.EmployeeID)
            //    .ToTable("Employees");

            //contactDetail
            //    .HasKey(k => k.EmployeeID)
            //    .ToTable("Employees");
        }

        // https://stackoverflow.com/questions/45780404/one-entity-2-tables-in-ef-core-2-0
        // https://github.com/dotnet/efcore/issues/620
        // Entity Splitting EF Core'da maalesef desteklenmiyor. Onun yerine asagidaki linkteki Table-Per-Type (TPT) 
        // yontemini kullanarak Entity Splitting'e benzer bir yapi olusturabilirsiniz, ama daha mesakkatli olacak ve
        // Her type icin bir DbSet olusturmaniz gerekecek, hic kullanmayacak olsaniz bile.
        // Burada bir sey yapmamiza gerek yok, Key ve Foreign Key'leri AppUser ve objelerinde attribute ile tanimladik.
        // https://www.thinktecture.com/en/entity-framework-core/table-per-type-inheritance-support-part-1-code-first/
        private void EntitySplitting(ModelBuilder modelBuilder)
        {
            // Eski versiyon
            //modelBuilder.Entity<AppUser>()
            //    .Map(map =>
            //    {
            //        map.Properties(u => new
            //        {
            //            u.ID,
            //            u.Username,
            //            u.Password
            //        });
            //        map.ToTable("UserAccountInfo");
            //    })
            //    .Map(map =>
            //    {
            //        map.Properties(u => new
            //        {
            //            u.ID,
            //            u.ContactNumber,
            //            u.Address
            //        });
            //        map.ToTable("UserContactDetails");
            //    });
        }

    }
}

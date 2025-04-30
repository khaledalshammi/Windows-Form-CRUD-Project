using System.Collections.Generic;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WindowsFormsApp1
{
    public class UserProfileDBContext : DbContext
    {
        public UserProfileDBContext() : base("name=UserProfile") {
            
            if (!this.Database.Exists())
            {
                this.Database.Create();
                SeedData();
            }
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<UserProfile>()
                .Property(u => u.FullName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            modelBuilder.Entity<UserProfile>()
                .Property(u => u.Email)
                .HasMaxLength(50)
                .HasColumnType("varchar");

            modelBuilder.Entity<UserProfile>()
                .Property(u => u.BirthDate)
                .HasColumnType("smalldatetime");

            modelBuilder.Entity<UserProfile>()
               .HasRequired(u => u.Department)
               //.HasOptional(u => u.Department)
               .WithMany(d => d.UserProfiles)
               .HasForeignKey(u => u.DepartmentID);
            //.WillCascadeOnDelete(true); 

            modelBuilder.Entity<Department>()
                .Property(n => n.DeptName)
                .HasMaxLength(50);

            base.OnModelCreating(modelBuilder);
        }
        private void SeedData()
        {
            var departments = new List<Department>
            {
                new Department { DeptName = "Human Resources" },
                new Department { DeptName = "Information Technology (IT)" },
                new Department { DeptName = "Finance" },
                new Department { DeptID = 4, DeptName = "Marketing" },
                new Department { DeptID = 5, DeptName = "Sales" },
                new Department { DeptID = 6, DeptName = "Customer Service" },
                new Department { DeptID = 7, DeptName = "Research and Development" },
                new Department { DeptID = 8, DeptName = "Operations" },
                new Department { DeptID = 9, DeptName = "Legal" },
                new Department { DeptID = 10, DeptName = "Procurement" }
            };

            Departments.AddRange(departments);
            SaveChanges();

            var userprofiles = new List<UserProfile>
            {
                new UserProfile { FullName = "Khaled Alchami", Email = "khaledalchami@gmail.com", BirthDate = new DateTime(1995, 5, 15), DepartmentID = 1 },
                new UserProfile { FullName = "Ahmed Alchami", Email = "Ahmedalchami@gmail.com", BirthDate = new DateTime(1975, 7, 10), DepartmentID = 2 },
                new UserProfile { FullName = "Ahed Osama", Email = "AhedOsama@gmail.com", BirthDate = new DateTime(2002, 11, 5), DepartmentID = 1 },
                new UserProfile { FullName = "Eslam Shaikh", Email = "EslamShaikh@gmail.com", BirthDate = new DateTime(1967, 2, 2), DepartmentID = 2 },
                new UserProfile { FullName = "Sahar Adnan", Email = "SaharAdnan@gmail.com", BirthDate = new DateTime(2005, 9, 22), DepartmentID = 1 },
                new UserProfile { FullName = "Haris Amman", Email = "HarisAmman@gmail.com", BirthDate = new DateTime(1955, 3, 26), DepartmentID = 3 }
            };

            UserProfiles.AddRange(userprofiles);
            SaveChanges();
        }
    }
}
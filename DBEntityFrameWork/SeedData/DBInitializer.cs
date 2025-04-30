using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DBEntityFrameWork
{
    public class DBInitializer : CreateDatabaseIfNotExists<UserProfileDBContext>
    {
        protected override void Seed(UserProfileDBContext context)
        {
            GetDepartments().ForEach(c => context.Departments.Add(c));
            GetUserProfiles().ForEach(c => context.UserProfiles.Add(c));
            
        }
        private static List<Department> GetDepartments()
        {
            var departments = new List<Department> {
                new Department
                {
                    DeptID = 1,
                    DeptName = "Human Resources"
                },
                new Department
                {
                    DeptID = 2,
                    DeptName = "Information Technology (IT)"
                },
                new Department
                {
                    DeptID = 3,
                    DeptName = "Finance"
                }
            };
            return departments;
        }

        private static List<UserProfile> GetUserProfiles()
        {
            var userprofiles = new List<UserProfile> {
                new UserProfile
                {
                    UserID = 1,
                    FullName = "Khaled Alchami",
                    Email = "khaledalchami@gmail.com",
                    BirthDate = new DateTime(1995, 5, 15),
                    DepartmentID = 1
                },
                new UserProfile
                {
                    UserID = 2,
                    FullName = "Ahmed Alchami",
                    Email = "Ahmedalchami@gmail.com",
                    BirthDate = new DateTime(1975, 7, 10),
                    DepartmentID = 2
                },
                new UserProfile
                {
                    UserID = 3,
                    FullName = "Ahed Osama",
                    Email = "AhedOsama@gmail.com",
                    BirthDate = new DateTime(2002, 11, 5),
                    DepartmentID = 1
                },
                new UserProfile
                {
                    UserID = 4,
                    FullName = "Eslam Shaikh",
                    Email = "EslamShaikh@gmail.com",
                    BirthDate = new DateTime(1967, 2, 2),
                    DepartmentID = 2
                },
                new UserProfile
                {
                    UserID = 5,
                    FullName = "Sahar Adnan",
                    Email = "SaharAdnan@gmail.com",
                    BirthDate = new DateTime(2005, 9, 22),
                    DepartmentID = 1
                },
                new UserProfile
                {
                    UserID = 6,
                    FullName = "Haris Amman",
                    Email = "HarisAmman@gmail.com",
                    BirthDate = new DateTime(1955, 3, 26),
                    DepartmentID = 3
                }
            };
            return userprofiles;
        }
    }
}

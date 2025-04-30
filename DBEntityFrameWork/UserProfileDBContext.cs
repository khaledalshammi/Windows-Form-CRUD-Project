using System.Data.Entity;

namespace DBEntityFrameWork
{
    public class UserProfileDBContext : DbContext
    {
        public UserProfileDBContext() : base("name=UserProfile") {}

        public DbSet<Department> Departments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
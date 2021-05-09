using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Entities;
using SchoolManagement.Infrastructure.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Infrastructure
{
    public class SchoolManagementDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<RegistrationRequest> RegistrationRequests { get; set; }
        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUsers(builder);
            SeedRoles(builder);
            SeedUserRoles(builder);
        }
        private void SeedUsers(ModelBuilder builder)
        {
            var users = new List<ApplicationUser>();
            ApplicationUser staff = new ApplicationUser()
            {
                Id = "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                UserName = "Staff",
                NormalizedUserName = "STAFF",
                Email = "staff@gmail.com",
                NormalizedEmail = "STAFF@GMAIL.COM",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Majdi",
                LastName = "Mohammad"
            };
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            staff.PasswordHash = passwordHasher.HashPassword(staff, "Staff_2855191");
            users.Add(staff);

            ApplicationUser humanResource = new ApplicationUser()
            {
                Id = "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                UserName = "Human_Resource",
                NormalizedUserName = "HUMAN_RESOURCE",
                Email = "hr@gmail.com",
                NormalizedEmail = "HR@GMAIL.COM",
                LockoutEnabled = false,
                PhoneNumber = "1234567890",
                FirstName = "Human",
                LastName = "Resource"
            };

            humanResource.PasswordHash = passwordHasher.HashPassword(humanResource, "Human_2855191");
            users.Add(humanResource);

            builder.Entity<ApplicationUser>().HasData(users);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "63804a41-a74f-427b-9050-a0d6da67c9ff", Name = "Staff", ConcurrencyStamp = "1", NormalizedName = "Staff" },
                new IdentityRole() { Id = "d6a4e500-5129-498e-af5d-1f6e3191d32f", Name = "HumanResource", ConcurrencyStamp = "2", NormalizedName = "Human Resource" },
                new IdentityRole() { Id = "8c896fa0-220b-42df-a9fd-57c607e44959", Name = "Student", ConcurrencyStamp = "3", NormalizedName = "Student" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "63804a41-a74f-427b-9050-a0d6da67c9ff", UserId = "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3" },
                new IdentityUserRole<string>() { RoleId = "d6a4e500-5129-498e-af5d-1f6e3191d32f", UserId = "da63bd40-0661-4fc3-9d7a-e0d397c027af" }
                );
        }
    }
}

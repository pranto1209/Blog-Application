using BlogApplicationAPI.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogApplicationAPI.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext()
        {
        }

        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = UserRoleClass.Reader,
                    Name = UserRoleClass.Reader,
                    NormalizedName = UserRoleClass.Reader.ToUpper()
                },
                new IdentityRole()
                {
                    Id = UserRoleClass.Writer,
                    Name = UserRoleClass.Writer,
                    NormalizedName = UserRoleClass.Writer.ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}

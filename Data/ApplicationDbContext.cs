using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mixerpa.Models;

namespace Mixerpa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mixerpa.Models.Member> Member { get; set; }
        public DbSet<Mixerpa.Models.Company> Company { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Member>()
                .HasData(
                    new Member
                    {
                        MemberID = 1,
                        CompanyID = 1,
                        Email = "user01@mixerpa.com",
                        Name = "First",
                        LastName = "User01",
                        BirthDate = DateTime.Parse("1990-01-01")
                    },
                    new Member
                    {
                        MemberID = 2,
                        CompanyID = 1,
                        Email = "user02@mixerpa.com",
                        Name = "Second",
                        LastName = "User02",
                        BirthDate = DateTime.Parse("2001-02-03")
                    },
                    new Member
                    {
                        MemberID = 3,
                        CompanyID = 2,
                        Email = "user03@mixerpa.com",
                        Name = "Third",
                        LastName = "User03",
                        BirthDate = DateTime.Parse("2012-03-04")
                    }
                );

            builder.Entity<Company>()
                .HasData(
                    new Company
                    {
                        CompanyID = 1,
                        CompanyName = "Company01"
                    },
                    new Company
                    {
                        CompanyID = 2,
                        CompanyName = "Company02"
                    }
                );
        }
    }
}
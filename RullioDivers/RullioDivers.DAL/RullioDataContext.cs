using Microsoft.EntityFrameworkCore;
using RullioDivers.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RullioDivers.DAL
{
    public class RullioDataContext : DbContext
    {
        public RullioDataContext(DbContextOptions<RullioDataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<DiverSchool> DiverSchools { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //DiverSchool Builder
            builder.Entity<DiverSchool>()
                .HasMany<User>()
                .WithOne(u => u.DiverSchool)
                .HasForeignKey(ds => ds.DiverSchoolID);

            //User Builder
            builder.Entity<User>()
                .HasOne<DiverSchool>()
                .WithMany(ds => ds.Users)
                .HasForeignKey(u => u.DiverSchoolID);
        }
    }
}

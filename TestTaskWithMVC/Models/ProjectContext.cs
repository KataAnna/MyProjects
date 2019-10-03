using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskWithMVC.Models
{
    public class ProjectContext : System.Data.Entity.DbContext
    {
        //public System.Data.Entity.DbSet<Project> Projects { get; set; }
        public System.Data.Entity.DbSet<Programmer> Programmers { get; set; }

        // public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Programmer>()
        //        .HasMany(c => c.Projects)
        //        .WithMany(s => s.Programmers)
        //        .Map(cs =>
        //                {
        //                    cs.MapLeftKey("ProgrammerId")
        //                  cs.MapRightKey("ProjectId")
        //                  cs.ToTable("Working")
        //                });

        //}
    }
}

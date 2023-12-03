using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.DBContext
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Vehicle>()
        //        .HasOne(v => v.Visitor)
        //        .WithOne(vi => vi.Vehicle)
        //        .HasForeignKey<Visitor>(vi => vi.Id)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
        //public class YourDbContextFactory : IDesignTimeDbContextFactory<ProjectDBContext>
        //{
        //    public ProjectDBContext CreateDbContext(string[] args)
        //    {
        //        var optionsBuilder = new DbContextOptionsBuilder<ProjectDBContext>();
        //        optionsBuilder.UseSqlServer("Server=.;Database=AuthorizationAuthenticationProject;Trusted_Connection=True;TrustServerCertificate=True;");
        //        return new ProjectDBContext(optionsBuilder.Options);
        //    }
        //}
        public DbSet<VehicleType> VehicleType { get; set; }
        public DbSet<VehicleColor> VehicleColor { get; set; }
        public DbSet<VehicleBrand> Brand { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Visitor> Visitor { get; set; }
        public DbSet<Visit> Visit { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<AccessPath> AccessPath { get; set; }
    }

}

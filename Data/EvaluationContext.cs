using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMTVendorEvaluationWebApp.Models;
using GMTVendorEvaluationWebApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GMTVendorEvaluationWebApp.Data
{
    public class EvaluationContext : DbContext
    {
        public EvaluationContext(DbContextOptions<EvaluationContext> options) : base(options)
        {
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product_Service> Products_Services { get; set; }
        public DbSet<Criteria> Criteria { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<VendorEvaluation> VendorEvaluations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Product_Service>().ToTable("Product_Service");
            modelBuilder.Entity<Criteria>().ToTable("Criteria");
            modelBuilder.Entity<Evaluation>().ToTable("Evaluation");
            modelBuilder.Entity<VendorEvaluation>().HasNoKey();
        }
    }
}

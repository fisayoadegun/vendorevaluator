using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GMTVendorEvaluationWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace GMTVendorEvaluationWebApp.Models
{
    public class ApplicationContext : IdentityDbContext<User, IdentityRole, string>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
      : base(options)
        {
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
        }

       

        
    }
}


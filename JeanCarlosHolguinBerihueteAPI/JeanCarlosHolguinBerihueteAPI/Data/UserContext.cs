using JeanCarlosHolguinBerihueteAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeanCarlosHolguinBerihueteAPI.Data
{
    public class UserContext : DbContext{

        public UserContext(DbContextOptions<UserContext> options) : base(options) { 
        
        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
    }
}

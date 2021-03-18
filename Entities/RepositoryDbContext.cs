﻿using Entities.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class RepositoryDbContext : DbContext
    {
        public RepositoryDbContext(DbContextOptions<RepositoryDbContext> options) : base(options)
        {
        }
        
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
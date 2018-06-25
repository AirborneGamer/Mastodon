﻿using OsOEasy.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using OsOEasy.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OsOEasy.API.Data
{
    public class APIDbContext : IdentityDbContext<ApplicationUser>
    {

        public APIDbContext(DbContextOptions<APIDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OsOEasy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<PromotionStats> PromotionStats { get; set; }
        public DbSet<PromotionEntries> PromotionEntries { get; set; }
    }
}
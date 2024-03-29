﻿using Microsoft.EntityFrameworkCore;
using Productify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Persistent.Contexts
{
    public class ProductifyDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("ProductifyDb");
            optionsBuilder.UseNpgsql("Server=91.151.83.102;Port=5432;Database=ShopifyMertMisirli;User Id=ahmetkokteam;Password=;");
            //optionsBuilder.UseNpgsql();
        }
    }
}

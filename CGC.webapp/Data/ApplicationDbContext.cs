﻿
using CGC.webapp.Data;
using CGC.webapp.Web.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CGC.webapp.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext <Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<Customer>Customers  { get; set; }
        public DbSet<Inventory>Inventories  { get; set; }

        public DbSet<Order>Orders  { get; set; }
        public DbSet<Product>Products  { get; set; }
        public DbSet<Supplier>Suppliers  { get; set; }
}
}
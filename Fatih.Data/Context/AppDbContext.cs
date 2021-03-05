using Fatih.Core.Models;
using Fatih.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatih.Data.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AHMET_SUHAN_OKA;Initial Catalog=Deneme.finalProject2_2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        */

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<CourierAddress> CourierAddresses { get; set; }
        public DbSet<CourierComment> CourierComments { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CourierAddressConfiguration());
            modelBuilder.ApplyConfiguration(new CourierCommentConfiguration());
            modelBuilder.ApplyConfiguration(new CourierConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCommentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new UserAddressConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserTypeConfiguration());

            //one-to-one relations
            modelBuilder.Entity<Courier>().HasOne<CourierAddress>(c => c.CourierAddress)
                .WithOne(ca => ca.Courier).HasForeignKey<CourierAddress>(ca => ca.CourierAddressId);
            modelBuilder.Entity<User>().HasOne<UserAddress>(u => u.UserAddress)
                .WithOne(ua => ua.User).HasForeignKey<UserAddress>(ua => ua.UserAddressId);

            //one to many 
            modelBuilder.Entity<Product>().HasMany(p => p.ProductComments)
                 .WithOne(p => p.Product);

        }



    }
}

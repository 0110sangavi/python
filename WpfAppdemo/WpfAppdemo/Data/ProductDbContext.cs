using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppdemo.Data
{
    public class ProductDbContext : DbContext
    {
        #region Constructor
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<Product> Products { get; set; }
        #endregion

        #region Overridden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private Product[] GetProducts()
        {
            return new Product[]
            {
            new Product { Id = 1, Name = "TShirt", Description = "Blue Color", Price = 2.99, Unit =1},
            new Product { Id = 2, Name = "Shirt", Description = "Formal Shirt", Price = 12.99, Unit =1},
            new Product { Id = 3, Name = "Socks", Description = "Wollen", Price = 5.00, Unit =2},
            new Product { Id = 4, Name = "Tshirt", Description = "Red", Price = 2.99, Unit =3},
            };
        }
        #endregion
    }

    public class ModelBuilder
    {
        internal object Entity<T>()
        {
            throw new NotImplementedException();
        }
    }

    public class DbSet<T>
    {
    }

    internal class Database
    {
        internal static void EnsureCreated()
        {
            throw new NotImplementedException();
        }
    }

    public class DbContextOptions<T>
    {
    }

    public class DbContext
    {
        private DbContextOptions<ProductDbContext> options;

        public DbContext(DbContextOptions<ProductDbContext> options)
        {
            this.options = options;
        }

        internal void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }

    class Base
    {
        protected override HasData(GetProducts()); 
        {
           private HasData(GetProducts());
            

    }

    internal class GetProducts
    {
    }
}

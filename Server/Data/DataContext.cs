﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Galaxy",
                    Description = "Who cares about Galaxy",
                    ImageUrl = "https://images.photowall.com/products/71364/milky-way-galaxy.jpg?h=699&q=85",
                    Price = 9.99m
                }, new Product
                {
                    Id = 2,
                    Title = "Mayo",
                    Description = "Mjód na moje serce",
                    ImageUrl = "https://www.winiary.pl/sites/default/files/styles/product_image_desktop_617_900/public/Winiary%20Majonez%20dekoracyjny%20400ml%203d_0.png?itok=dm9MOq3L",
                    Price = 7.99m
                }, new Product
                {
                    Id = 3,
                    Title = "Rykoszet",
                    Description = "Najlepszy portal z newsami o world of tanks",
                    ImageUrl = "https://rykoszet.info/wp-content/uploads/2022/02/MYhGBv2.png",
                    Price = 1113.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }

    }
}

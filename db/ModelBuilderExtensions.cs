using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Microsoft.EntityFrameworkCore;
using PruebaAPI.models;

namespace PruebaAPI.db
{
    public static class ModelBuilderExtensions
    {
        public static List<Product> GenerateTestProducts(int quantity)
        {
            int Id = 1;
            var faker = new Faker<Product>()
                .RuleFor(p => p.Id, f => Id++)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Price, f => double.Parse(f.Commerce.Price()))
                .RuleFor(p => p.CategoryId, f => f.Random.Int(1, 3))
                .RuleFor(p => p.CreatedAt, f => DateTime.Now);

            return faker.Generate(quantity);
        }

        public static List<ProductImage> GenerateTestImages(int quiantity)
        {
            int Id = 1;
            var faker = new Faker<ProductImage>()
                .RuleFor(p => p.Id, f => Id++)
                .RuleFor(p => p.ProductId, f => f.Random.Int(1, 10))
                .RuleFor(p => p.Url, f => f.Image.PicsumUrl())
                .RuleFor(p => p.CreatedAt, f => DateTime.Now);

            return faker.Generate(quiantity);
        }
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Usuario1", Email = "example@example.com", Password = "1234", CreatedAt = DateTime.Now },
                new User { Id = 2, Name = "Usuario2", Email = "example1@example.com", Password = "1234", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus { Id = 1, Status = "Pendiente", CreatedAt = DateTime.Now },
                new OrderStatus { Id = 2, Status = "En proceso", CreatedAt = DateTime.Now },
                new OrderStatus { Id = 3, Status = "Completado", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Protein", CreatedAt = DateTime.Now },
                new Category { Id = 2, Name = "Creatine", CreatedAt = DateTime.Now },
                new Category { Id = 3, Name = "Pre-Workout", CreatedAt = DateTime.Now }
            );

            GenerateTestProducts(10).ForEach(p => modelBuilder.Entity<Product>().HasData(p));
            GenerateTestImages(10).ForEach(i => modelBuilder.Entity<ProductImage>().HasData(i));
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab2.Models
{
    public class NewsContext:DbContext
    {
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-6H9B8GJ\\SQLEXPRESS; Database=CodeFirtNews;Trusted_Connection=True;TrustServerCertificate=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalog>().HasData(
                    new Catalog() { ID = 1, Name = "Business", Description = "Business" },
                    new Catalog() { ID = 2, Name = "Sports", Description = "Sports" },
                    new Catalog() { ID = 3, Name = "Entertainment", Description = "Entertainment" }
                );

            modelBuilder.Entity<Author>().HasData(
                    new Author() { Id = 1, Name = "Ahmed Hassan", Username = "Ahmed Hassan", Password = "123", JoinDate = new DateOnly(2012, 5, 1) },
                    new Author() { Id = 2, Name = "Mona Mohamed", Username = "Mona Mohamed", Password = "123", JoinDate = new DateOnly(2012, 5, 1) },
                    new Author() { Id = 3, Name = "Mazen Mostafa", Username = "Mazen Mostafa", Password = "123", JoinDate = new DateOnly(2012, 5, 1) }
                );

            modelBuilder.Entity<News>().HasData(
                    new News() { Id = 1, Title = "Mideast Stocks", NewDateTime = new DateTime(2023, 07, 03), cat_id = 1, auth_id = 1 },
                    new News() { Id = 2, Title = "Liverpool News", NewDateTime = new DateTime(2024, 02, 01), cat_id = 2, auth_id = 2 },
                    new News() { Id = 3, Title = "Film23 Release", NewDateTime = new DateTime(2023,05,05), cat_id = 3, auth_id = 3 }
                );
        }
    }
}

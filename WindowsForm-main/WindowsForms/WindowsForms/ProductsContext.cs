using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Action" },
                new Category { CategoryId = 2, Name = "Adventure" },
                new Category { CategoryId = 3, Name = "RPG" },
                new Category { CategoryId = 4, Name = "Simulation" });

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Call of Duty" },
                new Product { ProductId = 2, CategoryId = 1, Name = "Battlefield" },
                new Product { ProductId = 3, CategoryId = 1, Name = "Doom" },
                new Product { ProductId = 4, CategoryId = 1, Name = "Overwatch" },
                new Product { ProductId = 5, CategoryId = 1, Name = "Counter-Strike" },
                new Product { ProductId = 6, CategoryId = 1, Name = "Halo" },
                new Product { ProductId = 7, CategoryId = 1, Name = "Gears of War" },
                new Product { ProductId = 8, CategoryId = 1, Name = "Fortnite" },
                new Product { ProductId = 9, CategoryId = 1, Name = "Apex Legends" },
                new Product { ProductId = 10, CategoryId = 2, Name = "The Legend of Zelda" },
                new Product { ProductId = 11, CategoryId = 2, Name = "Uncharted" },
                new Product { ProductId = 12, CategoryId = 2, Name = "Tomb Raider" },
                new Product { ProductId = 13, CategoryId = 2, Name = "Assassin's Creed" },
                new Product { ProductId = 14, CategoryId = 2, Name = "Red Dead Redemption" },
                new Product { ProductId = 15, CategoryId = 2, Name = "Minecraft" },
                new Product { ProductId = 16, CategoryId = 2, Name = "Journey" },
                new Product { ProductId = 17, CategoryId = 2, Name = "Dark Souls" },
                new Product { ProductId = 18, CategoryId = 3, Name = "The Witcher 3" },
                new Product { ProductId = 19, CategoryId = 3, Name = "Final Fantasy VII" },
                new Product { ProductId = 20, CategoryId = 3, Name = "Skyrim" },
                new Product { ProductId = 21, CategoryId = 3, Name = "Mass Effect" },
                new Product { ProductId = 22, CategoryId = 4, Name = "The Sims" },
                new Product { ProductId = 23, CategoryId = 4, Name = "SimCity" },
                new Product { ProductId = 24, CategoryId = 4, Name = "Animal Crossing" },
                new Product { ProductId = 25, CategoryId = 4, Name = "Stardew Valley" },
                new Product { ProductId = 26, CategoryId = 4, Name = "Cities: Skylines" },
                new Product { ProductId = 27, CategoryId = 4, Name = "Planet Zoo" },
                new Product { ProductId = 28, CategoryId = 4, Name = "RollerCoaster Tycoon" });
        }
    }
}

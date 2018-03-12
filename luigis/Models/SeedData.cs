using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace luigis.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Chicken Fettucini Alfredo",
                        Description = "Creamy alfredo sauce with chicken and broccoli",
                        Category = "Pasta",
                        Price = 14.95m
                    },
                    new Product
                    {
                        Name = "Three-Cheese Pesto Tortellini",
                        Description = "Creamy pesto sauce with soft cheesy tortellini",
                        Category = "Pasta",
                        Price = 10.95m
                    },
                    new Product
                    {
                        Name = "Spaghetti with Meat Sauce",
                        Description = "Meaty tomato sauce seasoned to perfection",
                        Category = "Pasta",
                        Price = 12.95m
                    },
                    new Product
                    {
                        Name = "Fried Mozzarela",
                        Description = "Creamy alfredo sauce with chicken and broccoli",
                        Category = "Appetizers",
                        Price = 7.50m
                    },
                    new Product
                    {
                        Name = "Fried Mushrooms",
                        Description = "The pride and pleasure of Mushroom Kingdom",
                        Category = "Appetizers",
                        Price = 8.95m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

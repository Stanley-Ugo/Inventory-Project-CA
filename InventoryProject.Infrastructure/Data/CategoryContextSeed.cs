using InventoryProject.Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryProject.Infrastructure.Data
{
    public class CategoryContextSeed
    {
        public static async Task SeedAsync(MainDBContext mainDBContext, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;
            try
            {
                await mainDBContext.Database.EnsureCreatedAsync();

                if (!mainDBContext.Categories.Any())
                {
                    mainDBContext.Categories.AddRange(GetCategories());
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 3)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<CategoryContextSeed>();
                    log.LogError($"Exception occured while connecting: {ex.Message}");
                    await SeedAsync(mainDBContext, loggerFactory, retryForAvailability);
                }
            }
        }

        private static IEnumerable<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Name = "Grocery", Description = "Consumer groceies section", CreatedBy = "Seed", DateCreated = DateTime.Now },
                new Category { Name = "Electronics", Description = "Household electronics section", CreatedBy = "Seed", DateCreated = DateTime.Now },
                new Category { Name = "Gadgets", Description = "Device and accessories section", CreatedBy = "Seed", DateCreated = DateTime.Now },
            };
        }
    }
}

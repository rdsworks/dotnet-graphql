using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRock.Api.Data.Entities;

namespace CarvedRock.Api.Data {
    public static class InitialData {
        public static void Seed(this CarvedRockDbContext dbContext) {
            if (!dbContext.Products.Any()) {
                dbContext.Products.Add(new Product{
                    Name = "Mountain Walkers",
                    Description = "Use these shoes to walk up mountains",
                    Price = 219.5m,
                    Rating = 4,
                    Type = ProductType.Boots,
                    Stock = 12,
                    PhotoFileName = "NotFound.jpg"
                });
                
            }
        }
    }
}
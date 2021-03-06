using System;
using System.Data.Entity.Migrations;
using AngularWebAPIPagination.Models;

namespace AngularWebAPIPagination.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            var random = new Random();
            for (var i = 0; i < 1000; i++)
            {
                context.Products.AddOrUpdate(p => p.Id, new Product
                {
                    Name = "Product " + i,
                    Price = 2*i,
                    Qty = 3*i,
                    Date = DateTime.Now.AddDays(random.Next(1, 100))
                });
            }
        }
    }
}
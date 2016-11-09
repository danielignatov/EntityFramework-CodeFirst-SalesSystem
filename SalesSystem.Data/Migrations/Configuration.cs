namespace SalesSystem.Data.Migrations
{
    using System;
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<SalesSystem.Data.SalesSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SalesSystem.Data.SalesSystemContext";
        }

        protected override void Seed(SalesSystem.Data.SalesSystemContext context)
        {
            Random rng = new Random();
            string[] customerNames = new string[] { "Han Solo", "Luke Skywalker", "Princess Leia", "Kylo Ren", "Rey" };
            string[] productNames = new string[] { "Toilet Paper", "Fire Extinguisher", "Gun", "Baseball Bat", "Chocolate" };
            string[] storeLocations = new string[] { "Las Vegas", "New York", "Milano", "Sofia", "Moscow" };

            int numberOfStores = rng.Next(1, storeLocations.Length);
            for (int i = 0; i < numberOfStores; i++)
            {
                int storeLocationIndex = rng.Next(0, storeLocations.Length);

                StoreLocation newStoreLocation = new StoreLocation()
                {
                    LocationName = storeLocations[storeLocationIndex]
                };

                context.StoreLocations.AddOrUpdate(newStoreLocation);
            }

            int numberOfProducts = rng.Next(1, productNames.Length);
            for (int i = 0; i < numberOfProducts; i++)
            {
                int productIndex = rng.Next(0, productNames.Length);

                Product newProduct = new Product()
                {
                    Name = productNames[productIndex],
                    Quantity = rng.Next(1, 10),
                    Price = (decimal)rng.Next(1, 20)
                };

                context.Products.AddOrUpdate(newProduct);
            }

            int numberOfCustomers = rng.Next(1, customerNames.Length);
            for (int i = 0; i < numberOfCustomers; i++)
            {
                int customerIndex = rng.Next(0, customerNames.Length);

                Customer newCustomer = new Customer()
                {
                    Name = customerNames[customerIndex]
                };

                context.Customers.AddOrUpdate(newCustomer);
            }

            context.SaveChanges();
        }
    }
}
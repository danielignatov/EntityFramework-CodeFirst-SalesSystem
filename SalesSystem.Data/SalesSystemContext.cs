namespace SalesSystem.Data
{
    using Models;
    using System.Data.Entity;

    public class SalesSystemContext : DbContext
    {
        // Your context has been configured to use a 'SalesSystemContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SalesSystem.Data.SalesSystemContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SalesSystemContext' 
        // connection string in the application configuration file.
        public SalesSystemContext()
            : base("name=SalesSystemContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SalesSystemContext>());
            this.Database.Initialize(true);
        }

        public virtual IDbSet<Customer> Customers { get; set; }

        public virtual IDbSet<Product> Products { get; set; }

        public IDbSet<StoreLocation> StoreLocations { get; set; }

        public IDbSet<Sale> Sales { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
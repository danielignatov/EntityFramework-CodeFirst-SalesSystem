namespace SalesSystem.ConsoleApplication
{
    using Data;
    using Data.Migrations;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var migration = new DropCreateDatabaseAlways<SalesSystemContext>();
            Database.SetInitializer(migration);
            SalesSystemContext context = new SalesSystemContext();
        }
    }
}
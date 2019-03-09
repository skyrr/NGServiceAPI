namespace NGService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using Context;

    internal sealed class Configuration : DbMigrationsConfiguration<NGService.Context.NGServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NGService.Context.NGServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.ServiceBranches.AddOrUpdate(
            //  p => p.BranchName,
            //  new ServiceBranch { BranchName = "First Branch"}
            //);
            //
            //context.Cities.AddOrUpdate(
            //  p => p.CityName,
            //  new City { CityName = "Ivano-Frankivsk" },
            //  new City { CityName = "Lviv" },
            //  new City { CityName = "Kyiv" },
            //  new City { CityName = "Kharkiv" },
            //  new City { CityName = "Dnipro" }
            //);
        }
    }
}

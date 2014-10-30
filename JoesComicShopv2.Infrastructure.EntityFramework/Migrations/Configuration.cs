namespace JoesComicShopv2.Migrations
{
    using JoesComicShopv2.People;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JoesComicShopv2.EntityFramework.JoesComicShopv2DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JoesComicShopv2.EntityFramework.JoesComicShopv2DbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.People.AddOrUpdate(
              p => p.Name,
              new Person { Name = "Andrew Peters" },
              new Person { Name = "Brice Lambson" },
              new Person { Name = "Rowan Miller" }
            );
            
        }
    }
}

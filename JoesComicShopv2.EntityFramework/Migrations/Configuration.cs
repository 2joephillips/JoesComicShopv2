namespace JoesComicShopv2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JoesComicShopv2.EntityFramework.JoesComicShopv2DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "JoesComicShopv2";
        }

        protected override void Seed(JoesComicShopv2.EntityFramework.JoesComicShopv2DbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}

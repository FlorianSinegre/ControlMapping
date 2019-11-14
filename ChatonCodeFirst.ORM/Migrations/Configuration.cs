namespace ChatonCodeFirst.ORM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChatonCodeFirst.ORM.ContexteBDD>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ChatonCodeFirst.ORM.ContexteBDD context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Categories.AddOrUpdate(new Categorie()
            {
                Id = 1,
                Nom = "Mignons",
                Description = "Les chatons les plus mignons"
            });
        }
    }
}

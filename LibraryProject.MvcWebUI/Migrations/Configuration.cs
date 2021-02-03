namespace LibraryProject.MvcWebUI.Migrations
{
    using LibraryProject.MvcWebUI.Models.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryProject.MvcWebUI.Models.Context.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LibraryProject.MvcWebUI.Models.Context.LibraryContext context)
        {
            if (!context.Categories.Any())
            {
                List<Category> categories = new List<Category>()
                {
                    new Category{ CategoryName="Roman"},
                    new Category{ CategoryName="Şiir"},
                    new Category{ CategoryName="Tarih"},
                    new Category{ CategoryName="Sosyoloji"},
                    new Category{ CategoryName="Biyografi"}
                };

                context.Categories.AddRange(categories);

                context.SaveChanges();
            }
        }
    }
}

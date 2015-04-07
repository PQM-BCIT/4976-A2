namespace GoodSamaritan.Migrations.IdentityMigrations
{
    using GoodSamaritan.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
        }

        protected override void Seed(GoodSamaritan.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // Create the roles if they do not already exist
            if (!RoleManager.RoleExists("Administrator"))
                RoleManager.Create(new IdentityRole("Administrator"));

            if (!RoleManager.RoleExists("Worker"))
                RoleManager.Create(new IdentityRole("Worker"));

            if (!RoleManager.RoleExists("Reporter"))
                RoleManager.Create(new IdentityRole("Reporter"));

            // Generate the users
            var Adam = new ApplicationUser() { UserName = "adam@gs.ca", Email = "adam@gs.ca" };
            var User = UserManager.Create(Adam, "P@$$w0rd");
            UserManager.AddToRole(Adam.Id, "Administrator");

            var Wendy = new ApplicationUser() { UserName = "wendy@gs.ca", Email = "wendy@gs.ca" };
            var User2 = UserManager.Create(Wendy, "P@$$w0rd");
            UserManager.AddToRole(Wendy.Id, "Worker");

            var Rob = new ApplicationUser() { UserName = "rob@gs.ca", Email = "rob@gs.ca" };
            var User3 = UserManager.Create(Rob, "P@$$w0rd");
            UserManager.AddToRole(Rob.Id, "Reporter");
        }
    }
}

namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PassengerStation.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PassengerStation.Data.ApplicationContext context)
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

            context.Users.AddOrUpdate(q => q.UserName,
                new PassengerStation.Data.User
                {
                    Name = "Aykut",
                    Surname = "Ateş",
                    UserRole = PassengerStation.Data.UserRole.SystemAdmin,
                    Routes = null,
                    UserName = "alpgiray",
                    DateCreated = DateTime.Now
                },
                new PassengerStation.Data.User
                {
                    Name = "Simge",
                    Surname = "Ateş",
                    UserRole = PassengerStation.Data.UserRole.SystemAdmin,
                    Routes = null,
                    UserName = "simmy",
                    DateCreated = DateTime.Now
                }
                );
        }
    }
}

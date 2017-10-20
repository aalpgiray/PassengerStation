using System.Data.Entity;

namespace PassengerStation.Data
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext() :base(@"Server = (localdb)\mssqllocaldb; Database=SecretDatabase;Trusted_Connection=True;")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add<User>(new UserConfig());
            modelBuilder.Configurations.Add<Stop>(new StopConfig());
            modelBuilder.Configurations.Add<Route>(new RouteConfig());
        }
    }
}
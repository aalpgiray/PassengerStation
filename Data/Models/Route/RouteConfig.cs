namespace PassengerStation.Data
{
    public class RouteConfig : BaseConfiguration<Route>
    {
        public RouteConfig() : base()
        {
            HasRequired(q => q.Requester).WithMany(q => q.Routes).WillCascadeOnDelete();
        }
    }
}

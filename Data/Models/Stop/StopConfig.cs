namespace PassengerStation.Data
{
    public class StopConfig : BaseConfiguration<Stop>
    {
        public StopConfig() : base()
        {
            HasRequired(q => q.Route).WithMany(q => q.Stops).WillCascadeOnDelete();
        }
    }
}

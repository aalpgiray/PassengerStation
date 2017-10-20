namespace PassengerStation.Data
{
    public class UserConfig : BaseConfiguration<User>
    {
        public UserConfig() : base()
        {
            Property(q => q.Name).IsRequired();
            Property(q => q.Surname).IsRequired();
            Property(q => q.UserName).IsRequired();
        }
    }
}

using PassengerStation.Data;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PassengerStation.Service
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

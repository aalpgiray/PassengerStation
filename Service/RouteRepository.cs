using PassengerStation.Data;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PassengerStation.Service
{
    public class RouteRepository : GenericRepository<Route>, IRouteRepository
    {
        public RouteRepository(ApplicationContext context) : base(context)
        {
        }
    }
}

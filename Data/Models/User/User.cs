using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassengerStation.Data
{
    public class User : Base
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }
        public List<Route> Routes { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace PassengerStation.Data
{
    public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : Base
    {
        public BaseConfiguration()
        {
            HasKey(q => q.Id);
        }  
    }

}

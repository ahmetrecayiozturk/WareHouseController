using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    //We create a context class that inherits from DbContext class, this is use for entity
    public class WareHouseControlContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}

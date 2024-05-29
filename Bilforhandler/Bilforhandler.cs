using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public class Bilforhandler
    {
        public List<Car> CarsForPurchase { get; private set; } = new List<Car>();

        public Bilforhandler()
        {
            CarsForPurchase.Add(new NissanRx7("Nissan", 2003, "123", 190.82, 200));
            CarsForPurchase.Add(new HondaCivic("honda", 1995, "321", 10000.87, "Brad pitt"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    public class HondaCivic : Car
    {
        public string PreviousOwner { get; private set; }
        public HondaCivic(string brand, int vintage, string reg, double distance, string previousOwner) : base(brand, vintage, reg, distance)
        {
            PreviousOwner = previousOwner;
        }

        public override void StopCar()
        {
            Console.WriteLine("it rolls to a stop");
        }
    }
}

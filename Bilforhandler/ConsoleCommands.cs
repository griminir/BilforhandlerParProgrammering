using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bilforhandler
{
    public static class ConsoleCommands
    {
        public static string AskForUserData(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        }

        public static void ChoiceMenu(Bilforhandler seller)
        {
            var count = 1;

            foreach (var car in seller.CarsForPurchase)
            {
                Console.WriteLine($"{count}. {car.Brand}");
                count++;
            }
        }
    }
}

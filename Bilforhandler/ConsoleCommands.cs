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

        public static void LookCar(string choice, Bilforhandler seller)
        {
            int choiceInt = Convert.ToInt32(choice);
            var car = seller.CarsForPurchase[choiceInt - 1];
            Console.WriteLine($"Dette er en {car.Brand} fra {car.Vintage} med registreringsnummer {car.RegNum} som har kjørt {car.DistanceTraveled}km");
            var output = AskForUserData("Would you like to purchase this car Y/N: ");
            switch (output.ToUpper())
            {
                case "Y":
                    seller.Kunde.PurchaseCar(car);
                    seller.CarsForPurchase.Remove(car);
                    break; 
                case "N":
                    ChoiceMenu(seller);
                break;
                default:
                    LookCar(choice, seller);
                    break;


            }

        }

       
    }
}

using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Bilforhandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stillShopping = true;
            Kunde Tommy = new Kunde();
            var KjellBilforhandler = new Bilforhandler(Tommy);
            while(stillShopping)
            ConsoleCommands.ChoiceMenu(KjellBilforhandler);
            string userChoice = ConsoleCommands.AskForUserData("What car would you like to look at: ");
            ConsoleCommands.LookCar(userChoice, KjellBilforhandler);
            

            Console.ReadLine();
        }
    }
}

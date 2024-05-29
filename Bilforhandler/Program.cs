using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Bilforhandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var KjellBilforhandler = new Bilforhandler();
            ConsoleCommands.ChoiceMenu(KjellBilforhandler);
            ConsoleCommands.AskForUserData("What car would you like to purchase: ");

            Console.ReadLine();
        }
    }
}

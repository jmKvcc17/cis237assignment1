// Jesse Meachum
// Date: 1/19/17
// CIS 237


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;

            UserInterface ui = new UserInterface();

            ui.DisplayMenu();
            userChoice = ui.getUserInput();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Choice 1");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
                
            }

            Console.ReadLine();
        }
    }
}

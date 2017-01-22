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
    // Class to hold global constants
    static class Constants
    {
        public const int WINE_ITEM_ARRAY = 5000;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;

            UserInterface ui = new UserInterface();
            //CVSProcessor dataProcess = new CVSProcessor();
            WineItemCollection wineItemCollection = new WineItemCollection();



            ui.DisplayMenu();
            userChoice = ui.getUserInput();

            while (userChoice != "6")
            { 
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Choice 1");
                        wineItemCollection.LoadItems();
                        break;
                    case "2":
                        wineItemCollection.GetPrintString();
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }

                ui.DisplayMenu();
                userChoice = ui.getUserInput();
            }
            Console.ReadLine();
        }
    }
}

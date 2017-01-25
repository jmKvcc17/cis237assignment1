// Jesse Meachum
// Date: 1/19/17
// CIS 237
// Other sources used: Visual C# 2012 Third Edition by Tony Gradis


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
        public const int WINE_ITEM_ARRAY = 5000; // max size of the wineItemArray
    }

    class Program
    {
        static void Main(string[] args)
        {
            string userChoice; // variable that stores the user's menu choice
            bool choice1Bool = false; // bool flag that is used to store if 
            // menu choice 1 has been used
            string userId; // stores the userID

            UserInterface ui = new UserInterface(); // create new ui object
            WineItemCollection wineItemCollection = new WineItemCollection(); // create new wineItemCollection object


            // Display the menu and get the user input
            ui.DisplayMenu();
            userChoice = ui.getUserInput();

            while (userChoice != "5")
            { 
                switch (userChoice)
                {
                    case "1":
                        // Check if choice 1 has not been used, will execute load once
                        if (choice1Bool == false)
                        {
                            wineItemCollection.LoadItems();
                            choice1Bool = true;
                        }                
                        else
                            ui.ErrorMessage();
                        break;
                    case "2":
                        wineItemCollection.GetPrintString();
                        break;
                    case "3":
                        userId = ui.GetSearchId();
                        wineItemCollection.Search(userId);
                        break;
                    case "4":
                        if (choice1Bool == false)
                            ui.AddError();
                        else
                            wineItemCollection.AddItem();
                        break;
                    case "5":
                        break;
                    case "6":
                        ui.ClearConsole();
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

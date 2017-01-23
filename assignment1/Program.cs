﻿// Jesse Meachum
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
            bool choice1Bool = false;

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
                        // Check if choice 1 has not been used, will execute load once
                        if (choice1Bool == false)
                        {
                            Console.WriteLine("Choice 1"); // *********************
                            wineItemCollection.LoadItems();
                            choice1Bool = true;
                        }
                        else
                            Console.WriteLine("You cannot load twice"); //**********************
                        
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

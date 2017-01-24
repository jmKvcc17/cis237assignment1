using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    // Gets the input from the user, outputs 
    // data to the console
    class UserInterface
    {

        public UserInterface()
        {

        }
        
        // Displays the menu items
        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu List: ");
            Console.WriteLine("1: Load CSV File (Can only be done once)");
            Console.WriteLine("2: Print entire list of wine items");
            Console.WriteLine("3: Search for item by id");
            Console.WriteLine("4: Add new item to list");
            Console.WriteLine("5: Exit");
            Console.WriteLine("6: Clear the console");
            Console.WriteLine();
        }

        // Gets the users input for the menu in Program.cs
        // Returns the userInputString
        public string getUserInput()
        {
            string userInputString;

            Console.WriteLine("Enter in menu choice: ");
            userInputString = Console.ReadLine();

            while (userInputString != "1" && userInputString != "2" && userInputString != "3" && 
                userInputString != "4" && userInputString != "5" && userInputString != "6")
            {
                Console.WriteLine();
                Console.WriteLine("Improper Menu choice.");

                DisplayMenu();

                Console.WriteLine();
                Console.WriteLine("Enter in menu choice: ");
                userInputString = Console.ReadLine();
                Console.WriteLine();
       
            }

            return userInputString;
        }

        // Ouputs the wineItemArray from the GetPrintString function
        public void OutputString(string WineItemString)
        {
            Console.WriteLine(WineItemString);
        }

        // Prints error when trying to load the file twice
        public void ErrorMessage()
        {
            Console.WriteLine("You cannot load the file twice");
            Console.WriteLine();
        }

        // Gets the id to search for, returns it to userID in Program.cs
        public string GetSearchId()
        {
            string userSeachId = "";

            Console.WriteLine("Enter in the 5-digit code to search for: ");
            userSeachId = Console.ReadLine();

            while (userSeachId.Length != 5)
            {
                Console.WriteLine("Error. Input must be 5 digits and a number.");
                Console.WriteLine();

                Console.WriteLine("Enter in the 5-digit code to search for: ");
                userSeachId = Console.ReadLine();
            }

            return userSeachId;
        }

        // Accepts the wineItemArray and searchIndex, displays the searched for
        // wineItem, displays if it was not found
        public void ShowSearchResult(WineItem[] wineItemArray, int searchIndex)
        {
            if (searchIndex == -1)
                Console.WriteLine("Item was not found.");
            else
                Console.WriteLine("ID match, Product description: {0}\n\t  Pack: {1}", 
                    wineItemArray[searchIndex].Description, wineItemArray[searchIndex].Pack);
        }

        // Gets the Id, Description, and Pack from the user in order to add it to the
        // array and file
        public void GetAddInfo(ref string Id, ref string Description, ref string Pack)
        {

            Console.WriteLine("Enter in product ID: ");
            Id = Console.ReadLine();


            while (Id.Length != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Enter in product ID: ");
                Id = Console.ReadLine();
            }

            Console.WriteLine("Enter in the description: ");
            Description = Console.ReadLine();

            Console.WriteLine("Enter in the pack: ");
            Pack = Console.ReadLine();
        }

        // Used to get the ID again if the user entered an ID
        // that already exists
        public void getID(ref string Id)
        {
            Console.WriteLine();
            Console.WriteLine("ID entered matches another ID.");
            Console.WriteLine("Enter in new ID:");
            Id = Console.ReadLine();

            while (Id.Length != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Enter in product ID: ");
                Id = Console.ReadLine();
                Console.WriteLine();
            }
        }

        // Clears the console if the user chooses
        // menu option 6
        public void ClearConsole()
        {
            Console.WriteLine("Clearing Console...");
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }

        // Diplays error message if trying to add to the array
        // before loading it
        public void AddError()
        {
            Console.WriteLine("You cannot add to the database before loading it.");
        }
    }
}

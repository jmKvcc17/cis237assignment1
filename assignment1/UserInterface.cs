using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        // Backing fields

        public UserInterface()
        {

        }

        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu List: ");
            Console.WriteLine("1: Load CSV File (Can only be done once)");
            Console.WriteLine("2: Print entire list of wine items");
            Console.WriteLine("3: Search for item by id");
            Console.WriteLine("4: Add new item to list");
            Console.WriteLine("5: Exit");
            Console.WriteLine();
        }

        public string getUserInput() // MAKE MORE EFFICIENT************************
        {
            string userInputString;

            Console.WriteLine("Enter in menu choice: ");
            userInputString = Console.ReadLine();

            while (userInputString != "1" && userInputString != "2" && userInputString != "3" && 
                userInputString != "4" && userInputString != "5")
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

        public void OutputString(string WineItemString)
        {
            Console.WriteLine(WineItemString);
        }

        public void ErrorMessage()
        {
            Console.WriteLine("You cannot load the file twice");
            Console.WriteLine();
        }

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

        public void ShowSearchResult(WineItem[] wineItemArray, int searchIndex)
        {
            if (searchIndex == -1)
                Console.WriteLine("Item was not found.");
            else
                Console.WriteLine("ID match, Product description: {0}\n\t  Pack: {1}", 
                    wineItemArray[searchIndex].Description, wineItemArray[searchIndex].Pack);
        }

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
    }
}

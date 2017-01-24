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
            Console.WriteLine("Menu List: ");
            Console.WriteLine("1: Load CSV File (Can only be done once)");
            Console.WriteLine("2: Print entire list of wine items");
            Console.WriteLine("3: Search for item by id");
            Console.WriteLine("4: Add new item to list");
            Console.WriteLine("5: Exit");
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

                Console.WriteLine("Enter in menu choice: ");
                userInputString = Console.ReadLine();
       
            }

            return userInputString;
        }

        public void OutputString(string WineItemString)
        {
            Console.WriteLine(WineItemString);
        }
    }
}

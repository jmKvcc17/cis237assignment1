using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private  WineItem[] _wineItemsArray = new WineItem[Constants.WINE_ITEM_ARRAY]; // WineItem class object, holds up to 5000 wineItem entries
        private CVSProcessor process = new CVSProcessor(); // CVSProcessor object to handle getting data from the file into the wineItemArray
        private UserInterface ui = new UserInterface(); // ui to handle data input and errors

        // Default constructor
        public WineItemCollection()
        {

        }

        // Public Methods
        // Adds user entered item into array
        public void AddItem() //*************************
        {
            string id = "", description = "", pack = "";
            int newIndex;
            bool isEqual = false;

            newIndex = (FindLastIndex() + 1); // returns index of non-null entries plus 1 for new entry

            ui.GetAddInfo(ref id, ref description, ref pack); // uses ref to id, description, and pack to get input from user

            isEqual = CompareID(id); // checks to see if user's id already exists

            while(isEqual) // if it does, keep having the user enter in new ids 
            {
                ui.getID(ref id);
                isEqual = CompareID(id);
            }


            _wineItemsArray[newIndex] = new WineItem(id, description, pack); // adds new entry into the wine item array

            process.WriteToCVS(_wineItemsArray, newIndex); // writes the entry to the file
        }

        // Loads the entries from the file to the wineItemArray
        public void LoadItems()
        {
            process.ReadFromCSV(_wineItemsArray);
        }

        // Searches the array for the id, if found returns its index
        public void Search(string uSearchString) // ************************Array not storing new items?
        {
            int position = -1;
            int lastIndex = FindLastIndex();

                for (int i = 0; i < lastIndex; i++)
                {
                    if (String.Compare(_wineItemsArray[i].ID, uSearchString) == 0)
                    {
                        position = i;
                    }  
                }

            ui.ShowSearchResult(_wineItemsArray, position); // displays the search results, using the found
            // index and wineItemsArray as parameters 
        }

        // Counts all the items in the WineItemArray array and returns it
        private int FindLastIndex()
        {
            int index = 0;

            foreach(WineItem item in _wineItemsArray)
            {
                if (item != null)
                    index++;
            }

            return index;
        }

        // Uses the output string to put each wine item on a separate line
        public void GetPrintString() 
        {
            string outputString = "";

            foreach (WineItem wineItem in _wineItemsArray)
            {
                if (wineItem != null)
                {
                    outputString += wineItem.ToString() +
                        Environment.NewLine;
                }
            }
            ui.OutputString(outputString);
        }

        // Accepts the ID as a parameter, and compares it to every 
        // Id in the wineItemsArray, returns true if match
        private bool CompareID(string userID)
        {
            bool isEqual = false;

            for (int index = 0; index < FindLastIndex(); index++)
            {
                if (string.Compare(_wineItemsArray[index].ID, userID) == 0)
                    isEqual = true;
            }

            return isEqual;
        }
    }
}

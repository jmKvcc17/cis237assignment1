using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private  WineItem[] _wineItemsArray = new WineItem[Constants.WINE_ITEM_ARRAY]; //*********************
        private CVSProcessor process = new CVSProcessor();
        private UserInterface ui = new UserInterface();


        public WineItemCollection()
        {

        }

        // Public Methods
        public void AddItem(string Id, string Description, string Pack)
        {

        }

        public void LoadItems()
        {
            process.ReadFromCSV(_wineItemsArray);
        }

        public int Search(string Id, string Description, string Pack)
        {
            int foundItem;

            return 1;
        }

        public void GetPrintString() 
        {
            string outputString = "";

            

            foreach (WineItem wineItem in _wineItemsArray)
            {
                if (wineItem != null)
                {
                    //Console.WriteLine("Hello");
                    outputString += wineItem.ToString() +
                        Environment.NewLine;

                }
                
            }

            ui.OutputString(outputString);
        }

    }
}

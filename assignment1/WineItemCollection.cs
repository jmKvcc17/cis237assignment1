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

        public void Search(string uSearchString)
        {
            int position = -1;

                for (int i = 0; i < FindLastIndex(); i++)
                {
                    if (String.Compare(_wineItemsArray[i].ID, uSearchString) == 0)
                    {
                        position = i;
                    }  
                }

            ui.ShowSearchResult(_wineItemsArray, position);
        }

        private int FindLastIndex()
        {
            int index = 0;

            foreach(WineItem item in _wineItemsArray)
            {
                if (item != null)
                    index++;
            }

            return (index - 1);
        }

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

    }
}

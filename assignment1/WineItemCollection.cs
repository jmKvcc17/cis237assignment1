using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private WineItem[] winItemsArray = new WineItem[Constants.WINE_ITEM_ARRAY];

        public WineItemCollection()
        {

        }

        // Public Methods
        public void AddItem(string Id, string Description, string Pack)
        {

        }

        public int Search(string Id, string Description, string Pack)
        {
            int foundItem;

            return 1;
        }

        public void GetPrintString() 
        {
            string outputString = "";

            foreach(WineItem wineItem in winItemsArray)
            {
                if (wineItem != null)
                {
                    outputString += wineItem.ToString() +
                        Environment.NewLine;
                }
            }
        }

    }
}

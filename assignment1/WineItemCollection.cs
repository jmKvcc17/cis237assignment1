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
        public void AddItem() //*************************
        {
            string id = "", description = "", pack = "";
            int newIndex;
            bool isEqual = false;

            newIndex = (FindLastIndex() + 1);

            ui.GetAddInfo(ref id, ref description, ref pack);

            isEqual = CompareID(id);

            while(isEqual)
            {
                ui.getID(ref id);
                isEqual = CompareID(id);
            }


            _wineItemsArray[newIndex] = new WineItem(id, description, pack);

            process.WriteToCVS(_wineItemsArray, newIndex);
        }

        public void LoadItems()
        {
            process.ReadFromCSV(_wineItemsArray);
        }

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

            return index;
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

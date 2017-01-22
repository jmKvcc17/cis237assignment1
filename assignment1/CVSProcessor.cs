using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CVSProcessor
    {
        private StreamReader inputFile;
        //private WineItemCollection[] wineItemsArray = new WineItemCollection[Constants.WINE_ITEM_ARRAY];
        
        public CVSProcessor()
        {
            
        }

        public void ReadFromCSV(WineItemCollection[] wineItemCollectionArray)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\WineList.csv"); // Finds the wine list file and stores it in path
            inputFile = File.OpenText(path);

            string HoldString = "";
            string id = "";
            string description = "";
            string pack = "";

            for (int index = 0; index <= Constants.WINE_ITEM_ARRAY; index++)
            {
                if (!inputFile.EndOfStream)
                {
                    HoldString = inputFile.ReadLine();
                    Split(ref HoldString, ref id, ref description, ref pack);
                    
                }
            }

            inputFile.Close();
        }

        // Takes each line from CSV and splits them into individual variables from delimiter
        private void Split(ref string Hold, ref string ID, ref string Description, ref string Pack)
        {
            string[] splitString = new string[3];
            splitString = Hold.Split(',');
            ID = splitString[0];
            Description = splitString[1];
            Pack = splitString[2];
        }
    }
}

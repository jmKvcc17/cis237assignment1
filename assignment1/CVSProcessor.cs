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
        
        public CVSProcessor()
        {
            
        }

        public void ReadFromCSV()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\WineList.csv"); // Finds the wine list file and stores it in path
            inputFile = File.OpenText(path);
        }
    }
}

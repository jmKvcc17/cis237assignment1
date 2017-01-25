using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    // WineItem holds the id, description, and pack from each entry in the
    // CSV file
    class WineItem
    {
        // Backing fields
        private string _id;
        private string _description;
        private string _pack;

        // Default constructor
        public WineItem()
        {

        }

        // Overloaded constructor that accepts ID, Description, and Pack
        public WineItem(string ID, string Description, string Pack)
        {
            _id = ID;
            _description = Description;
            _pack = Pack;
        }

        // ID property
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        // Description property
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        // Pack property
        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        // Public Methods
        // Overrides ToString to return wine entry
        public override string ToString()
        {
            return "ID: " + _id + Environment.NewLine + "  -Description: " + _description + Environment.NewLine + "  -Pack: " + _pack;
        }

    }
}

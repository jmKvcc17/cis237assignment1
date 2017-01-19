using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
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

        public WineItem(string ID, string Description, string Pack)
        {
            _id = ID;
            _description = Description;
            _pack = Pack;
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        // Public Methods
        public override string ToString()
        {
            return _id + " " + _description + " " + _pack;
        }

    }
}

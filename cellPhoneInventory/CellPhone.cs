using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cellPhoneInventory
{
    class CellPhone
    {
        public string _brand;
        public string _model;
        public decimal _price;

        //Create the constructor
        public CellPhone() {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        //create the properties
        public string Brand {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model {
            get { return _model; }
            set { _model = value; }
        }

        public decimal Price {
            get { return _price; }
            set { _price = value; }
        }
    }
}

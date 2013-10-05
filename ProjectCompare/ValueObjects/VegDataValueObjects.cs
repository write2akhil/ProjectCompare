using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCompare
{
    public class VegDataValueObjects
    {
        private string _vegetableEName = string.Empty;
        private string _vegetableHName = string.Empty;

        private string _storeName = string.Empty;
        private string _price= string.Empty;

        public string VegeTableEName
        {
            get { return _vegetableEName; }
            set { _vegetableEName = value; }
        }

        public string VegeTableHName
        {
            get { return _vegetableHName; }
            set { _vegetableHName = value; }
        }

        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}


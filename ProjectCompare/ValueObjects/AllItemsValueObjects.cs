using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCompare
{
    public class AllItemsValueObjects
    {
        private string _vegetableEName = string.Empty;
        private string _vegetableHName = string.Empty;
        private string _vegetableId = string.Empty;

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

        public string VegetableId
        {
            get { return _vegetableId; }
            set { _vegetableId = value; }
        }




    }
}
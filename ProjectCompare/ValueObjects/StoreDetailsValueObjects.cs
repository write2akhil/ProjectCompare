using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCompare
{
    public class StoreDetailsValueObjects
    {
        private string _storeID = string.Empty;
        private string _storeName = string.Empty;
        private string _city = string.Empty;
        private string _state = string.Empty;
        private string _address = string.Empty;

        private string _country = string.Empty;
        private string _pincode = string.Empty;
        private string _phoneNumber = string.Empty;

        public string StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }

        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string PinCode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }
        public string Phone
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

    }
}
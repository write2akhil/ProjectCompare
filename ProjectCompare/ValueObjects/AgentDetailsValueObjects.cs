using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCompare
{
    public class AgentDetailsValueObjects
    {
        private string _storeID = string.Empty;
        private string _agentId = string.Empty;
        private string _agentName = string.Empty;
        private string _agentMobileNumber = string.Empty;

        public string StoreID
        {
            get { return _storeID; }
            set { _storeID = value; }
        }
        public string AgentId
        {
            get { return _agentId; }
            set { _agentId = value; }
        }
        public string AgentName
        {
            get { return _agentName; }
            set { _agentName = value; }
        }

        public string AgentMobileNumber
        {
            get { return _agentMobileNumber; }
            set { _agentMobileNumber = value; }
        }




    }
}
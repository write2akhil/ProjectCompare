using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjectCompare
{
    public class VegDataAccessManager
    {

        public List<VegDataValueObjects> GetDataforAllstores()
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            List<VegDataValueObjects> vegCollection = new List<VegDataValueObjects>();
           vegCollection= dbprovider.GetDataforAllStores();
           return vegCollection;
        }

        public List<VegDataValueObjects> GetDataforStore(string storeName)
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            List<VegDataValueObjects> vegCollection = new List<VegDataValueObjects>();
            vegCollection = dbprovider.GetDataforStore(storeName);
           return vegCollection;
        }
        
        public bool AddItems(string itemEName, string itemHName)
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            return dbprovider.AddItems(itemEName,itemHName);
        }

        public bool AddAgents(string AgentName, string StoreID, string AgentMobileNumber)
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            return dbprovider.AddAgents(AgentName, StoreID, AgentMobileNumber);
        }

        public bool AddStores(string storeName, string stateList, string cityList, string storeAddress, string storePincode, string storeContact)
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            return dbprovider.AddStores(storeName, stateList, cityList, storeAddress, storePincode, storeContact);
        }

        public List<StoreDetailsValueObjects> GetAllStores()
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            List<StoreDetailsValueObjects> storeCollection = new List<StoreDetailsValueObjects>();
            storeCollection = dbprovider.GetAllStores();
            return storeCollection;
        }

        public List<AllItemsValueObjects> GetDataAllItems()
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            List<AllItemsValueObjects> vegCollection = new List<AllItemsValueObjects>();
            vegCollection = dbprovider.GetDataAllItems();
            return vegCollection;
        }

        public List<AgentDetailsValueObjects> GetDataAllAgents()
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            List<AgentDetailsValueObjects> vegCollection = new List<AgentDetailsValueObjects>();
            vegCollection = dbprovider.GetDataAllAgents();
            return vegCollection;
        }

        public List<StoreDetailsValueObjects> GetAllStoreList()
        {
            VegDataAccessProvider dbprovider = new VegDataAccessProvider();
            List<StoreDetailsValueObjects> vegCollection = new List<StoreDetailsValueObjects>();
            vegCollection = dbprovider.GetAllStoreList();
            return vegCollection;
        }
        

    }

    public class StoreDetailsAccessManager
    {

        public int SaveStoreDetails(StoreDetailsValueObjects storeDetails)
        {
            StoreDetailAccessProvider sprovider = new StoreDetailAccessProvider();

            return sprovider.SaveStoreDetails(storeDetails);

        }

    }
}


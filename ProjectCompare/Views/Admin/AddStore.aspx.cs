using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCompare.Views.Admin
{
    public partial class AddStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<StoreDetailsValueObjects> vegDataValueObjects = new List<StoreDetailsValueObjects>();
            VegDataAccessManager dataManager = new VegDataAccessManager();
            List<StoreDetailsValueObjects> xValueObjects = new List<StoreDetailsValueObjects>();
            xValueObjects = dataManager.GetAllStoreList();
            storeListRepeater.DataSource = xValueObjects;
            storeListRepeater.DataBind();
        }

        protected void AddStores_Click(object sender, EventArgs e)
        {
            string storeName = Convert.ToString(storeNameTextBox.Value);
            string storeAddress = Convert.ToString(storeAddressTextBox.Value);
            string storePincode = Convert.ToString(storePincodeTextBox.Value);
            string storeContact = Convert.ToString(storeContactTextBox.Value);

            string stateList = Convert.ToString(stateListDropdownlist.SelectedValue);
            string cityList = Convert.ToString(cityListDropdownlist.SelectedValue);
            bool returnStatus = true;

            VegDataAccessManager dataManager = new VegDataAccessManager();

            if (!string.IsNullOrEmpty(storeName) && !string.IsNullOrEmpty(storeAddress) &&
                !string.IsNullOrEmpty(storePincode) && !string.IsNullOrEmpty(storeContact) &&
                !string.IsNullOrEmpty(stateList) && !string.IsNullOrEmpty(cityList))
            {
                returnStatus = dataManager.AddStores(storeName, stateList, cityList, storeAddress, storePincode, storeContact);
                if (!returnStatus)
                {
                    messageStatusLabel.Visible = true;
                    messageStatusLabel.InnerText = "";
                    messageStatusLabel.InnerText = "Error Occured while adding!";
                }
                else
                {
                    messageStatusLabel.Visible = true;
                    messageStatusLabel.InnerText = "";
                    messageStatusLabel.InnerText = "Item added Successfully!";
                    List<StoreDetailsValueObjects> xValueObjects = new List<StoreDetailsValueObjects>();
                    xValueObjects = dataManager.GetAllStoreList();
                    storeListRepeater.DataSource = xValueObjects;
                    storeListRepeater.DataBind();
                }
            }
            else
            {
                returnStatus = false;
                messageStatusLabel.Visible = true;
                messageStatusLabel.InnerText = "";
                messageStatusLabel.InnerText = "Please fill All Values!";
            }
        }
    }
}
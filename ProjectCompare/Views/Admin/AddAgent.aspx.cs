using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCompare.Views.Admin
{
    public partial class AddAgent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<StoreDetailsValueObjects> vegDataValueObjects = new List<StoreDetailsValueObjects>();
            VegDataAccessManager dataManager = new VegDataAccessManager();
            vegDataValueObjects = dataManager.GetAllStores();
            storeListDropdownlist.DataTextField = "StoreName";
            storeListDropdownlist.DataValueField = "StoreID";
            storeListDropdownlist.DataSource = vegDataValueObjects;
            storeListDropdownlist.DataBind();

            List<AgentDetailsValueObjects> xValueObjects = new List<AgentDetailsValueObjects>();
            xValueObjects = dataManager.GetDataAllAgents();
            agentListRepeater.DataSource = xValueObjects;
            agentListRepeater.DataBind();
        }

        protected void AddItems_Click(object sender, EventArgs e)
        {
            string agentName = Convert.ToString(agentNameTextBox.Value);
            string agentMobile = Convert.ToString(agentMobileTextBox.Value);
            string storeId = Convert.ToString(storeListDropdownlist.SelectedValue);
            bool returnStatus = true;

            VegDataAccessManager dataManager = new VegDataAccessManager();
            if (!string.IsNullOrEmpty(agentName) && !string.IsNullOrEmpty(agentMobile) && !string.IsNullOrEmpty(storeId))
            {
                returnStatus = dataManager.AddAgents(agentName, storeId, agentMobile);
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
                    List<AgentDetailsValueObjects> xValueObjects = new List<AgentDetailsValueObjects>();
                    xValueObjects = dataManager.GetDataAllAgents();
                    agentListRepeater.DataSource = xValueObjects;
                    agentListRepeater.DataBind();
                }
            }
            else
            {
                returnStatus = false;
                messageStatusLabel.Visible = true;
                messageStatusLabel.InnerText = "";
                messageStatusLabel.InnerText = "Please fill both Values!";
            }
        }
    }
}
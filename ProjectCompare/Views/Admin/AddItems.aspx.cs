using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCompare.Views.Admin
{
    public partial class AddItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                messageStatusLabel.Visible = false;
            }
            List<AllItemsValueObjects> vegDataValueObjects = new List<AllItemsValueObjects>();
            VegDataAccessManager dataManager = new VegDataAccessManager();
            vegDataValueObjects = dataManager.GetDataAllItems();
            itemListRepeater.DataSource = vegDataValueObjects;
            itemListRepeater.DataBind();
            
        }

        protected void AddItems_Click(object sender, EventArgs e)
        {
            string itemEName = Convert.ToString(itemENameTextBox.Value);
            string itemHName = Convert.ToString(itemHNameTextBox.Value);
            bool returnStatus = true;
            VegDataAccessManager dataManager = new VegDataAccessManager();
            List<AllItemsValueObjects> vegDataValueObjects = new List<AllItemsValueObjects>();
            
            if (!string.IsNullOrEmpty(itemEName) && !string.IsNullOrEmpty(itemHName))
            {
                returnStatus = dataManager.AddItems(itemEName, itemHName);
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
                    
                    vegDataValueObjects = dataManager.GetDataAllItems();
                    itemListRepeater.DataSource = vegDataValueObjects;
                    itemListRepeater.DataBind();
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
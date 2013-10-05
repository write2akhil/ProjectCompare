using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCompare.Views
{
    public partial class Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<VegDataValueObjects> vegDataValueObjects = new List<VegDataValueObjects>();
            VegDataAccessManager dataManager = new VegDataAccessManager();
            vegDataValueObjects = dataManager.GetDataforStore("Reliance Mart");

            Repeater1.DataSource = vegDataValueObjects;
            Repeater1.DataBind();
        }

        protected void onItem_dataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }
    }
}
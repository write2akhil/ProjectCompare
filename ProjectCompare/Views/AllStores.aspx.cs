using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectCompare.Views
{
    public partial class AllStores : System.Web.UI.Page
    {

        List<VegDataValueObjects> vegDataValueObjects = new List<VegDataValueObjects>();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<VegDataValueObjects> vegDataValueObjectLoc = new List<VegDataValueObjects>();
            VegDataAccessManager dataManager = new VegDataAccessManager();
            vegDataValueObjects = dataManager.GetDataforAllstores();
            foreach (VegDataValueObjects vegDataValueLoc in vegDataValueObjects)
            {

                if (vegDataValueObjectLoc.FindAll(a=>a.VegeTableEName==vegDataValueLoc.VegeTableEName).Count==0)
                {
                    vegDataValueObjectLoc.Add(vegDataValueLoc);
                }
            }


            Repeater1.DataSource = vegDataValueObjectLoc;
            Repeater1.DataBind();
        }




        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            List<StorePriceList> storePriceList = new List<StorePriceList>();
            Repeater repeaterMain = e.Item.FindControl("storeListRepeater") as Repeater;

            if (repeaterMain != null)
            {
                StorePriceList storePrice = null;
                HiddenField hfVegName = e.Item.FindControl("hfVegName") as HiddenField;
                List<VegDataValueObjects> Temp = vegDataValueObjects.FindAll(a => a.VegeTableEName == hfVegName.Value);
                foreach (VegDataValueObjects vdvo in Temp)
                {
                    storePrice = new StorePriceList();
                    storePrice.StoreName = vdvo.StoreName;
                    storePrice.Price = vdvo.Price;
                    storePriceList.Add(storePrice);
                }
                for (int i = 0; i < 4 - storePriceList.Count; i++)
                {
                    storePrice = new StorePriceList();
                    storePrice.StoreName = "No Store";
                    storePrice.Price = "N/A";
                    storePriceList.Add(storePrice);
                }
                repeaterMain.DataSource = storePriceList;
                repeaterMain.DataBind();

            }
        }





    }

    class StorePriceList
    {
        //public string VegetableName { get; set; }
        public string StoreName { get; set; }
        public string Price { get; set; }
    }


}
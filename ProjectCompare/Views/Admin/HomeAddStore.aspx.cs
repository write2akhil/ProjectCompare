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
        List<Country> countryList;
        List<State> StateList;
        List<City> cityList;
        StoreDetailsAccessManager storeDetailAccessMgr;
        private void InitLists()
        {
            #region list init
            countryList = new List<Country>();
            Country c = new Country();
            c.Id = 1;
            c.Name = "India";
            countryList.Add(c);

            c = new Country();
            c.Id = 2;
            c.Name = "Pakistan";
            countryList.Add(c);

            StateList = new List<State>();
            State s = new State();
            s.Id = 1;
            s.CountryId = 1;
            s.Name = "UP";
            StateList.Add(s);

            s = new State();
            s.Id = 2;
            s.CountryId = 1;
            s.Name = "MP";
            StateList.Add(s);

            s = new State();
            s.Id = 3;
            s.CountryId = 2;
            s.Name = "Karachi";
            StateList.Add(s);

            s = new State();
            s.Id = 4;
            s.CountryId = 2;
            s.Name = "Mohali";
            StateList.Add(s);

            cityList = new List<City>();
            City c1 = new City();
            c1.Id = 1;
            c1.StateId = 1;
            c1.Name = "Ghaziabad";
            cityList.Add(c1);

            c1 = new City();
            c1.Id = 2;
            c1.StateId = 1;
            c1.Name = "Noida";
            cityList.Add(c1);

            c1 = new City();
            c1.Id = 3;
            c1.StateId = 1;
            c1.Name = "Gurgaon";
            cityList.Add(c1);

            c1 = new City();
            c1.Id = 3;
            c1.StateId = 2;
            c1.Name = "Jhansi";
            cityList.Add(c1);
            #endregion
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            InitLists();
            if (!IsPostBack)
            {
                country.DataTextField = "Name";
                country.DataValueField = "Id";
                country.DataSource = countryList;
                country.DataBind();
            }
            


        }
        protected void Country_Selected(object sender, EventArgs e)
        {
            state.DataTextField = "Name";
            state.DataValueField = "Id";
            state.DataSource = StateList.FindAll(a => a.CountryId == Convert.ToInt32(country.SelectedValue));
            state.DataBind();
        }

        protected void State_Changed(object sender, EventArgs e)
        {
            city.DataTextField = "Name";
            city.DataValueField = "Id";
            city.DataSource = cityList.FindAll(a => a.StateId == Convert.ToInt32(state.SelectedValue));
            city.DataBind();
        }

        protected void save_Click(object sender, EventArgs e)
        {
            storeDetailAccessMgr = new StoreDetailsAccessManager();
            StoreDetailsValueObjects storeDetail = new StoreDetailsValueObjects();
            storeDetail.StoreName = storeName.Text;
            storeDetail.Country = country.Text;
            storeDetail.State = state.Text;
            storeDetail.City = city.Text;
            storeDetail.Address = address.Text;
            storeDetailAccessMgr.SaveStoreDetails(storeDetail);
        }

        
    }
    class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class State
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
    class City
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string Name { get; set; }
    }
}
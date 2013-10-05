using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ProjectCompare
{
    public class VegDataAccessProvider
    {
        public List<VegDataValueObjects> GetDataforAllStores()
        {
            List<VegDataValueObjects> vegCollection = new List<VegDataValueObjects>();
            VegDataValueObjects vegColl = new VegDataValueObjects();
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                using (SqlCommand cmd = new SqlCommand("GetVegPriceList_AllStores", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();

                    // SqlParameter custId = cmd.Parameters.AddWithValue("@CustomerId", 10);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vegColl = new VegDataValueObjects();
                            vegColl.VegeTableEName = dr["VegeTableEName"].ToString();
                            vegColl.VegeTableHName = dr["VegeTableHName"].ToString();
                            vegColl.StoreName = dr["StoreName"].ToString();
                            vegColl.Price = dr["Price"].ToString() + " Rs/Kg.";
                            vegCollection.Add(vegColl);
                        }

                    }
                }
            }

            return vegCollection;
        }

        public List<VegDataValueObjects> GetDataforStore(string storeName)
        {
            List<VegDataValueObjects> vegCollection = new List<VegDataValueObjects>();
            VegDataValueObjects vegColl = new VegDataValueObjects();
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                using (SqlCommand cmd = new SqlCommand("GetVegPriceList_Stores_Name", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();

                    SqlParameter store = cmd.Parameters.AddWithValue("@StoreName", storeName);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vegColl = new VegDataValueObjects();
                            vegColl.VegeTableEName = dr["VegeTableEName"].ToString();
                            vegColl.VegeTableHName = dr["VegeTableHName"].ToString();
                            vegColl.StoreName = dr["StoreName"].ToString();
                            vegColl.Price = dr["Price"].ToString();
                            vegCollection.Add(vegColl);
                        }

                    }
                    myConnection.Close();
                }
            }

            return vegCollection;
        }

        public bool AddItems(string itemEName, string itemHName)
        {
            bool returnStatus = true;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
                {
                    using (SqlCommand cmd = new SqlCommand("AddItems", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ItemEName", SqlDbType.NVarChar, 50));
                        cmd.Parameters.Add(new SqlParameter("@ItemHName", SqlDbType.NVarChar, 50));
                        cmd.Parameters["@ItemEName"].Value = itemEName;
                        cmd.Parameters["@ItemHName"].Value = itemHName;
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                returnStatus = false;
            }

            return returnStatus;
        }

        public List<StoreDetailsValueObjects> GetAllStores()
        {
            List<StoreDetailsValueObjects> storeCollection = new List<StoreDetailsValueObjects>();
            StoreDetailsValueObjects storeColl = new StoreDetailsValueObjects();
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                using (SqlCommand cmd = new SqlCommand("UniqueStoreName", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            storeColl = new StoreDetailsValueObjects();
                            storeColl.StoreID = dr["StoreID"].ToString(); ;
                            storeColl.StoreName = dr["StoreName"].ToString() + ", " + dr["City"].ToString() + ", " + dr["State"].ToString() + ", " + dr["Address"].ToString();
                          //  storeColl.City = dr["City"].ToString();
                          //  storeColl.State = dr["State"].ToString();
                          //  storeColl.Address = dr["Address"].ToString();
                            storeCollection.Add(storeColl);
                        }

                    }
                }
            }

            return storeCollection;
        }

        public bool AddAgents(string AgentName, string StoreID, string AgentMobileNumber)
        {
            bool returnStatus = true;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
                {
                    using (SqlCommand cmd = new SqlCommand("AddAgents", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@AgentName", SqlDbType.NVarChar, 50));
                        cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@AgentMobileNumber", SqlDbType.NVarChar, 50));
                        cmd.Parameters["@AgentName"].Value = AgentName;
                        cmd.Parameters["@StoreID"].Value = Convert.ToInt32(StoreID);
                        cmd.Parameters["@AgentMobileNumber"].Value = AgentMobileNumber;
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                returnStatus = false;
            }

            return returnStatus;
        }

        public List<AllItemsValueObjects> GetDataAllItems()
        {
            List<AllItemsValueObjects> vegCollection = new List<AllItemsValueObjects>();
            AllItemsValueObjects vegColl = new AllItemsValueObjects();
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                using (SqlCommand cmd = new SqlCommand("UniqueItems", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vegColl = new AllItemsValueObjects();
                            vegColl.VegeTableEName = dr["VegeTableEName"].ToString();
                            vegColl.VegeTableHName = dr["VegeTableHName"].ToString();
                            vegColl.VegetableId = dr["VegetableId"].ToString();
                            vegCollection.Add(vegColl);
                        }
                    }
                }
            }

            return vegCollection;
        }

        public List<AgentDetailsValueObjects> GetDataAllAgents()
        {
            List<AgentDetailsValueObjects> vegCollection = new List<AgentDetailsValueObjects>();
            AgentDetailsValueObjects vegColl = new AgentDetailsValueObjects();
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                using (SqlCommand cmd = new SqlCommand("UniqueAgents", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vegColl = new AgentDetailsValueObjects();
                            vegColl.StoreID = dr["StoreID"].ToString();
                            vegColl.AgentId = dr["AgentId"].ToString();
                            vegColl.AgentName = dr["AgentName"].ToString();
                            vegColl.AgentMobileNumber = dr["AgentMobileNumber"].ToString();
                            vegCollection.Add(vegColl);
                        }
                    }
                }
            }

            return vegCollection;
        }

        public bool AddStores(string storeName, string stateList, string cityList, string storeAddress, string storePincode, string storeContact)
        {
            bool returnStatus = true;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
                {
                    using (SqlCommand cmd = new SqlCommand("AddStores", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@StoreName", SqlDbType.NVarChar,50));
                        cmd.Parameters.Add(new SqlParameter("@State", SqlDbType.NVarChar,50));
                        cmd.Parameters.Add(new SqlParameter("@City", SqlDbType.NVarChar,50));
                        cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar,1024));
                        cmd.Parameters.Add(new SqlParameter("@Pincode", SqlDbType.Int));
                        cmd.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar,50));
                        cmd.Parameters["@StoreName"].Value = storeName;
                        cmd.Parameters["@State"].Value = stateList;// Convert.ToInt32(StoreID);
                        cmd.Parameters["@City"].Value = cityList;
                        cmd.Parameters["@Address"].Value = storeAddress;
                        cmd.Parameters["@Pincode"].Value = Convert.ToInt32(storePincode);
                        cmd.Parameters["@PhoneNumber"].Value = storeContact;
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                returnStatus = false;
            }

            return returnStatus;
        }

        public List<StoreDetailsValueObjects> GetAllStoreList()
        {
            List<StoreDetailsValueObjects> vegCollection = new List<StoreDetailsValueObjects>();
            StoreDetailsValueObjects vegColl = new StoreDetailsValueObjects();
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                using (SqlCommand cmd = new SqlCommand("UniqueStoreName", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    myConnection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            vegColl = new StoreDetailsValueObjects();
                            vegColl.StoreID = dr["StoreID"].ToString();
                            vegColl.StoreName = dr["StoreName"].ToString();
                            vegColl.State = dr["State"].ToString();
                            vegColl.City = dr["City"].ToString();
                            vegColl.Address = dr["Address"].ToString();
                            vegColl.PinCode = dr["PinCode"].ToString();
                            vegColl.Phone = dr["PhoneNumber"].ToString();
                            vegCollection.Add(vegColl);
                        }
                    }
                }
            }

            return vegCollection;
        }
    }

    public class StoreDetailAccessProvider
    {
        public int SaveStoreDetails(StoreDetailsValueObjects storeDetails)
        {
            int result;
            using (SqlConnection myConnection = new SqlConnection(@"Data Source=DEVMACHINE\TESTSQL;Initial Catalog=VegData;Persist Security Info=True;User ID=sa;Password=Emimusic@123"))
            {
                string query = "insert into StoreDetails(StoreName,State,City,Address,Pincode,PhoneNumber)values('" +
                    storeDetails.StoreName + "','" + storeDetails.State + "','" +
                    storeDetails.City + "','" + storeDetails.Address + "','" + storeDetails.PinCode + "','" +
                    storeDetails.Phone + "')";
                myConnection.Open();
                SqlCommand cmd = new SqlCommand(query, myConnection);
                result = cmd.ExecuteNonQuery();
                myConnection.Close();
            }
            return result;
        }
    }
}
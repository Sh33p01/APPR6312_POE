using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class AddDisasterModel : PageModel
    {
        public List<DisasterInfo> DisInfo = new List<DisasterInfo>();

        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=appr6312-poe-part1.database.windows.net;Initial Catalog=APPR6312-POE;Persist Security Info=True;User ID=ST10118069;Password=AdminPass1";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sql = "SELECT * FROM Disaster";
                    using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DisasterInfo DInfo = new DisasterInfo();
                                DInfo.DisasterID = "" + reader.GetInt32(0);
                                DInfo.StartDate = reader.GetDateTime(1).ToString();
                                DInfo.EndDate = reader.GetDateTime(2).ToString();
                                DInfo.Location = reader.GetString(3);
                                DInfo.AidType = reader.GetString(4);
                                DInfo.Description = reader.GetString(5);
                                DInfo.Active = reader.GetString(6);
                                DInfo.Funds = reader.GetInt32(7).ToString();
                                

                                DisInfo.Add(DInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }
        }
    }

    public class DisasterInfo
    {
        public string DisasterID;
        public string StartDate;
        public string EndDate;
        public string Location;
        public string AidType;
        public string Description;
        public string Active;
        public string Funds;
    }
}

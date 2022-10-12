using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;


//𝘊𝘳𝘦𝘢𝘵𝘦 𝘈𝘚𝘗.𝘕𝘌𝘛 𝘊𝘰𝘳𝘦 𝘞𝘦𝘣 𝘈𝘱𝘱𝘭𝘪𝘤𝘢𝘵𝘪𝘰𝘯 𝘞𝘪𝘵𝘩 𝘚𝘘𝘓 𝘚𝘦𝘳𝘷𝘦𝘳 𝘋𝘢𝘵𝘢𝘣𝘢𝘴𝘦 𝘊𝘰𝘯𝘯𝘦𝘤𝘵𝘪𝘰𝘯 𝘢𝘯𝘥 𝘊𝘙𝘜𝘋 𝘖𝘱𝘦𝘳𝘢𝘵𝘪𝘰𝘯𝘴 - Unknown. 2022 YouTube video, added by BoostMyTool
//    [Online]. Available at: https://www.youtube.com/watch?v=T-e554Zt3n4 [Accessed 14 September 2022].
namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class DonationViewModel : PageModel
    {
        public List<PublicDonoView> publicView = new List<PublicDonoView>();
        public List<DisasterInfo> DisInfo = new List<DisasterInfo>();


        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=appr6312-poe-part1.database.windows.net;Initial Catalog=APPR6312-POE;Persist Security Info=True;User ID=ST10118069;Password=AdminPass1";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sql = "SELECT * FROM Donations";
                    using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PublicDonoView pubView = new PublicDonoView();
                                pubView.DonationID = "" + reader.GetInt32(0);
                                pubView.Company = reader.GetString(1);
                                pubView.Date = reader.GetDateTime(2).ToString();
                                pubView.NumItems = reader.GetInt32(3).ToString();
                                pubView.Category = reader.GetString(4);
                                pubView.Disaster = reader.GetString(5);
                                pubView.Description = reader.GetString(6);

                                publicView.Add(pubView);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
            }

            /* This is where we'll pull the Disaster Table's contents*/

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
                                DInfo.Funds = reader.GetString(7);


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

    public class PublicDonoView
    {
        public string DonationID;
        public string Company;
        public string Date;
        public string NumItems;
        public string Category;
        public string Disaster;
        public string Description;

    }

    
}

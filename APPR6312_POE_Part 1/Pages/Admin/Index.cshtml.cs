using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;


//𝘊𝘳𝘦𝘢𝘵𝘦 𝘈𝘚𝘗.𝘕𝘌𝘛 𝘊𝘰𝘳𝘦 𝘞𝘦𝘣 𝘈𝘱𝘱𝘭𝘪𝘤𝘢𝘵𝘪𝘰𝘯 𝘞𝘪𝘵𝘩 𝘚𝘘𝘓 𝘚𝘦𝘳𝘷𝘦𝘳 𝘋𝘢𝘵𝘢𝘣𝘢𝘴𝘦 𝘊𝘰𝘯𝘯𝘦𝘤𝘵𝘪𝘰𝘯 𝘢𝘯𝘥 𝘊𝘙𝘜𝘋 𝘖𝘱𝘦𝘳𝘢𝘵𝘪𝘰𝘯𝘴 - Unknown. 2022 YouTube video, added by BoostMyTool
//    [Online]. Available at: https://www.youtube.com/watch?v=T-e554Zt3n4 [Accessed 14 September 2022].
namespace APPR6312_POE_Part_1.Pages.Companies
{
    public class IndexModel : PageModel
    {

        public List<CompanieInfo> ListCompanies = new List<CompanieInfo>();

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
                                CompanieInfo companyInfo = new CompanieInfo();
                                companyInfo.DonationID = "" + reader.GetInt32(0);
                                companyInfo.Company = reader.GetString(1);
                                companyInfo.Date = reader.GetDateTime(2).ToString();
                                companyInfo.NumItems = reader.GetInt32(3).ToString();
                                companyInfo.Category = reader.GetString(4);
                                companyInfo.Disaster = reader.GetString(5);
                                companyInfo.Description = reader.GetString(6);

                                ListCompanies.Add(companyInfo);
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

    public class CompanieInfo 
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

using APPR6312_POE_Part_1.Pages.Companies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;


//𝘊𝘳𝘦𝘢𝘵𝘦 𝘈𝘚𝘗.𝘕𝘌𝘛 𝘊𝘰𝘳𝘦 𝘞𝘦𝘣 𝘈𝘱𝘱𝘭𝘪𝘤𝘢𝘵𝘪𝘰𝘯 𝘞𝘪𝘵𝘩 𝘚𝘘𝘓 𝘚𝘦𝘳𝘷𝘦𝘳 𝘋𝘢𝘵𝘢𝘣𝘢𝘴𝘦 𝘊𝘰𝘯𝘯𝘦𝘤𝘵𝘪𝘰𝘯 𝘢𝘯𝘥 𝘊𝘙𝘜𝘋 𝘖𝘱𝘦𝘳𝘢𝘵𝘪𝘰𝘯𝘴 - Unknown. 2022 YouTube video, added by BoostMyTool
//    [Online]. Available at: https://www.youtube.com/watch?v=T-e554Zt3n4 [Accessed 14 September 2022].
namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class EditDonoModel : PageModel
    {

        public CompanieInfo donoInfo = new CompanieInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            string DonationID = Request.Query["DonationID"];

            try
            {
                string connectionString = "Server=tcp:appr6312-poe-part1.database.windows.net,1433;Initial Catalog=APPR6312-POE;Persist Security Info=False;User ID=ST10118069;Password=AdminPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Donations WHERE DonationID=@DonationID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                        command.Parameters.AddWithValue("@DonationID", DonationID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                donoInfo.Company = reader.GetString(0);
                                donoInfo.Date = reader.GetDateTime(1).ToString();
                                donoInfo.NumItems = reader.GetString(2);
                                donoInfo.Category = reader.GetString(3);
                                donoInfo.Disaster = reader.GetString(4);
                                donoInfo.Description = reader.GetString(5);

                            }
                        }
                    }
                }
            }

            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }


        public void OnPost()
        {
            
            donoInfo.Company = Request.Form["Company"];
            donoInfo.Date = Request.Form["Date"];
            donoInfo.NumItems = Request.Form["NumItems"];
            donoInfo.Category = Request.Form["Category"];
            donoInfo.Disaster = Request.Form["Disaster"];
            donoInfo.Description = Request.Form["Description"];

            if (donoInfo.Company.Length == 0 || donoInfo.Date.Length == 0 ||
                donoInfo.NumItems.Length == 0 || donoInfo.Category.Length == 0 ||
                donoInfo.Disaster.Length == 0 || donoInfo.Description.Length == 0)
            {
                errorMessage = "All Fields are required";
                return;
            }

            try
            {
                String connectionString = "Data Source=appr6312-poe-part1.database.windows.net;Initial Catalog=APPR6312-POE;Persist Security Info=True;User ID=ST10118069;Password=AdminPass1";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "UPDATE Donations" +
                        "SET Company=@Company, Date=@Date, NumItems=@NumItems, Category=@Category, Disaster=@Disaster, Description=@Description" +
                        "WHERE DonationID=@DonationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Company", donoInfo.Company);
                        command.Parameters.AddWithValue("@Date", donoInfo.Date);
                        command.Parameters.AddWithValue("@NumItems", donoInfo.NumItems);
                        command.Parameters.AddWithValue("@Category", donoInfo.Category);
                        command.Parameters.AddWithValue("@Disaster", donoInfo.Disaster);
                        command.Parameters.AddWithValue("@Description", donoInfo.Description);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return;
            }

            Response.Redirect("/Admin/DonationView");
        }
    }
}

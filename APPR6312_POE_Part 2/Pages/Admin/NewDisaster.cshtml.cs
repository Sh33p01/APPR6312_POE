using APPR6312_POE_Part_1.Pages.Companies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System;

//𝘊𝘳𝘦𝘢𝘵𝘦 𝘈𝘚𝘗.𝘕𝘌𝘛 𝘊𝘰𝘳𝘦 𝘞𝘦𝘣 𝘈𝘱𝘱𝘭𝘪𝘤𝘢𝘵𝘪𝘰𝘯 𝘞𝘪𝘵𝘩 𝘚𝘘𝘓 𝘚𝘦𝘳𝘷𝘦𝘳 𝘋𝘢𝘵𝘢𝘣𝘢𝘴𝘦 𝘊𝘰𝘯𝘯𝘦𝘤𝘵𝘪𝘰𝘯 𝘢𝘯𝘥 𝘊𝘙𝘜𝘋 𝘖𝘱𝘦𝘳𝘢𝘵𝘪𝘰𝘯𝘴 - Unknown. 2022 YouTube video, added by BoostMyTool
//    [Online]. Available at: https://www.youtube.com/watch?v=T-e554Zt3n4 [Accessed 14 September 2022].

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class NewDisasterModel : PageModel
    {

        public DisasterInfo DisInfo = new DisasterInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            
            DisInfo.StartDate = Request.Form["StartDate"];
            DisInfo.EndDate = Request.Form["EndDate"];
            DisInfo.Location = Request.Form["Location"];
            DisInfo.AidType = Request.Form["AidType"];
            DisInfo.Description = Request.Form["Description"];
            DisInfo.Active = Request.Form["Active"];
            DisInfo.Funds = Request.Form["Funds"];

            if (DisInfo.StartDate.Length == 0 || DisInfo.EndDate.Length == 0 ||
                DisInfo.Location.Length == 0 || DisInfo.AidType.Length == 0 ||
                DisInfo.Description.Length == 0 || DisInfo.Active.Length == 0)
            {
                errorMessage = "All Fields are required";
                return;
            }

            //save data into the database
            try
            {
                String connectionString = "Data Source=appr6312-poe-part1.database.windows.net;Initial Catalog=APPR6312-POE;Persist Security Info=True;User ID=ST10118069;Password=AdminPass1";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "INSERT INTO Disaster " +
                        "(StartDate, EndDate, Location, AidType, Description, Active, Funds) VALUES" +
                        "(@StartDate, @EndDate, @Location, @AidType, @Description, @Active, @Funds);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                       
                        command.Parameters.AddWithValue("@StartDate", DisInfo.StartDate);
                        command.Parameters.AddWithValue("@EndDate", DisInfo.EndDate);
                        command.Parameters.AddWithValue("@Location", DisInfo.Location);
                        command.Parameters.AddWithValue("@AidType", DisInfo.AidType);
                        command.Parameters.AddWithValue("@Description", DisInfo.Description);
                        command.Parameters.AddWithValue("@Active", DisInfo.Active);
                        command.Parameters.AddWithValue("@Funds", DisInfo.Funds);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return;
            }

            DisInfo.StartDate = ""; DisInfo.EndDate = ""; DisInfo.Location = ""; DisInfo.AidType = ""; DisInfo.Description = ""; DisInfo.Active = ""; DisInfo.Funds = "";
            successMessage = "New Disaster has been Added";

            Response.Redirect("/Admin/AddDisaster");
        }
    }
}


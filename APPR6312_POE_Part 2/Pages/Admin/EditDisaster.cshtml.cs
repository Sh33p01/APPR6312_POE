using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class EditDisasterModel : PageModel
    {

        public DisasterInfo disasInfo = new DisasterInfo();
        public string errorMessage = "";
        public string successMessage = "";

        public void OnGet()
        {
            string donationID = Request.Query["DonationID"];

            try
            {
                String connectionString = "Data Source=appr6312-poe-part1.database.windows.net;Initial Catalog=APPR6312-POE;Persist Security Info=True;User ID=ST10118069;Password=AdminPass1";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM Disaster WHERE DisasterID=@DisasterID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DisasterID", disasInfo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                disasInfo.DisasterID = "" + reader.GetInt32(0);
                                disasInfo.StartDate = reader.GetDateTime(1).ToString();
                                disasInfo.EndDate = reader.GetDateTime(2).ToString();
                                disasInfo.Location = reader.GetString(3);
                                disasInfo.AidType = reader.GetString(4);
                                disasInfo.Description = reader.GetString(5);

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
            disasInfo.DisasterID = Request.Form["DonationID"];
            disasInfo.StartDate = Request.Form["Company"];
            disasInfo.EndDate = Request.Form["Date"];
            disasInfo.Location = Request.Form["NumItems"];
            disasInfo.AidType = Request.Form["Disaster"];
            disasInfo.Description = Request.Form["Description"];

            if (disasInfo.DisasterID.Length == 0 || disasInfo.StartDate.Length == 0 || disasInfo.EndDate.Length == 0 ||
                disasInfo.Location.Length == 0 || disasInfo.AidType.Length == 0 ||
                disasInfo.Description.Length == 0)
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
                        "WHERE donationID=@DonationID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Company", disasInfo.DisasterID);
                        command.Parameters.AddWithValue("@Date", disasInfo.StartDate);
                        command.Parameters.AddWithValue("@NumItems", disasInfo.EndDate);
                        command.Parameters.AddWithValue("@Category", disasInfo.Location);
                        command.Parameters.AddWithValue("@Disaster", disasInfo.AidType);
                        command.Parameters.AddWithValue("@Description", disasInfo.Description);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return;
            }

            Response.Redirect("/Admin/Index");
        }
    }
}

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
            String donationID = Request.Query["DisasterID"];

            try
            {
                string connectionString = "Server=tcp:appr6312-poe-part1.database.windows.net,1433;Initial Catalog=APPR6312-POE;Persist Security Info=False;User ID=ST10118069;Password=AdminPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Disaster";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DisasterID", disasInfo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                disasInfo.DisasterID = "" + reader.GetString(0);
                                disasInfo.StartDate = reader.GetDateTime(1).ToString();
                                disasInfo.EndDate = reader.GetDateTime(2).ToString();
                                disasInfo.Location = reader.GetString(3);
                                disasInfo.AidType = reader.GetString(4);
                                disasInfo.Description = reader.GetString(5);
                                disasInfo.Active = reader.GetString(6);
                                disasInfo.Funds = reader.GetString(7);

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
            disasInfo.DisasterID = Request.Form["DisasterID"];
            disasInfo.StartDate = Request.Form["StartDate"];
            disasInfo.EndDate = Request.Form["EndDate"];
            disasInfo.Location = Request.Form["Location"];
            disasInfo.AidType = Request.Form["AidType"];
            disasInfo.Description = Request.Form["Description"];
            disasInfo.Active = Request.Form["Active"];
            disasInfo.Funds = Request.Form["Funds"];

            if (disasInfo.DisasterID.Length ==0 || disasInfo.StartDate.Length == 0 || disasInfo.EndDate.Length == 0 ||
                disasInfo.Location.Length == 0 || disasInfo.AidType.Length == 0 ||
                disasInfo.Description.Length == 0 || disasInfo.Active.Length == 0 ||
                disasInfo.Funds.Length == 0)
            {
                errorMessage = "All Fields are required";
                return;
            }

            try
            {
                string connectionString = "Server=tcp:appr6312-poe-part1.database.windows.net,1433;Initial Catalog=APPR6312-POE;Persist Security Info=False;User ID=ST10118069;Password=AdminPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Donations" +
                        "SET DisasterID=@DisasterID, StartDate=@StartDate, EndDate=@EndDate, Location=@Location, AidType=@AidType, Description=@Description, Active=@Active, Funds@Funds" +
                        "WHERE DisasterID=@DisasterID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DisasterID", disasInfo.DisasterID);
                        command.Parameters.AddWithValue("@StartDate", disasInfo.StartDate);
                        command.Parameters.AddWithValue("@EndDate", disasInfo.EndDate);
                        command.Parameters.AddWithValue("@Location", disasInfo.Location);
                        command.Parameters.AddWithValue("@AidType", disasInfo.AidType);
                        command.Parameters.AddWithValue("@Description", disasInfo.Description);
                        command.Parameters.AddWithValue("@Active", disasInfo.Active);
                        command.Parameters.AddWithValue("@Funds", disasInfo.Funds);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return;
            }

            Response.Redirect("/Admin/AddDisaster");
        }
    }
}

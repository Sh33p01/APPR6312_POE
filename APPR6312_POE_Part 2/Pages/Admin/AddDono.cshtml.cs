using APPR6312_POE_Part_1.Pages.Companies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Data.SqlClient;

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class AddDonoModel : PageModel
    {

        public CompanieInfo donoInfo = new CompanieInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //donoInfo.DonationID = Request.Form["DonationID"];
            donoInfo.Company = Request.Form["Company"];
            donoInfo.Date = Request.Form["Date"];
            donoInfo.NumItems = Request.Form["NumItems"];
            donoInfo.Category = Request.Form["Category"];
            donoInfo.Disaster = Request.Form["Disaster"];
            donoInfo.Description = Request.Form["Description"];

            if (/*donoInfo.DonationID.Length == 0 ||*/ donoInfo.Company.Length == 0 || donoInfo.Date.Length == 0 ||
                donoInfo.NumItems.Length == 0 || donoInfo.Category.Length == 0 ||
                donoInfo.Disaster.Length == 0 || donoInfo.Description.Length == 0)
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
                    String sql = "INSERT INTO Donations " +
                        "(Company, Date, NumItems, Category, Disaster, Description) VALUES" +
                        "(@Company, @Date, @NumItems, @Category, @Disaster, @Description);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        //command.Parameters.AddWithValue("@DonationID", donoInfo.DonationID);
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

            /*donoInfo.DonationID = ""; */donoInfo.Company = ""; donoInfo.Date = ""; donoInfo.NumItems = ""; donoInfo.Category = ""; donoInfo.Disaster = ""; donoInfo.Description = "";
            successMessage = "New Donation has been Added";

            Response.Redirect("/Admin/Index");
        }
    }
}

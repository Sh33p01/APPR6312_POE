using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class LoginModel : PageModel
    {
        


    public void OnGet()
        {

        }

        public void OnPost()
        {
            string email = Request.Form["uEmail"];
            string pass = Request.Form["uPass"];



            string connectionString = "Server=tcp:appr6312-poe-part1.database.windows.net,1433;Initial Catalog=APPR6312-POE;Persist Security Info=False;User ID=ST10118069;Password=AdminPass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM ALogin";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string em = Convert.ToString(reader["Email"]);
                            string ps = Convert.ToString(reader["Pass"]);



                            if (email == em && pass == ps)
                            {
                                Response.Redirect("/Admin/AdminChoice");
                            }

                        }
                    }
                }
            }
        }









    }
}

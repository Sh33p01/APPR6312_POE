using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class NewPurchaseModel : PageModel
    {
        public PurchaseInfo purInfo = new PurchaseInfo();
        public string errorMessage = "";
        public string successMessage = "";
        public void OnGet()
        {

        }

        public void OnPost()
        {

            purInfo.Company = Request.Form["Company"];
            purInfo.Money = Request.Form["Money"];
            purInfo.Goods = Request.Form["Goods"];
            purInfo.Price = Request.Form["Price"];
            purInfo.Amount = Request.Form["Amount"];
            purInfo.TotalPrice = Request.Form["TotalPrice"];
            purInfo.MoneyLeft = Request.Form["MoneyLeft"];
            purInfo.Disaster = Request.Form["Disaster"];
            

            if (purInfo.Company.Length == 0 || purInfo.Money.Length == 0 ||
                purInfo.Goods.Length == 0 || purInfo.Price.Length == 0 ||
                purInfo.Amount.Length == 0 || purInfo.TotalPrice.Length == 0 ||
                purInfo.MoneyLeft.Length == 0 || purInfo.Disaster.Length == 0)
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
                    String sql = "INSERT INTO Purchase " +
                        "(Company, Money, Goods, Price, Amount, TotalPrice, MoneyLeft, Disaster) VALUES" +
                        "(@Company, @Money, @Goods, @Price, @Amount, @TotalPrice, @MoneyLeft, @Disaster);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Company", purInfo.Company);
                        command.Parameters.AddWithValue("@Money", purInfo.Money);
                        command.Parameters.AddWithValue("@Goods", purInfo.Goods);
                        command.Parameters.AddWithValue("@Price", purInfo.Price);
                        command.Parameters.AddWithValue("@Amount", purInfo.Amount);
                        command.Parameters.AddWithValue("@TotalPrice", purInfo.TotalPrice);
                        command.Parameters.AddWithValue("@MoneyLeft", purInfo.MoneyLeft);
                        command.Parameters.AddWithValue("@Disaster", purInfo.Disaster);


                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return;
            }

            purInfo.Company = ""; purInfo.Money = ""; purInfo.Goods = ""; purInfo.Price = ""; purInfo.Amount = ""; purInfo.TotalPrice = ""; purInfo.MoneyLeft = ""; purInfo.Disaster = "";
            successMessage = "New Purchase has been Added";

            Response.Redirect("/Admin/PurchaseGoods");
        }
    }
}

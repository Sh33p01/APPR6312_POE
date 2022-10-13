using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APPR6312_POE_Part_1.Pages.Admin
{
    public class PurchaseGoodsModel : PageModel
    {
        public List<PurchaseInfo> pInfo = new List<PurchaseInfo>();

        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=appr6312-poe-part1.database.windows.net;Initial Catalog=APPR6312-POE;Persist Security Info=True;User ID=ST10118069;Password=AdminPass1";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    string sql = "SELECT * FROM Purchase";
                    using (SqlCommand command = new SqlCommand(sql, sqlConnection))
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PurchaseInfo purInfo = new PurchaseInfo();
                                purInfo.PurchaseID = "" + reader.GetInt32(0);
                                purInfo.Company = reader.GetString(1);
                                purInfo.Money = reader.GetString(2);
                                purInfo.Goods = reader.GetString(3);
                                purInfo.Price = reader.GetString(4);
                                purInfo.Amount = reader.GetString(5);
                                purInfo.TotalPrice = reader.GetString(6);
                                purInfo.MoneyLeft = reader.GetString(7);
                                purInfo.Disaster = reader.GetString(8);


                                pInfo.Add(purInfo);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.ToString());
            }
        }
    }

    public class PurchaseInfo
    {
        public string PurchaseID;
        public string Company;
        public string Money;
        public string Goods;
        public string Price;
        public string Amount;
        public string TotalPrice;
        public string MoneyLeft;
        public string Disaster;
    }
}

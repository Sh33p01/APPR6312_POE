#pragma checksum "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4a182dd5075d736896db53ddd2a20fa3c3b2609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(APPR6312_POE_Part_1.Pages.Admin.Pages_Admin_PurchaseGoods), @"mvc.1.0.razor-page", @"/Pages/Admin/PurchaseGoods.cshtml")]
namespace APPR6312_POE_Part_1.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\_ViewImports.cshtml"
using APPR6312_POE_Part_1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4a182dd5075d736896db53ddd2a20fa3c3b2609", @"/Pages/Admin/PurchaseGoods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be897a91ced82d34fe1a6a9491f43d34ceae738e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_PurchaseGoods : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
  
//𝘊𝘳𝘦𝘢𝘵𝘦 𝘈𝘚𝘗.𝘕𝘌𝘛 𝘊𝘰𝘳𝘦 𝘞𝘦𝘣 𝘈𝘱𝘱𝘭𝘪𝘤𝘢𝘵𝘪𝘰𝘯 𝘞𝘪𝘵𝘩 𝘚𝘘𝘓 𝘚𝘦𝘳𝘷𝘦𝘳 𝘋𝘢𝘵𝘢𝘣𝘢𝘴𝘦 𝘊𝘰𝘯𝘯𝘦𝘤𝘵𝘪𝘰𝘯 𝘢𝘯𝘥 𝘊𝘙𝘜𝘋 𝘖𝘱𝘦𝘳𝘢𝘵𝘪𝘰𝘯𝘴 - Unknown. 2022 YouTube video, added by BoostMyTool
//    [Online]. Available at: https://www.youtube.com/watch?v=T-e554Zt3n4 [Accessed 14 September 2022].

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




    <br />
    <h2>List of Goods Purchased</h2>
    <a class='btn btn-primary btn-sm' href='/Admin/NewPurchase'>New Purchase</a>
    <p></p>
    

    
    <table class=""table"">
        <thead>
            <tr>
                <th>Purchase ID</th>
                <th>Company</th>
                <th>Money</th>
                <th>Goods</th>
                <th>Price</th>
                <th>Amount</th>
                <th>Total Price</th>
                <th>Money Left</th>
                <th>Disaster</th>
                

            </tr>
        </thead>

            <tbody style=""background-color: #FCD299 "">
");
#nullable restore
#line 37 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                 foreach (var item in Model.pInfo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 40 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.PurchaseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Goods);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.MoneyLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Disaster);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1682, "\"", 1728, 2);
            WriteAttributeValue("", 1689, "/Admin/EditDisaster?id=", 1689, 23, true);
#nullable restore
#line 50 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
WriteAttributeValue("", 1712, item.PurchaseID, 1712, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                            <p>\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1895, "\"", 1939, 2);
            WriteAttributeValue("", 1902, "/Companies/Delete?id=", 1902, 21, true);
#nullable restore
#line 54 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
WriteAttributeValue("", 1923, item.PurchaseID, 1923, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n<p></p>\r\n<a class=\'btn btn-primary btn-sm\' href=\'/Admin/AdminChoice\'>Back to Choices</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APPR6312_POE_Part_1.Pages.Admin.PurchaseGoodsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Admin.PurchaseGoodsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Admin.PurchaseGoodsModel>)PageContext?.ViewData;
        public APPR6312_POE_Part_1.Pages.Admin.PurchaseGoodsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

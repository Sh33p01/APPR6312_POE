#pragma checksum "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16897770e9fd94f1a0a173d3fc2a3371e9579bc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16897770e9fd94f1a0a173d3fc2a3371e9579bc", @"/Pages/Admin/PurchaseGoods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be897a91ced82d34fe1a6a9491f43d34ceae738e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_PurchaseGoods : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



    <br />
    <h2>List of Disasters</h2>
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
#line 34 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                 foreach (var item in Model.pInfo)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 37 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.PurchaseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Goods);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.MoneyLeft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                       Write(item.Disaster);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1344, "\"", 1390, 2);
            WriteAttributeValue("", 1351, "/Admin/EditDisaster?id=", 1351, 23, true);
#nullable restore
#line 47 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
WriteAttributeValue("", 1374, item.PurchaseID, 1374, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                            <p>\r\n                        </td>\r\n                        <td>\r\n                            <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1557, "\"", 1601, 2);
            WriteAttributeValue("", 1564, "/Companies/Delete?id=", 1564, 21, true);
#nullable restore
#line 51 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
WriteAttributeValue("", 1585, item.PurchaseID, 1585, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\PurchaseGoods.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>");
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
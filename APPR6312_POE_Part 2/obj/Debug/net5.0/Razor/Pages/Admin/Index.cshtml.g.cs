#pragma checksum "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf3fd80707632a4aee7efb137c4d47b6a3b923a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(APPR6312_POE_Part_1.Pages.Admin.Pages_Admin_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3fd80707632a4aee7efb137c4d47b6a3b923a7", @"/Pages/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be897a91ced82d34fe1a6a9491f43d34ceae738e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<br />
<h2>List of Dontions</h2>
<a class='btn btn-primary btn-sm' href='/Admin/AddDono'>New Donation</a>
<p></p>
<table class=""table"">
    <thead>
        <tr>
            <th>Donation ID</th>
            <th>Company</th>
            <th>Date</th>
            <th>NumItems</th>
            <th>Category</th>
            <th>Disaster</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody style=""background-color: #FCD299 "">
");
#nullable restore
#line 28 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
         foreach (var item in Model.ListCompanies)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.DonationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.NumItems);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.Disaster);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1326, "\"", 1368, 2);
            WriteAttributeValue("", 1333, "/Admin/EditDono?id=", 1333, 19, true);
#nullable restore
#line 39 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
WriteAttributeValue("", 1352, item.DonationID, 1352, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1433, "\"", 1477, 2);
            WriteAttributeValue("", 1440, "/Companies/Delete?id=", 1440, 21, true);
#nullable restore
#line 40 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
WriteAttributeValue("", 1461, item.DonationID, 1461, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APPR6312_POE_Part_1.Pages.Companies.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Companies.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Companies.IndexModel>)PageContext?.ViewData;
        public APPR6312_POE_Part_1.Pages.Companies.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

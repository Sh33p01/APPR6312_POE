#pragma checksum "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386ea37f7e00ba087a27da4fb9619f864301569e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(APPR6312_POE_Part_1.Pages.Admin.Pages_Admin_DonationView), @"mvc.1.0.razor-page", @"/Pages/Admin/DonationView.cshtml")]
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
#line 1 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\_ViewImports.cshtml"
using APPR6312_POE_Part_1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386ea37f7e00ba087a27da4fb9619f864301569e", @"/Pages/Admin/DonationView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be897a91ced82d34fe1a6a9491f43d34ceae738e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_DonationView : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .table{\r\n        background-color: white;\r\n    }\r\n</style>\r\n\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "386ea37f7e00ba087a27da4fb9619f864301569e3342", async() => {
                WriteLiteral("\r\n    <title>Admin Login</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "386ea37f7e00ba087a27da4fb9619f864301569e4342", async() => {
                WriteLiteral(@"
    <br />
    <h2>List of Dontions</h2>
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
#line 37 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
             foreach (var item in Model.publicView)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.DonationID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.NumItems);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Disaster);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>

    <br />
    <!-- This is the Disaster Info's Table'-->
    <h2>List of Disasters</h2>
    <p></p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Disaster ID</th>
                <th>Start Date</th>
                <th>End Date</th>
                <th>Location</th>
                <th>Aid Type</th>
                <th>Description</th>
                <th>Active</th>
                <th>Funds</th>
            </tr>
        </thead>
        <tbody style=""background-color: #FCD299 "">
");
#nullable restore
#line 70 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
             foreach (var item in Model.DisInfo)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 73 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.DisasterID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 74 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 75 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.EndDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 76 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 77 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.AidType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 78 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 79 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Active);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 80 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
                   Write(item.Funds);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Final POE\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\DonationView.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APPR6312_POE_Part_1.Pages.Admin.DonationViewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Admin.DonationViewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Admin.DonationViewModel>)PageContext?.ViewData;
        public APPR6312_POE_Part_1.Pages.Admin.DonationViewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

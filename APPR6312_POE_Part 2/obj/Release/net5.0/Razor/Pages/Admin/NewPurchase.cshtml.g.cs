#pragma checksum "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68aad814fdf3ec5ac4e3156804e76f1fe22aa86e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(APPR6312_POE_Part_1.Pages.Admin.Pages_Admin_NewPurchase), @"mvc.1.0.razor-page", @"/Pages/Admin/NewPurchase.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68aad814fdf3ec5ac4e3156804e76f1fe22aa86e", @"/Pages/Admin/NewPurchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be897a91ced82d34fe1a6a9491f43d34ceae738e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_NewPurchase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h2>New Purchase</h2>\r\n\r\n");
#nullable restore
#line 12 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n        <strong>");
#nullable restore
#line 15 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n    </div>\r\n");
#nullable restore
#line 18 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68aad814fdf3ec5ac4e3156804e76f1fe22aa86e4584", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Company Name</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Company\"");
                BeginWriteAttribute("value", " value=\"", 936, "\"", 966, 1);
#nullable restore
#line 25 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 944, Model.purInfo.Company, 944, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Money</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Money\"");
                BeginWriteAttribute("value", " value=\"", 1188, "\"", 1216, 1);
#nullable restore
#line 32 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 1196, Model.purInfo.Money, 1196, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Goods</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Goods\"");
                BeginWriteAttribute("value", " value=\"", 1438, "\"", 1466, 1);
#nullable restore
#line 39 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 1446, Model.purInfo.Goods, 1446, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Price</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 1688, "\"", 1716, 1);
#nullable restore
#line 46 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 1696, Model.purInfo.Price, 1696, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Amount</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Amount\"");
                BeginWriteAttribute("value", " value=\"", 1940, "\"", 1969, 1);
#nullable restore
#line 53 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 1948, Model.purInfo.Amount, 1948, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Total Price</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"TotalPrice\"");
                BeginWriteAttribute("value", " value=\"", 2202, "\"", 2235, 1);
#nullable restore
#line 60 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 2210, Model.purInfo.TotalPrice, 2210, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Money Left</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"MoneyLeft\"");
                BeginWriteAttribute("value", " value=\"", 2466, "\"", 2498, 1);
#nullable restore
#line 67 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 2474, Model.purInfo.MoneyLeft, 2474, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Disaster</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Disaster\"");
                BeginWriteAttribute("value", " value=\"", 2726, "\"", 2757, 1);
#nullable restore
#line 74 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
WriteAttributeValue("", 2734, Model.purInfo.Disaster, 2734, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 78 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
     if (Model.successMessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n                    <strong>");
#nullable restore
#line 83 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
                       Write(Model.successMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\' la></button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 88 "D:\Backup\Work\Year 3\Semester 2\APPR6312\POE\Task 2\APPR6312_POE_Part 2\APPR6312_POE_Part 2\Pages\Admin\NewPurchase.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/Admin/PurchaseGoods"" role=""button"">Cancel</a>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APPR6312_POE_Part_1.Pages.Admin.NewPurchaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Admin.NewPurchaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APPR6312_POE_Part_1.Pages.Admin.NewPurchaseModel>)PageContext?.ViewData;
        public APPR6312_POE_Part_1.Pages.Admin.NewPurchaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

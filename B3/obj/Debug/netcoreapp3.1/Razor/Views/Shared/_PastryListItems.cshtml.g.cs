#pragma checksum "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\Shared\_PastryListItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1398cb21c391964c6d969644fa6c312aea03c178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PastryListItems), @"mvc.1.0.view", @"/Views/Shared/_PastryListItems.cshtml")]
namespace AspNetCore
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
#line 2 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\_ViewImports.cshtml"
using B3.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\_ViewImports.cshtml"
using B3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1398cb21c391964c6d969644fa6c312aea03c178", @"/Views/Shared/_PastryListItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3882aaf934aef59df1fee5c2cb2c33e0f77445ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PastryListItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pastry>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pastry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- Partial View for Pastry-->\r\n");
            WriteLiteral(@"
<li class=""list-group-item"">
<!--Only the Product info without the Comments and Ratings-->
    <div class=""media align-items-lg-center flex-column flex-lg-row p-3"">
        <div class=""media-body order-2 order-lg-1"">
            <h5 class=""mt-0 font-weight-bold mb-2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1398cb21c391964c6d969644fa6c312aea03c1784078", async() => {
#nullable restore
#line 9 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\Shared\_PastryListItems.cshtml"
                                                                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\Shared\_PastryListItems.cshtml"
                                                                  WriteLiteral(Model.PastryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </h5>\r\n            <p class=\"font-italic text-muted mb-0 small\">");
#nullable restore
#line 11 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\Shared\_PastryListItems.cshtml"
                                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"d-flex align-items-center justify-content-between mt-1\">\r\n                <h6 class=\"font-weight-bold my-2\">");
#nullable restore
#line 13 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\Shared\_PastryListItems.cshtml"
                                             Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            </div>\r\n        </div><img");
            BeginWriteAttribute("src", " src=", 741, "", 770, 1);
#nullable restore
#line 15 "D:\WebbDevJU\Dynamiska Webbsystem\Vecka 3.4\B3\B3\Views\Shared\_PastryListItems.cshtml"
WriteAttributeValue("", 746, Model.ImageThumbnailUrl, 746, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Generic placeholder image\" width=\"200\" class=\"ml-lg-5 order-1 order-lg-2\">\r\n    </div> <!-- End -->\r\n</li>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pastry> Html { get; private set; }
    }
}
#pragma warning restore 1591

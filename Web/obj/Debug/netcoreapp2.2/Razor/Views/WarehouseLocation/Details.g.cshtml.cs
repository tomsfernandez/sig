#pragma checksum "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b41570c25234a1f038f1154c2ce5cb9533b39a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WarehouseLocation_Details), @"mvc.1.0.view", @"/Views/WarehouseLocation/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WarehouseLocation/Details.cshtml", typeof(AspNetCore.Views_WarehouseLocation_Details))]
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
#line 1 "/Users/tomasforman/sandbox/sig/Web/Views/_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "/Users/tomasforman/sandbox/sig/Web/Views/_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41570c25234a1f038f1154c2ce5cb9533b39a5f", @"/Views/WarehouseLocation/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_WarehouseLocation_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Domain.WarehouseLocation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 132, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>WarehouseLocation</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(217, 43, false);
#line 14 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Section));

#line default
#line hidden
            EndContext();
            BeginContext(260, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(321, 39, false);
#line 17 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayFor(model => model.Section));

#line default
#line hidden
            EndContext();
            BeginContext(360, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(420, 41, false);
#line 20 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aisle));

#line default
#line hidden
            EndContext();
            BeginContext(461, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(522, 37, false);
#line 23 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayFor(model => model.Aisle));

#line default
#line hidden
            EndContext();
            BeginContext(559, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(619, 44, false);
#line 26 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(663, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(724, 40, false);
#line 29 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(764, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(824, 41, false);
#line 32 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
            EndContext();
            BeginContext(865, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(926, 37, false);
#line 35 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
       Write(Html.DisplayFor(model => model.Level));

#line default
#line hidden
            EndContext();
            BeginContext(963, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1005, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41570c25234a1f038f1154c2ce5cb9533b39a5f7334", async() => {
                BeginContext(1051, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "/Users/tomasforman/sandbox/sig/Web/Views/WarehouseLocation/Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1059, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1066, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41570c25234a1f038f1154c2ce5cb9533b39a5f9612", async() => {
                BeginContext(1088, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1104, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Domain.WarehouseLocation> Html { get; private set; }
    }
}
#pragma warning restore 1591
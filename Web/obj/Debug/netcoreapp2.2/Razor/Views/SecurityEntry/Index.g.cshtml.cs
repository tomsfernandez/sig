#pragma checksum "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a423959dd8cca5fb020bc6cc8d8963e0e87aa1f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SecurityEntry_Index), @"mvc.1.0.view", @"/Views/SecurityEntry/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SecurityEntry/Index.cshtml", typeof(AspNetCore.Views_SecurityEntry_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a423959dd8cca5fb020bc6cc8d8963e0e87aa1f1", @"/Views/SecurityEntry/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"243bef8901b38e9eef9e38f8c66b8f401f171c9b", @"/Views/_ViewImports.cshtml")]
    public class Views_SecurityEntry_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Domain.Entry>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 460, true);
            WriteLiteral(@"
<h1>Control de seguridad</h1>

<table class=""table"">
    <thead>
    <tr>
        <th>
            Entrada
        </th>
        <th>
            Salida
        </th>
        <th>
            Número de remito
        </th>
        <th>
            DNI de conductor
        </th>
        <th>
            Patente del vehículo
        </th>
        <th>
            Patente del trailer
        </th>
        <th>Acciones</th>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 34 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(578, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(625, 44, false);
#line 37 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntryDate));

#line default
#line hidden
            EndContext();
            BeginContext(669, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(722, 43, false);
#line 40 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExitDate));

#line default
#line hidden
            EndContext();
            BeginContext(765, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(818, 48, false);
#line 43 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Remittance.Id));

#line default
#line hidden
            EndContext();
            BeginContext(866, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(919, 45, false);
#line 46 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Driver.Dni));

#line default
#line hidden
            EndContext();
            BeginContext(964, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1017, 55, false);
#line 49 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vehicle.LicensePlate));

#line default
#line hidden
            EndContext();
            BeginContext(1072, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1125, 55, false);
#line 52 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Trailer.LicensePlate));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1232, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a423959dd8cca5fb020bc6cc8d8963e0e87aa1f16797", async() => {
                BeginContext(1279, 11, true);
                WriteLiteral("Ver detalle");
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
#line 55 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(1294, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 58 "/Users/tomasforman/sandbox/sig/Web/Views/SecurityEntry/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1333, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Domain.Entry>> Html { get; private set; }
    }
}
#pragma warning restore 1591

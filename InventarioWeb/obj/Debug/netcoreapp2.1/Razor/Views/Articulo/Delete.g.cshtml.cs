#pragma checksum "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7afa057914ac7e18d5bfaa87122e67aeb535fd02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articulo_Delete), @"mvc.1.0.view", @"/Views/Articulo/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articulo/Delete.cshtml", typeof(AspNetCore.Views_Articulo_Delete))]
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
#line 1 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\_ViewImports.cshtml"
using InventarioWeb;

#line default
#line hidden
#line 2 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\_ViewImports.cshtml"
using InventarioWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afa057914ac7e18d5bfaa87122e67aeb535fd02", @"/Views/Articulo/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda3f3335e43b4c97e85daba220cbed09ffb0956", @"/Views/_ViewImports.cshtml")]
    public class Views_Articulo_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioWeb.Models.Articulo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
  
    ViewData["Title"] = "Eliminar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 63, true);
            WriteLiteral("\r\n<h2>Articulo</h2>\r\n<h4>Eliminar</h4>\r\n<p class=\"text-danger\">");
            EndContext();
            BeginContext(195, 24, false);
#line 10 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
                  Write(ViewData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(219, 65, true);
            WriteLiteral("</p>\r\n<h3>Estás seguro que quieres eliminar este registro?</h3>\r\n");
            EndContext();
#line 12 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
 using (Html.BeginForm("Delete", "Articulo"))
{
    

#line default
#line hidden
            BeginContext(339, 24, false);
#line 14 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(365, 53, true);
            WriteLiteral("    <dl>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(419, 46, false);
#line 17 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdArticulo));

#line default
#line hidden
            EndContext();
            BeginContext(465, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(527, 42, false);
#line 20 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdArticulo));

#line default
#line hidden
            EndContext();
            BeginContext(569, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(630, 46, false);
#line 23 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Referencia));

#line default
#line hidden
            EndContext();
            BeginContext(676, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(738, 42, false);
#line 26 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Referencia));

#line default
#line hidden
            EndContext();
            BeginContext(780, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(841, 47, false);
#line 29 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(888, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(950, 43, false);
#line 32 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(993, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1054, 42, false);
#line 35 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Minimo));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1158, 38, false);
#line 38 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Minimo));

#line default
#line hidden
            EndContext();
            BeginContext(1196, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1257, 42, false);
#line 41 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Maximo));

#line default
#line hidden
            EndContext();
            BeginContext(1299, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1361, 38, false);
#line 44 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Maximo));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1460, 42, false);
#line 47 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1564, 38, false);
#line 50 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 102, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-primary\" />\r\n    ");
            EndContext();
            BeginContext(1704, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d382fb1cfc9437d880e7e7dd38311ee", async() => {
                BeginContext(1752, 33, true);
                WriteLiteral("<i class=\"fa fa-table\"></i> Atras");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1789, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Articulo\Delete.cshtml"

}

#line default
#line hidden
            BeginContext(1796, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventarioWeb.Models.Articulo> Html { get; private set; }
    }
}
#pragma warning restore 1591

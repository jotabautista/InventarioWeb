#pragma checksum "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b317dda40c8bdb6264a49247d012870029dbad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimiento_Details), @"mvc.1.0.view", @"/Views/Movimiento/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movimiento/Details.cshtml", typeof(AspNetCore.Views_Movimiento_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b317dda40c8bdb6264a49247d012870029dbad5", @"/Views/Movimiento/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda3f3335e43b4c97e85daba220cbed09ffb0956", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimiento_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioWeb.Models.Movimiento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
  
    ViewData["Title"] = "Detalle";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 84, true);
            WriteLiteral("\r\n\r\n<h2>Movimiento</h2>\r\n<h4>Detalle</h4>\r\n<dl>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(217, 48, false);
#line 13 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.IdMovimiento));

#line default
#line hidden
            EndContext();
            BeginContext(265, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(315, 44, false);
#line 16 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayFor(model => model.IdMovimiento));

#line default
#line hidden
            EndContext();
            BeginContext(359, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(408, 41, false);
#line 19 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(449, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(499, 37, false);
#line 22 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(536, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(585, 40, false);
#line 25 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(625, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(675, 36, false);
#line 28 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(711, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(760, 42, false);
#line 31 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(802, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(852, 38, false);
#line 34 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
   Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(890, 235, true);
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Articulo</th>\r\n            <th>Almacen</th>\r\n            <th>Cantidad</th>\r\n            <th>Precio</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 48 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
         foreach (var item in Model.MovimientoDets)
        {
            string selectedRow = "";
            if (item.IdMovimiento == (int?)ViewData["IdMovimiento"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(1369, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1380, "\"", 1400, 1);
#line 55 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
WriteAttributeValue("", 1388, selectedRow, 1388, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1401, 37, true);
            WriteLiteral(">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1439, 55, false);
#line 57 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Articulo.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1550, 54, false);
#line 60 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Almacen.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1660, 43, false);
#line 63 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1759, 41, false);
#line 66 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(2443, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\Joel\Documents\GitHub\InventarioWeb\InventarioWeb\Views\Movimiento\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2469, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2495, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce2fe6d195d45f082033c465dbaf6f7", async() => {
                BeginContext(2541, 33, true);
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
            BeginContext(2578, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventarioWeb.Models.Movimiento> Html { get; private set; }
    }
}
#pragma warning restore 1591

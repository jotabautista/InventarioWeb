#pragma checksum "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25d04f0013c81d08bbc031e275ee80504c02a751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimiento_Edit), @"mvc.1.0.view", @"/Views/Movimiento/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movimiento/Edit.cshtml", typeof(AspNetCore.Views_Movimiento_Edit))]
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
#line 1 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\_ViewImports.cshtml"
using InventarioWeb;

#line default
#line hidden
#line 2 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\_ViewImports.cshtml"
using InventarioWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d04f0013c81d08bbc031e275ee80504c02a751", @"/Views/Movimiento/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda3f3335e43b4c97e85daba220cbed09ffb0956", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimiento_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioWeb.Models.Movimiento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MovimientoDet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 54, true);
            WriteLiteral("\r\n<h2>Movimiento</h2>\r\n<h4>Actualizar</h4>\r\n\r\n<hr />\r\n");
            EndContext();
#line 12 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
 using (Html.BeginForm("Edit", "Movimiento"))
{
    

#line default
#line hidden
            BeginContext(238, 24, false);
#line 14 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(266, 53, true);
            WriteLiteral("    <dl>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(320, 48, false);
#line 18 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.DisplayNameFor(model => model.IdMovimiento));

#line default
#line hidden
            EndContext();
            BeginContext(368, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(430, 44, false);
#line 21 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.DisplayFor(model => model.IdMovimiento));

#line default
#line hidden
            EndContext();
            BeginContext(474, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(535, 41, false);
#line 24 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(576, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(638, 36, false);
#line 27 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.EditorFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(674, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(735, 40, false);
#line 30 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(775, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(837, 35, false);
#line 33 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.EditorFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(872, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(933, 42, false);
#line 36 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(975, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1037, 37, false);
#line 39 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
       Write(Html.EditorFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 45, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(1119, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5783f2337b454f7c93bcd330a5e71df1", async() => {
                BeginContext(1210, 7, true);
                WriteLiteral("Agregar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                                                                WriteLiteral(ViewBag.IdMovimiento);

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
            BeginContext(1221, 265, true);
            WriteLiteral(@"
    </p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Articulo</th>
                <th>Almacen</th>
                <th>Cantidad</th>
                <th>Precio</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 55 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
             foreach (var item in Model.MovimientoDets)
            {
                string selectedRow = "";
                if (item.IdMovimiento == (int?)ViewData["IdMovimiento"])
                {
                    selectedRow = "success";
                }

#line default
#line hidden
            BeginContext(1758, 19, true);
            WriteLiteral("                <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1777, "\"", 1797, 1);
#line 62 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
WriteAttributeValue("", 1785, selectedRow, 1785, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1798, 53, true);
            WriteLiteral(">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1852, 55, false);
#line 64 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Articulo.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1987, 54, false);
#line 67 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Almacen.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2121, 43, false);
#line 70 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(2164, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2244, 41, false);
#line 73 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2364, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bd954c604fd4ee68ea9a7b53e532a79", async() => {
                BeginContext(2453, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                                                                              WriteLiteral(item.IdMovimientoDet);

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
            BeginContext(2461, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2489, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5809d9829b014a758727286f1272c47c", async() => {
                BeginContext(2580, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
                                                                                WriteLiteral(item.IdMovimientoDet);

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
            BeginContext(2590, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 80 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"
            }

#line default
#line hidden
            BeginContext(2657, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
            BeginContext(2691, 76, true);
            WriteLiteral("    <input type=\"submit\" value=\"Actualizar\" class=\"btn btn-primary\" />\r\n    ");
            EndContext();
            BeginContext(2767, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5279cd576f714f79a01e27eea5765b2a", async() => {
                BeginContext(2815, 33, true);
                WriteLiteral("<i class=\"fa fa-table\"></i> Atras");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2852, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\Users\jbautista.DPH\Documents\Visual Studio 2017\Projects\InventarioWeb\InventarioWeb\Views\Movimiento\Edit.cshtml"

}

#line default
#line hidden
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
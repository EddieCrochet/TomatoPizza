#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c46df9f42515740c8660b7224661917aa7778f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizzas_Index), @"mvc.1.0.view", @"/Views/Pizzas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizzas/Index.cshtml", typeof(AspNetCore.Views_Pizzas_Index))]
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
#line 1 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe;

#line default
#line hidden
#line 2 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c46df9f42515740c8660b7224661917aa7778f0d", @"/Views/Pizzas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizzas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TomatoPizzaCafe.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(104, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(141, 1225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5204006dc4d549a0897d471e60ebc3b7", async() => {
                BeginContext(147, 115, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>");
                EndContext();
                BeginContext(263, 17, false);
#line 11 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(280, 1079, true);
                WriteLiteral(@" - Menu</title>
    <style>
        .menu-body {
            max-width: 680px;
            margin: 0 auto;
            display: block;
            color: rgb(92, 92, 92);
        }

        .menu-section {
            margin-bottom: 80px;
        }

        .menu-section-title {
            font-family: georgia;
            font-size: 50px;
            display: block;
            font-weight: normal;
            margin: 20px 0;
            text-align: Center;
        }

        .menu-item {
            margin: 35px 0;
            font-size: 18px;
        }

        .menu-item-name {
            font-family: helvetica;
            font-weight: bold;
            border-bottom: 2px dotted rgb(213, 213, 213);
        }

        .menu-item-description {
            font-style: italic;
            font-size: .9em;
            line-height: 1.5em;
        }

        .menu-item-price {
            float: right;
            font-weight: bold;
            font-family: arial;
  ");
                WriteLiteral("          margin-top: -22px;\r\n        }\r\n    </style>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1366, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1368, 6860, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22a13d82d17844268ac88a2a1ccf5238", async() => {
                BeginContext(1374, 218, true);
                WriteLiteral("\r\n    <div class=\"menu-body\">\r\n        <!-- Section starts: Appetizers -->\r\n        <div class=\"menu-section\">\r\n            <h2 class=\"menu-section-title\">TOMATO PIZZA CAFE MENU</h2>\r\n            <!-- Item starts -->\r\n");
                EndContext();
#line 64 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1649, 203, true);
                WriteLiteral("                <table class=\"table\">\r\n                    <tr>\r\n                        <td class=\"menu-item\">\r\n                            <div class=\"menu-item-name\">\r\n                                ");
                EndContext();
                BeginContext(1853, 39, false);
#line 70 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
                EndContext();
                BeginContext(1892, 130, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"menu-item-price\">\r\n                                $");
                EndContext();
                BeginContext(2023, 49, false);
#line 73 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
                            Write(Html.DisplayFor(modelItem => item.EightInchPrice));

#line default
#line hidden
                EndContext();
                BeginContext(2072, 136, true);
                WriteLiteral("+\r\n                            </div>\r\n                            <div class=\"menu-item-description\">\r\n                                ");
                EndContext();
                BeginContext(2209, 46, false);
#line 76 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(2255, 105, true);
                WriteLiteral("\r\n                            </div>\r\n                            <div>\r\n                                ");
                EndContext();
                BeginContext(2360, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08053c2bf13f47da8dca7922ca1a7dff", async() => {
                    BeginContext(2413, 7, true);
                    WriteLiteral("Details");
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
#line 79 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
                                                          WriteLiteral(item.PizzaID);

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
                BeginContext(2424, 74, true);
                WriteLiteral("\r\n                                <br />\r\n                                ");
                EndContext();
                BeginContext(2498, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da8c13cfc0843f59dba91f0e38fc472", async() => {
                    BeginContext(2549, 5, true);
                    WriteLiteral("Order");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 81 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
                                                        WriteLiteral(item.PizzaID);

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
                BeginContext(2558, 122, true);
                WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n");
                EndContext();
#line 86 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Pizzas\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2695, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(8152, 69, true);
                WriteLiteral("\r\n        </div>\r\n        <!-- Section ends: Drinks -->\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(8228, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TomatoPizzaCafe.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591

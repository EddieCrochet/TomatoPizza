#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd20cb64a1c3507f0e449e92f7633c7538b3c136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd20cb64a1c3507f0e449e92f7633c7538b3c136", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TomatoPizzaCafe.Models.OrderItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pizzas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 164, true);
            WriteLiteral("\r\n<h1 style=\"font-family: \'Brush Script MT\'; font-size: 40px; text-align:center; color: brown\">My Order</h1>\r\n<style>\r\n\r\n    html {\r\n        background-image: url(\'");
            EndContext();
            BeginContext(311, 38, false);
#line 12 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                          Write(Url.Content("~/images/tomatocafe.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(349, 298, true);
            WriteLiteral(@"');
        background-position: center;
        background-repeat: no-repeat;
        background-size: auto;
        height: 50%;
    }

    footer {
        position: fixed;
        bottom: 0;
    }
</style>
<h4>Details</h4>
<hr />
<table class=""table"">
    <thead>
        <tr>
");
            EndContext();
#line 29 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
              
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(727, 54, true);
            WriteLiteral("                    <th>\r\n                        <h4>");
            EndContext();
            BeginContext(782, 23, false);
#line 33 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                       Write(item.Order.CustomerName);

#line default
#line hidden
            EndContext();
            BeginContext(805, 84, true);
            WriteLiteral("</h4>\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(890, 42, false);
#line 36 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(932, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1012, 40, false);
#line 39 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 162, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Type\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1215, 41, false);
#line 45 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 87, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Total: $");
            EndContext();
            BeginContext(1344, 21, false);
#line 48 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                           Write(item.Order.TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1365, 29, true);
            WriteLiteral("\r\n                    </th>\r\n");
            EndContext();
#line 50 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                    break;
                }
            

#line default
#line hidden
            BeginContext(1456, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1547, 87, true);
            WriteLiteral("            <tr>\r\n                <td></td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1635, 41, false);
#line 61 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 74, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    Total: ");
            EndContext();
            BeginContext(1751, 39, false);
#line 64 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                      Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 62, true);
            WriteLiteral(" <span>\"</span>\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 67 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                      
                        if (item.Pizza != null)
                        {
                            

#line default
#line hidden
            BeginContext(1981, 15, false);
#line 70 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                       Write(item.Pizza.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 36, true);
            WriteLiteral("                            <br />\r\n");
            EndContext();
#line 72 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(2147, 31, false);
#line 75 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                       Write(item.MakeYourOwn.NumberToppings);

#line default
#line hidden
            EndContext();
            BeginContext(2178, 29, true);
            WriteLiteral("<span>-Topping Pizza</span>\r\n");
            EndContext();
#line 76 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(2257, 43, true);
            WriteLiteral("                <td>\r\n                    $");
            EndContext();
            BeginContext(2301, 40, false);
#line 79 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2570, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2590, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0717c8c292844647a5a42131652024d6", async() => {
                BeginContext(2646, 6, true);
                WriteLiteral("Delete");
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
#line 84 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
                                             WriteLiteral(item.OrderItemID);

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
            BeginContext(2656, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 87 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2711, 35, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2746, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d42bd97612647d0b7201fe783bf2f49", async() => {
                BeginContext(2792, 12, true);
                WriteLiteral("Back to Menu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2808, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TomatoPizzaCafe.Models.OrderItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

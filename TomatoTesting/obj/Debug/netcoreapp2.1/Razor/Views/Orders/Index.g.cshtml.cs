#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718fbd9848c07a3fa9c8b857d22a1885df656a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Index.cshtml", typeof(AspNetCore.Views_Orders_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718fbd9848c07a3fa9c8b857d22a1885df656a3f", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TomatoPizzaCafe.Models.OrderItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 162, true);
            WriteLiteral("\r\n<h1 style=\"font-family: \'Brush Script MT\'; font-size: 40px; text-align:center; color: brown\">Orders</h1>\r\n<style>\r\n\r\n    html {\r\n        background-image: url(\'");
            EndContext();
            BeginContext(307, 38, false);
#line 12 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                          Write(Url.Content("~/images/tomatocafe.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(345, 231, true);
            WriteLiteral("\');\r\n        background-position: center;\r\n        background-repeat: no-repeat;\r\n        background-size: auto;\r\n        height: 50%;\r\n    }\r\n\r\n    footer {\r\n        position: fixed;\r\n        bottom: 0;\r\n    }\r\n</style>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(576, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01d1b24dfdf84653b2e20344c02d3f57", async() => {
                BeginContext(599, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(613, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(706, 54, false);
#line 31 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(760, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(816, 49, false);
#line 34 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Order.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(865, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(921, 42, false);
#line 37 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Number));

#line default
#line hidden
            EndContext();
            BeginContext(963, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1019, 40, false);
#line 40 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 114, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Type\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1174, 41, false);
#line 46 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1350, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1411, 53, false);
#line 56 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Order.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1532, 42, false);
#line 59 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1642, 41, false);
#line 62 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1751, 39, false);
#line 65 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 62, true);
            WriteLiteral(" <span>\"</span>\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 68 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                      
                        if (item.Pizza != null)
                        {
                            

#line default
#line hidden
            BeginContext(1981, 15, false);
#line 71 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                       Write(item.Pizza.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 36, true);
            WriteLiteral("                            <br />\r\n");
            EndContext();
#line 73 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(2147, 31, false);
#line 76 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                       Write(item.MakeYourOwn.NumberToppings);

#line default
#line hidden
            EndContext();
            BeginContext(2178, 29, true);
            WriteLiteral("<span>-Topping Pizza</span>\r\n");
            EndContext();
#line 77 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(2257, 66, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    $");
            EndContext();
            BeginContext(2324, 40, false);
#line 81 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2364, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(2708, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 89 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2738, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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

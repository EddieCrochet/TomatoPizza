#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9144352cb5feb4be8efa7183a1146e35c2349fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MakeYourOwns_Index), @"mvc.1.0.view", @"/Views/MakeYourOwns/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MakeYourOwns/Index.cshtml", typeof(AspNetCore.Views_MakeYourOwns_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9144352cb5feb4be8efa7183a1146e35c2349fe", @"/Views/MakeYourOwns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_MakeYourOwns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TomatoPizzaCafe.Models.MakeYourOwn>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 85, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <style>\r\n\r\n    html {\r\n        background-image: url(\'");
            EndContext();
            BeginContext(232, 38, false);
#line 12 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                          Write(Url.Content("~/images/tomatocafe.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(270, 366, true);
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
</div>

<h1 style=""font-family: 'Brush Script MT'; font-size: 40px; text-align:center; color: brown"">Make Your Own Pizza</h1>

<p>
    ");
            EndContext();
            BeginContext(636, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bb9207654734f45ae0c4ae1bbe77e9b", async() => {
                BeginContext(659, 16, true);
                WriteLiteral("Create New Pizza");
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
            BeginContext(679, 155, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Toppings\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(835, 41, false);
#line 38 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sauce));

#line default
#line hidden
            EndContext();
            BeginContext(876, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(932, 41, false);
#line 41 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(973, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1091, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 50 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                  
                    if (item.Topping1 != null)
                    {
                        

#line default
#line hidden
            BeginContext(1239, 43, false);
#line 53 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 55 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                    }
                    if (item.Topping2 != null)
                    {
                        

#line default
#line hidden
            BeginContext(1435, 43, false);
#line 58 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 60 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                    }
                    if (item.Topping3 != null)
                    {
                        

#line default
#line hidden
            BeginContext(1631, 43, false);
#line 63 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 65 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                    }
                    if (item.Topping4 != null)
                    {
                        

#line default
#line hidden
            BeginContext(1827, 43, false);
#line 68 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 70 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                    }
                    if (item.Topping5 != null)
                    {
                        

#line default
#line hidden
            BeginContext(2023, 43, false);
#line 73 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 32, true);
            WriteLiteral("                        <br />\r\n");
            EndContext();
#line 75 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                    }
                    if (item.Topping6 != null)
                    {
                        

#line default
#line hidden
            BeginContext(2219, 43, false);
#line 78 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping6));

#line default
#line hidden
            EndContext();
#line 78 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                                                                    
                    }
                

#line default
#line hidden
            BeginContext(2306, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2360, 40, false);
#line 83 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sauce));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2456, 40, false);
#line 86 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2551, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40f0e5948a244e1ea50ddd759cdd57bc", async() => {
                BeginContext(2608, 5, true);
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
#line 89 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                                        WriteLiteral(item.MakeYourOwnID);

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
            BeginContext(2617, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2635, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6ce9e518d234790996392984666cc5d", async() => {
                BeginContext(2691, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                                       WriteLiteral(item.MakeYourOwnID);

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
            BeginContext(2699, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2719, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10eeab725b4e42b78a62f35aee0a13ab", async() => {
                BeginContext(2778, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                                          WriteLiteral(item.MakeYourOwnID);

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
            BeginContext(2789, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2809, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97ccb633270491c8f1acd9b17ed3dcf", async() => {
                BeginContext(2867, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
                                         WriteLiteral(item.MakeYourOwnID);

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
            BeginContext(2877, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 95 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\MakeYourOwns\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2916, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TomatoPizzaCafe.Models.MakeYourOwn>> Html { get; private set; }
    }
}
#pragma warning restore 1591

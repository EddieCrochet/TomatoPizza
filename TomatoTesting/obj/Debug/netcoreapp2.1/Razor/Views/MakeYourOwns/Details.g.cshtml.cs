#pragma checksum "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1575025cd933bb018f2e8a63319d8c125ef0a696"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MakeYourOwns_Details), @"mvc.1.0.view", @"/Views/MakeYourOwns/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MakeYourOwns/Details.cshtml", typeof(AspNetCore.Views_MakeYourOwns_Details))]
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
#line 1 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe;

#line default
#line hidden
#line 2 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\_ViewImports.cshtml"
using TomatoPizzaCafe.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1575025cd933bb018f2e8a63319d8c125ef0a696", @"/Views/MakeYourOwns/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_MakeYourOwns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TomatoPizzaCafe.Models.MakeYourOwn>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 198, true);
            WriteLiteral("\r\n<h1 style=\"font-family: \'Brush Script MT\'; font-size: 40px; text-align:center; color: brown\">Make Your Own Pizza</h1>\r\n\r\n<div>\r\n    <h4>Details</h4>\r\n    <hr />\r\n\r\n    <dl class=\"dl-horizontal\">\r\n");
            EndContext();
#line 15 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
          
            if (Model.Topping1 != null)
            {

#line default
#line hidden
            BeginContext(401, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(444, 48, false);
#line 19 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(492, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(560, 44, false);
#line 22 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(604, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 24 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping2 != null)
            {

#line default
#line hidden
            BeginContext(700, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(743, 48, false);
#line 28 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(791, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(859, 44, false);
#line 31 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(903, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 33 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping3 != null)
            {

#line default
#line hidden
            BeginContext(999, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(1042, 48, false);
#line 37 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1158, 44, false);
#line 40 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 42 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping4 != null)
            {

#line default
#line hidden
            BeginContext(1298, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(1341, 48, false);
#line 46 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1457, 44, false);
#line 49 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 51 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }
            if (Model.Topping5 != null)
            {
                

#line default
#line hidden
            BeginContext(1614, 48, false);
#line 54 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayNameFor(modelItem => Model.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 44, false);
#line 55 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Topping5));

#line default
#line hidden
            EndContext();
#line 55 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
                                                             
            }
            if (Model.Topping6 != null)
            {

#line default
#line hidden
            BeginContext(1798, 42, true);
            WriteLiteral("                <dt>\r\n                    ");
            EndContext();
            BeginContext(1841, 48, false);
#line 60 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayNameFor(modelItem => Model.Topping6));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1957, 44, false);
#line 63 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Topping6));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 25, true);
            WriteLiteral("\r\n                </dd>\r\n");
            EndContext();
#line 65 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2041, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(2076, 41, false);
#line 67 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Sauce));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2173, 37, false);
#line 70 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayFor(model => model.Sauce));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2266, 41, false);
#line 73 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2363, 37, false);
#line 76 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
           Write(Html.DisplayFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
            BeginContext(2436, 19, true);
            WriteLiteral("        </dl>\r\n    ");
            EndContext();
            BeginContext(2455, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "353efdd74bd64130994f39420bc95250", async() => {
                BeginContext(2512, 4, true);
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
#line 80 "C:\Users\eddie\Documents\ACA\321.1_DotNet\TomatoPizza\TomatoPizza\TomatoTesting\Views\MakeYourOwns\Details.cshtml"
                           WriteLiteral(Model.MakeYourOwnID);

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
            BeginContext(2520, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2528, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5371126a5b465b92e9816e987a1101", async() => {
                BeginContext(2550, 12, true);
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
            BeginContext(2566, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TomatoPizzaCafe.Models.MakeYourOwn> Html { get; private set; }
    }
}
#pragma warning restore 1591

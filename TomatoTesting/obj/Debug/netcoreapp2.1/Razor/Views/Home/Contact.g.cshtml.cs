#pragma checksum "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "309845f3bc223d5d796b214375e0d7b38098edf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309845f3bc223d5d796b214375e0d7b38098edf3", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07e1cba9e7e7f8e0d7a153eca4a64ef19cba20e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(81, 19, false);
#line 5 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 188, true);
            WriteLiteral("</h3>\r\n\r\n<h1 style=\"font-family: \'Brush Script MT\'; font-size: 36px; color: brown\">Find Us</h1>\r\n<main>\r\n<div class=\"container\">\r\n    <style>\r\n\r\n    html {\r\n        background-image: url(\'");
            EndContext();
            BeginContext(289, 38, false);
#line 13 "C:\Users\compf\source\repos\TomatoTesting\TomatoTesting\Views\Home\Contact.cshtml"
                          Write(Url.Content("~/images/tomatocafe.jpg"));

#line default
#line hidden
            EndContext();
            BeginContext(327, 867, true);
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

<address>
    The Tomato Cafe<br />
    15 Collegeview Avenue

    Poughkeepsie, NY 12603<br />

    <abbr title=""Phone"">P:</abbr>
    845-473-7779
</address>
<h3 style=""font-family: 'Brush Script MT'; font-size: 36px; color:brown"">Hours</h3>
    <h5>Monday - Thursday 11am - 9pm, 

    Friday & Saturday 11am - 10pm,

    Sunday CLOSED</h5>


    <address>
        <strong>Questions:</strong> <a href=""mailto:Questions@tomatocafe.com"">Questions@tomatocafe.com</a><br />
        <strong>Marketing:</strong> <a href=""mailto:Marketing@tomatocafe.com"">Marketing@tomatocafe.com</a>
    </address>
    </main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
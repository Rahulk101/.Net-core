#pragma checksum "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba6c4bf51d3899fb5902c6533af2d619d18e5cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CreditCardRates_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CreditCardRates/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 1 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\_ViewImports.cshtml"
using Globomantics.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\_ViewImports.cshtml"
using Globomantics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\_ViewImports.cshtml"
using Globomantics.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba6c4bf51d3899fb5902c6533af2d619d18e5cae", @"/Views/Shared/Components/CreditCardRates/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd840efc1be33182954f26f8c1f4d165492d068e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CreditCardRates_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Globomantics.Components.CreditCardWidgetVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h3 class=\"card-title\">");
#nullable restore
#line 5 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml"
                          Write(Model.WidgetTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"card-text\">");
#nullable restore
#line 6 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml"
                        Write(Model.WidgetSubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 9 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml"
         foreach (var creditRate in Model.Rates)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">");
#nullable restore
#line 11 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml"
                                   Write(creditRate.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml"
                                                      Write(creditRate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n");
#nullable restore
#line 12 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Shared\Components\CreditCardRates\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <div class=\"card-body\">\r\n        <p>Learn how to get 3% back on everything.</p>\r\n        <a href=\"#\" class=\"card-link\">Learn More</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Globomantics.Components.CreditCardWidgetVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
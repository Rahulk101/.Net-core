#pragma checksum "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Property\Quote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ddd28ec8436ecea252c0a71f25ea8dfa9c60c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Property_Quote), @"mvc.1.0.view", @"/Views/Property/Quote.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ddd28ec8436ecea252c0a71f25ea8dfa9c60c6", @"/Views/Property/Quote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd840efc1be33182954f26f8c1f4d165492d068e", @"/Views/_ViewImports.cshtml")]
    public class Views_Property_Quote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Banner", async() => {
                WriteLiteral("\n    <div class=\"jumbotron jumbotron-fluid jumbotron-blue\">\n        <div class=\"container\">\n            <h1 class=\"display-4\">Property Insurance</h1>\n            <p class=\"lead\">Protect your home.</p>\n        </div>\n    </div>\n");
            }
            );
            WriteLiteral("\n");
            DefineSection("SideNav", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 11 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Property\Quote.cshtml"
Write(Html.Partial("LeftNav"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            WriteLiteral("<p>After you complete this form you should receive an email with your quote shortly after. Please allow up to 1 hour to receive your quote.</p>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ddd28ec8436ecea252c0a71f25ea8dfa9c60c64591", async() => {
                WriteLiteral("\n    <hr class=\"featurette-divider-thin\">\n\n    <div class=\"form-group\">\n        <label for=\"exampleFormControlSelect1\">Property Type</label>\n        <select class=\"form-control\" id=\"exampleFormControlSelect1\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ddd28ec8436ecea252c0a71f25ea8dfa9c60c65083", async() => {
                    WriteLiteral("Primary Residence");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ddd28ec8436ecea252c0a71f25ea8dfa9c60c66118", async() => {
                    WriteLiteral("Rental");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ddd28ec8436ecea252c0a71f25ea8dfa9c60c67142", async() => {
                    WriteLiteral("Vacation");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </select>
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Monthly Rent</label>
        <input type=""text"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""Monthly Rent"">
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Year Built</label>
        <input type=""text"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""Year Built"">
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Number of Residents</label>
        <input type=""text"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""Residents"">
    </div>
    <div class=""form-group"">
        <label for=""exampleFormControlInput1"">Area Code</label>
        <input type=""text"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""Area Code"">
    </div>

    ");
#nullable restore
#line 43 "D:\.Net core\Improving_.netCore_apps\Globomantics\Views\Property\Quote.cshtml"
Write(Html.Partial("Person"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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

#pragma checksum "/home/owner/dojo/c#colections/dojo-survey/dojo-survey/Views/dojo_survey/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c2b2f88a53eb996d398cdf4857056a8a5885bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dojo_survey_Result), @"mvc.1.0.view", @"/Views/dojo_survey/Result.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2b2f88a53eb996d398cdf4857056a8a5885bbd", @"/Views/dojo_survey/Result.cshtml")]
    public class Views_dojo_survey_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dojo_survey.Models.Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("    <div>\n \n    <h1>Survey results</h1>\n  \n\n  \n    <h3>Name: ");
#nullable restore
#line 9 "/home/owner/dojo/c#colections/dojo-survey/dojo-survey/Views/dojo_survey/Result.cshtml"
         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    \n    <h3>Location: ");
#nullable restore
#line 11 "/home/owner/dojo/c#colections/dojo-survey/dojo-survey/Views/dojo_survey/Result.cshtml"
             Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Language: ");
#nullable restore
#line 12 "/home/owner/dojo/c#colections/dojo-survey/dojo-survey/Views/dojo_survey/Result.cshtml"
             Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Comment: ");
#nullable restore
#line 13 "/home/owner/dojo/c#colections/dojo-survey/dojo-survey/Views/dojo_survey/Result.cshtml"
            Write(Model.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n\n        \n\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dojo_survey.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591

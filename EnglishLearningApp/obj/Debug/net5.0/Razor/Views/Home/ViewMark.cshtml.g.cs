#pragma checksum "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64be58bcf63e557aa7f452491b3fd91a79a6a2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewMark), @"mvc.1.0.view", @"/Views/Home/ViewMark.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\_ViewImports.cshtml"
using EnglishLearningApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\_ViewImports.cshtml"
using EnglishLearningApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64be58bcf63e557aa7f452491b3fd91a79a6a2d1", @"/Views/Home/ViewMark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3c8a5f883b3c09a5a5154703dc57ec35f2e083", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewMark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">NO</th>
                <th scope=""col"">Lesson</th>
                <th scope=""col"">Level</th>
                <th scope=""col"">Status</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
             foreach (var j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"nr td-actions text-center\"></td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
                   Write(j.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
                   Write(j.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 24 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
                         if (j.Status == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-info\">Passed</button>\r\n");
#nullable restore
#line 27 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
                        }
                        else if (j.Status == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-danger\">Not Pass</button>\r\n");
#nullable restore
#line 31 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
                        }
                        else if (j.Status == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button disabled type=\"button\" class=\"btn btn-warning\">Pending</button>\r\n");
#nullable restore
#line 35 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\ViewMark.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var a = document.getElementsByClassName(\"nr\");\r\n    for (var i = 0; i < a.length; i++) {\r\n        a[i].innerHTML = (i + 1);\r\n    }\r\n</script>");
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

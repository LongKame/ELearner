#pragma checksum "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c7ea8d70d31225ca35a8d73d79575920755d8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EnrollLevel), @"mvc.1.0.view", @"/Views/Home/EnrollLevel.cshtml")]
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
#line 1 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\_ViewImports.cshtml"
using LearningApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\_ViewImports.cshtml"
using LearningApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c7ea8d70d31225ca35a8d73d79575920755d8a", @"/Views/Home/EnrollLevel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b62e7198bdb0871c4ea4b7d1ae381afc06b8e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EnrollLevel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LearningApp.Models.VocabInLesson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .row-padding {
        display: inline-block;
        margin-top: 20px;
        border: 1px solid rgb(37, 150, 190);
        font-size: 20px;
        border-radius: 10px;
        width: 70%;
    }

    .column {
        float: left;
        width: 20%;
        padding: 10px;
        height: 200px;
        margin-left: 5%;
    }
</style>
<a href=""/Home/TestLesson/1"">Test</a>
<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c7ea8d70d31225ca35a8d73d79575920755d8a4323", async() => {
                WriteLiteral("\r\n        <input type=\"text\" class=\"form-control\" placeholder=\"Search...\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <table class=""table"">
        <thead>
            <tr>
                <th>NO</th>
                <th>Word</th>
                <th>Image</th>
                <th>Pronunciation</th>
                <th>Meaning</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
             foreach (VocabInLesson j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"nr td-actions text-center\"></td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                   Write(j.Word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1162, "\"", 1176, 1);
#nullable restore
#line 47 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 1168, j.Image, 1168, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"120\" height=\"120\"></td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                   Write(j.Pronunciation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                   Write(j.Meaning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 58 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
          
            int numberPage = (int)ViewBag.numberPage;
            int pageCurrent = ViewBag.pageCurrent;

            if (pageCurrent > 1)
            {
                int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1749, "\"", 1770, 2);
            WriteAttributeValue("", 1756, "?page=", 1756, 6, true);
#nullable restore
#line 66 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 1762, prePage, 1762, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                        <span class=\"sr-only\">Previous</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 71 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
            }

            int i;
            for (i = 1; i < numberPage; i++)
            {
                if (i == pageCurrent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2198, "\"", 2213, 2);
            WriteAttributeValue("", 2205, "?page=", 2205, 6, true);
#nullable restore
#line 78 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 2211, i, 2211, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 79 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 2332, "\"", 2347, 2);
            WriteAttributeValue("", 2339, "?page=", 2339, 6, true);
#nullable restore
#line 82 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 2345, i, 2345, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 83 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
                }
            }

            if (pageCurrent >= 1 && pageCurrent < numberPage - 1)
            {
                int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2609, "\"", 2631, 2);
            WriteAttributeValue("", 2616, "?page=", 2616, 6, true);
#nullable restore
#line 90 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
WriteAttributeValue("", 2622, nextPage, 2622, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                        <span class=\"sr-only\">Next</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 95 "C:\Users\Computer\source\repos\LearningApp\LearningApp\Views\Home\EnrollLevel.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n<script type=\"text/javascript\">\r\n    var a = document.getElementsByClassName(\"nr\");\r\n    for (var i = 0; i < a.length; i++) {\r\n        a[i].innerHTML = (i + 1);\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LearningApp.Models.VocabInLesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591

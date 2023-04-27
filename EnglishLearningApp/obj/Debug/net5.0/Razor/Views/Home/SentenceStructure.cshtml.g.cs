#pragma checksum "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c58322c498c0439352c644c89d1b834a578b5209"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SentenceStructure), @"mvc.1.0.view", @"/Views/Home/SentenceStructure.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58322c498c0439352c644c89d1b834a578b5209", @"/Views/Home/SentenceStructure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3c8a5f883b3c09a5a5154703dc57ec35f2e083", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SentenceStructure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EnglishLearningApp.DTO.SentenceStructureDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
  
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

<div class=""container"">
");
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>NO</th>\r\n                <th>Lesson</th>\r\n                <th>Sentence</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
             foreach (var j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"nr td-actions text-center\"></td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
                   Write(j.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
                   Write(j.Sentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 54 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
          
            int numberPage = (int)ViewBag.numberPage;
            int pageCurrent = ViewBag.pageCurrent;

            if (pageCurrent > 1)
            {
                int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1536, "\"", 1557, 2);
            WriteAttributeValue("", 1543, "?page=", 1543, 6, true);
#nullable restore
#line 62 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
WriteAttributeValue("", 1549, prePage, 1549, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                        <span class=\"sr-only\">Previous</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 67 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
            }

            int i;
            for (i = 1; i < numberPage + 1; i++)
            {
                if (i == pageCurrent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1989, "\"", 2004, 2);
            WriteAttributeValue("", 1996, "?page=", 1996, 6, true);
#nullable restore
#line 74 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
WriteAttributeValue("", 2002, i, 2002, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 75 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 2123, "\"", 2138, 2);
            WriteAttributeValue("", 2130, "?page=", 2130, 6, true);
#nullable restore
#line 78 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
WriteAttributeValue("", 2136, i, 2136, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 79 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
                }
            }

            if (pageCurrent >= 1 && pageCurrent < numberPage)
            {
                int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2396, "\"", 2418, 2);
            WriteAttributeValue("", 2403, "?page=", 2403, 6, true);
#nullable restore
#line 86 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
WriteAttributeValue("", 2409, nextPage, 2409, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                        <span class=\"sr-only\">Next</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 91 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\SentenceStructure.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EnglishLearningApp.DTO.SentenceStructureDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a540ae460c8a12c26274666b0e62976b2cd0957"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WordManagement), @"mvc.1.0.view", @"/Views/Home/WordManagement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a540ae460c8a12c26274666b0e62976b2cd0957", @"/Views/Home/WordManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3c8a5f883b3c09a5a5154703dc57ec35f2e083", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WordManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<a style=""margin-top: 2%"" href=""/Home/AddNewWord"" class=""btn btn-success"">Add new word</a>
<div class=""table-responsive"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">NO</th>
                <th scope=""col"">Lesson</th>
                <th scope=""col"">Image</th>
                <th scope=""col"">Word</th>
                <th scope=""col"">Pronunciation</th>
                <th scope=""col"">Meaning</th>
                <th scope=""col"">Synonymous</th>
                <th scope=""col"">Antonymous</th>
                <th scope=""col"">Action</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
             foreach (var j in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"nr td-actions text-center\"></td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                   Write(j.Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img style=\"height:100px;width:80px\"");
            BeginWriteAttribute("src", " src=\"", 1027, "\"", 1041, 1);
#nullable restore
#line 29 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
WriteAttributeValue("", 1033, j.Image, 1033, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                   Write(j.Word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                   Write(j.Pronunciation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                   Write(j.Meaning);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                   Write(j.Synonymous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                   Write(j.Antonymous);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1292, "\"", 1321, 2);
            WriteAttributeValue("", 1299, "/Home/UpdateWord/", 1299, 17, true);
#nullable restore
#line 35 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
WriteAttributeValue("", 1316, j.Id, 1316, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 44 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
          
            int numberPage = (int)ViewBag.numberPage;
            int pageCurrent = ViewBag.pageCurrent;

            if (pageCurrent > 1)
            {
                int prePage = pageCurrent - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1791, "\"", 1812, 2);
            WriteAttributeValue("", 1798, "?page=", 1798, 6, true);
#nullable restore
#line 52 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
WriteAttributeValue("", 1804, prePage, 1804, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                        <span aria-hidden=\"true\">&laquo;</span>\r\n                        <span class=\"sr-only\">Previous</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 57 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 2240, "\"", 2255, 2);
            WriteAttributeValue("", 2247, "?page=", 2247, 6, true);
#nullable restore
#line 64 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
WriteAttributeValue("", 2253, i, 2253, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                                                                                 Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\"><a");
            BeginWriteAttribute("href", " href=\"", 2374, "\"", 2389, 2);
            WriteAttributeValue("", 2381, "?page=", 2381, 6, true);
#nullable restore
#line 68 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
WriteAttributeValue("", 2387, i, 2387, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 69 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
                }
            }

            if (pageCurrent >= 1 && pageCurrent < numberPage - 1)
            {
                int nextPage = pageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\">\r\n                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2651, "\"", 2673, 2);
            WriteAttributeValue("", 2658, "?page=", 2658, 6, true);
#nullable restore
#line 76 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
WriteAttributeValue("", 2664, nextPage, 2664, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                        <span aria-hidden=\"true\">&raquo;</span>\r\n                        <span class=\"sr-only\">Next</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 81 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\WordManagement.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n\r\n<script type=\"text/javascript\">\r\n    var a = document.getElementsByClassName(\"nr\");\r\n    for (var i = 0; i < a.length; i++) {\r\n        a[i].innerHTML = (i + 1);\r\n    }\r\n</script>");
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

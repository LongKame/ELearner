#pragma checksum "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "913917f5f81a6793744d45fb0d5d1043195f3995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"913917f5f81a6793744d45fb0d5d1043195f3995", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3c8a5f883b3c09a5a5154703dc57ec35f2e083", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
  string? username = Accessor.HttpContext.Session.GetString("username");
    string? type = Accessor.HttpContext.Session.GetString("role");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "913917f5f81a6793744d45fb0d5d1043195f39955069", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 10 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ELearning</title>\r\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\'>\r\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\'>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "913917f5f81a6793744d45fb0d5d1043195f39955960", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "913917f5f81a6793744d45fb0d5d1043195f39957843", async() => {
                WriteLiteral(@"
    <nav class=""mnb navbar navbar-default navbar-fixed-top"" style=""background-color: #f6f8fc;"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar""
                        aria-expanded=""false"" aria-controls=""navbar"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <i class=""ic fa fa-bars""></i>
                </button>
                <div style=""padding: 15px 0;"">
                    <a href=""#"" id=""msbo""><i class=""ic fa fa-bars""></i></a>
                </div>
            </div>
            <div id=""navbar"" class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""#"">En</a></li>
");
#nullable restore
#line 31 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                     if (username != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"dropdown\">\r\n                            <a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\" role=\"button\" aria-haspopup=\"true\"\r\n                               aria-expanded=\"false\">");
#nullable restore
#line 35 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                                                Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<span class=""caret""></span></a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""#"">Settings</a></li>
                                <li><a href=""#"">Upgrade</a></li>
                                <li><a href=""#"">Help</a></li>
                                <li role=""separator"" class=""divider""></li>
                                <li><a href=""/Home/Logout"">Logout</a></li>
                            </ul>
                        </li>
");
#nullable restore
#line 44 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                     if (username == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li><a href=\"/Home/Login\"><i class=\"fa fa-sign-in\"></i></a></li>\r\n");
#nullable restore
#line 48 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <li><a href=""#""><i class=""fa fa-bell-o""></i></a></li>
                    <li><a href=""#""><i class=""fa fa-comment-o""></i></a></li>
                </ul>
            </div>
        </div>
    </nav>

    <div class=""msb"" id=""msb"">
        <nav class=""navbar navbar-default"" role=""navigation"">
            <div class=""navbar-header"" style=""background-color: #f6f8fc;"">
                <div class=""brand-wrapper"">
                    <div class=""brand-name-wrapper"">
                        <a class=""navbar-brand"" href=""#"">
                            <img style=""margin-top: -10%;""
                                 src=""https://dc-cdn.s3-ap-southeast-1.amazonaws.com/dc-Cover-6nud40jk3p2r9tbl0ldlgb2nk2-20160817154902.Medi.jpeg""
                                 width=""150"" height=""50"">
                        </a>
                    </div>
                </div>
            </div>

            <div class=""side-menu-container"" style=""background-color: #f6f8fc;"">

");
#nullable restore
#line 72 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                 if (type == "2")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul class=\"nav navbar-nav\">\r\n\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3702, "\"", 3750, 1);
#nullable restore
#line 76 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3710, ViewBag.Active == "5" ? "active" : "", 3710, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/Index\"><i class=\"fa fa-dashboard\"></i>Home</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3847, "\"", 3895, 1);
#nullable restore
#line 77 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3855, ViewBag.Active == "6" ? "active" : "", 3855, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/ViewMark\"><i class=\"fa fa-puzzle-piece\"></i>Mark</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 3998, "\"", 4046, 1);
#nullable restore
#line 78 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4006, ViewBag.Active == "7" ? "active" : "", 4006, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/SentenceStructure\"><i class=\"fa fa-building-o\"></i>Sentence Structure</a></li>\r\n\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 116 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 119 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                 if (type == "1")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul class=\"nav navbar-nav\">\r\n\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 6781, "\"", 6829, 1);
#nullable restore
#line 123 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6789, ViewBag.Active == "1" ? "active" : "", 6789, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/AccountManagement\"><i class=\"fa fa-dashboard\"></i>Account Management</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 6952, "\"", 7000, 1);
#nullable restore
#line 124 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6960, ViewBag.Active == "2" ? "active" : "", 6960, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/LessonManagement\"><i class=\"fa fa-puzzle-piece\"></i>Lesson Management</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 7124, "\"", 7172, 1);
#nullable restore
#line 125 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7132, ViewBag.Active == "3" ? "active" : "", 7132, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/QuizManagement\"><i class=\"fa fa-question\"></i>Quiz Management</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 7288, "\"", 7336, 1);
#nullable restore
#line 126 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7296, ViewBag.Active == "4" ? "active" : "", 7296, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/WordManagement\"><i class=\"fa fa-file-word-o\"></i>Word Management</a></li>\r\n                        <li");
                BeginWriteAttribute("class", " class=\"", 7455, "\"", 7503, 1);
#nullable restore
#line 127 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7463, ViewBag.Active == "9" ? "active" : "", 7463, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><a href=\"/Home/SentenceStructureManagement\"><i class=\"fa fa-building-o\"></i>Sentence Structure</a></li>\r\n\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 167 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </nav>
    </div>
    <div class=""mcw"">
        <div class=""cv"">
            <div>
                <div class=""inbox"">
                    <div class=""inbox-sb"">

                    </div>
                    <div class=""inbox-bx container-fluid"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""container"">
                                    <main role=""main"" class=""pb-3"">
                                        ");
#nullable restore
#line 184 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Shared\_Layout.cshtml"
                                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </main>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src='https://code.jquery.com/jquery-3.1.1.min.js'></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "913917f5f81a6793744d45fb0d5d1043195f399519034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""></script>
    <script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js'></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor Accessor { get; private set; }
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

#pragma checksum "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7278bab0efcbc21497441b4ba4be7e514ad493f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateWord), @"mvc.1.0.view", @"/Views/Home/UpdateWord.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7278bab0efcbc21497441b4ba4be7e514ad493f1", @"/Views/Home/UpdateWord.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3c8a5f883b3c09a5a5154703dc57ec35f2e083", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateWord : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/DoUpdateWord"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
    .form-outline {
        margin-top: 3%;
        position: relative;
        text-align: center;
        border-style: solid;
        border-width: 1px;
        border-color: gray;
        display: inline-block;
    }
</style>
<div class=""form-outline"" style=""width: 40%;margin-left:20%"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7278bab0efcbc21497441b4ba4be7e514ad493f14400", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"vocabInLesson.Id\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 569, "\"", 586, 1);
#nullable restore
#line 19 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 577, Model.Id, 577, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <div class=\"form-group\">\r\n            <label>Image:</label>\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 675, "\"", 693, 1);
#nullable restore
#line 22 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 681, Model.Image, 681, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"height:150px;width:120px\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Lesson:</label>\r\n            <select class=\"form-select\" name=\"lesson.LessonId\">\r\n");
#nullable restore
#line 27 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
                 foreach (var i in ViewBag.Lesson)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7278bab0efcbc21497441b4ba4be7e514ad493f16119", async() => {
#nullable restore
#line 29 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
                                                                                                Write(i.Lesson1);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
AddHtmlAttributeValue("", 992, i.Id == ViewBag.LessonId ? "selected" : null, 992, 47, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
                                                                                  WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Word:</label>\r\n            <input type=\"text\" name=\"vocabInLesson.Word\" class=\"form-control\" placeholder=\"Enter word\"");
                BeginWriteAttribute("value", " value=\"", 1304, "\"", 1323, 1);
#nullable restore
#line 35 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 1312, Model.Word, 1312, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Pronunciation:</label>\r\n            <input type=\"text\" name=\"vocabInLesson.Pronunciation\" class=\"form-control\" placeholder=\"Enter pronunciation\"");
                BeginWriteAttribute("value", " value=\"", 1540, "\"", 1568, 1);
#nullable restore
#line 39 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 1548, Model.Pronunciation, 1548, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Meaning:</label>\r\n            <input type=\"text\" name=\"vocabInLesson.Meaning\" class=\"form-control\" placeholder=\"Enter meaning\"");
                BeginWriteAttribute("value", " value=\"", 1767, "\"", 1789, 1);
#nullable restore
#line 43 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 1775, Model.Meaning, 1775, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Synonymous:</label>\r\n            <input type=\"text\" name=\"vocabInLesson.Synonymous\" class=\"form-control\" placeholder=\"Enter synonymous\"");
                BeginWriteAttribute("value", " value=\"", 1997, "\"", 2022, 1);
#nullable restore
#line 47 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 2005, Model.Synonymous, 2005, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Antonymous:</label>\r\n            <input type=\"text\" name=\"vocabInLesson.Antonymous\" class=\"form-control\" placeholder=\"Enter antonymous\"");
                BeginWriteAttribute("value", " value=\"", 2230, "\"", 2255, 1);
#nullable restore
#line 51 "C:\Users\Computer\source\repos\EnglishLearningApp\EnglishLearningApp\Views\Home\UpdateWord.cshtml"
WriteAttributeValue("", 2238, Model.Antonymous, 2238, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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

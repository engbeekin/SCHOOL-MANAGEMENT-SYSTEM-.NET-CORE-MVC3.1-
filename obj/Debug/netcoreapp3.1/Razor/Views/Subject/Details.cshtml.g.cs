#pragma checksum "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33a44be9f0867b345ba3d962b008b7152990eb52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Details), @"mvc.1.0.view", @"/Views/Subject/Details.cshtml")]
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
#line 1 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\_ViewImports.cshtml"
using SchoolMangmentSystemCore;

#line default
#line hidden
#line 2 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\_ViewImports.cshtml"
using SchoolMangmentSystemCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a44be9f0867b345ba3d962b008b7152990eb52", @"/Views/Subject/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b6d8c5dbdc356dc9e7e9afd2e6522153ca5c85", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolMangmentSystemCore.Models.subject>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 3 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>subject</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 14 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubjectName));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 17 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubjectName));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 20 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 23 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 26 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 29 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 32 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 35 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.Duration));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 38 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxStudents));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 41 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxStudents));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#line 44 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#line 47 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a44be9f0867b345ba3d962b008b7152990eb527712", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "E:\asp.net Core Mvc\SchoolMangmentSystemCore\SchoolMangmentSystemCore\Views\Subject\Details.cshtml"
                           WriteLiteral(Model.SubjectId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a44be9f0867b345ba3d962b008b7152990eb529842", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolMangmentSystemCore.Models.subject> Html { get; private set; }
    }
}
#pragma warning restore 1591

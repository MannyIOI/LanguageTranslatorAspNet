#pragma checksum "C:\Users\hp\source\repos\WebApplication1\Language\Views\Login\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01724b96ef80ae7b5b34639ec8e230facbdb0a5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_SignUp), @"mvc.1.0.view", @"/Views/Login/SignUp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/SignUp.cshtml", typeof(AspNetCore.Views_Login_SignUp))]
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
#line 1 "C:\Users\hp\source\repos\WebApplication1\Language\Views\_ViewImports.cshtml"
using Language;

#line default
#line hidden
#line 2 "C:\Users\hp\source\repos\WebApplication1\Language\Views\_ViewImports.cshtml"
using Language.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01724b96ef80ae7b5b34639ec8e230facbdb0a5c", @"/Views/Login/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9766af7a177797e933f1bea8323fb1a1ca5bb2b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Login/SignUp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\hp\source\repos\WebApplication1\Language\Views\Login\SignUp.cshtml"
  
	ViewData["Title"] = "SignUp";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(85, 83, true);
            WriteLiteral("\r\n<h2>SignUp</h2>\r\n\r\n<div class=\"row\">\r\n\t<div class=\"col-lg-offset-3 col-md-3\">\r\n\t\t");
            EndContext();
            BeginContext(168, 722, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8269f7c12cf24c18b1c9edba6dbd2014", async() => {
                BeginContext(211, 366, true);
                WriteLiteral(@"
			<input type=""text"" name=""username"" class=""form-control form-item"" placeholder=""Username"" />
			<input type=""password"" name=""password"" class=""form-control form-item"" placeholder=""Password"" />
			<input type=""password"" name=""conPassword"" class=""form-control form-item"" placeholder=""Confirm Password"" />
			<span class=""col-lg-offset-3 red"" style=""color: red;"">");
                EndContext();
                BeginContext(578, 23, false);
#line 15 "C:\Users\hp\source\repos\WebApplication1\Language\Views\Login\SignUp.cshtml"
                                                             Write(ViewData["input_error"]);

#line default
#line hidden
                EndContext();
                BeginContext(601, 66, true);
                WriteLiteral("</span>\r\n\t\t\t<span class=\"col-lg-offset-2 red\" style=\"color: red;\">");
                EndContext();
                BeginContext(668, 24, false);
#line 16 "C:\Users\hp\source\repos\WebApplication1\Language\Views\Login\SignUp.cshtml"
                                                             Write(ViewData["input_error1"]);

#line default
#line hidden
                EndContext();
                BeginContext(692, 66, true);
                WriteLiteral("</span>\r\n\t\t\t<span class=\"col-lg-offset-1 red\" style=\"color: red;\">");
                EndContext();
                BeginContext(759, 24, false);
#line 17 "C:\Users\hp\source\repos\WebApplication1\Language\Views\Login\SignUp.cshtml"
                                                             Write(ViewData["input_error2"]);

#line default
#line hidden
                EndContext();
                BeginContext(783, 100, true);
                WriteLiteral("</span>\r\n\t\t\t<button type=\"submit\" class=\"form-control form-item btn btn-primary\">Submit</button>\r\n\t\t");
                EndContext();
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
            EndContext();
            BeginContext(890, 17, true);
            WriteLiteral("\r\n\t</div>\r\n</div>");
            EndContext();
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

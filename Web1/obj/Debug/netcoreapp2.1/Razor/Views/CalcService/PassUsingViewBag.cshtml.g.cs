#pragma checksum "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a014d79068cc59c032e464c2b224e4339055342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingViewBag), @"mvc.1.0.view", @"/Views/CalcService/PassUsingViewBag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CalcService/PassUsingViewBag.cshtml", typeof(AspNetCore.Views_CalcService_PassUsingViewBag))]
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
#line 1 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\_ViewImports.cshtml"
using Web1;

#line default
#line hidden
#line 2 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\_ViewImports.cshtml"
using Web1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a014d79068cc59c032e464c2b224e4339055342", @"/Views/CalcService/PassUsingViewBag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4350575864478f163bc4cef769cb0463ac39cb", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_PassUsingViewBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
  
    ViewData["Title"] = "PassUsingViewBag";

#line default
#line hidden
            BeginContext(52, 662, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac498e90d9941aa8c6013a21147460c", async() => {
                BeginContext(58, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(69, 17, false);
#line 5 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(86, 34, true);
                WriteLiteral("</h1>\r\n    <p><b>Rand Value First:");
                EndContext();
                BeginContext(121, 18, false);
#line 6 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                      Write(ViewBag.ValueFirst);

#line default
#line hidden
                EndContext();
                BeginContext(139, 38, true);
                WriteLiteral("</b></p>\r\n    <p><b>Rand Value Second:");
                EndContext();
                BeginContext(178, 19, false);
#line 7 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                       Write(ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(197, 41, true);
                WriteLiteral("</b></p>\r\n    <p><b>Add:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(239, 18, false);
#line 9 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
  Write(ViewBag.ValueFirst);

#line default
#line hidden
                EndContext();
                BeginContext(257, 1, true);
                WriteLiteral("+");
                EndContext();
                BeginContext(259, 19, false);
#line 9 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                      Write(ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(278, 2, true);
                WriteLiteral("= ");
                EndContext();
                BeginContext(282, 42, false);
#line 9 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                                             Write(@ViewBag.ValueFirst + @ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(325, 37, true);
                WriteLiteral("</p>\r\n    <p><b>Sub:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(363, 18, false);
#line 11 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
  Write(ViewBag.ValueFirst);

#line default
#line hidden
                EndContext();
                BeginContext(381, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(383, 19, false);
#line 11 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                      Write(ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(402, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(407, 42, false);
#line 11 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                                              Write(@ViewBag.ValueFirst - @ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(450, 38, true);
                WriteLiteral("</p>\r\n    <p><b>Mult:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(489, 18, false);
#line 13 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
  Write(ViewBag.ValueFirst);

#line default
#line hidden
                EndContext();
                BeginContext(507, 1, true);
                WriteLiteral("*");
                EndContext();
                BeginContext(509, 19, false);
#line 13 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                      Write(ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(528, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(533, 42, false);
#line 13 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                                              Write(@ViewBag.ValueFirst * @ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(576, 37, true);
                WriteLiteral("</p>\r\n    <p><b>Div:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(614, 18, false);
#line 15 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
  Write(ViewBag.ValueFirst);

#line default
#line hidden
                EndContext();
                BeginContext(632, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(634, 19, false);
#line 15 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                      Write(ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(653, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(658, 42, false);
#line 15 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\PassUsingViewBag.cshtml"
                                              Write(@ViewBag.ValueFirst / @ViewBag.ValueSecond);

#line default
#line hidden
                EndContext();
                BeginContext(701, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
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

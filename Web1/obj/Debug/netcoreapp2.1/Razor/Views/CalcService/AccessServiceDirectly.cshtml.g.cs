#pragma checksum "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "367c9ad620619e0682cbd9c9168afdd097e749d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_AccessServiceDirectly), @"mvc.1.0.view", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CalcService/AccessServiceDirectly.cshtml", typeof(AspNetCore.Views_CalcService_AccessServiceDirectly))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367c9ad620619e0682cbd9c9168afdd097e749d6", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f4350575864478f163bc4cef769cb0463ac39cb", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_AccessServiceDirectly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
   
    ViewData["Title"] = "AccessServiceDirectly";
    int a = @SimpleCalc.Randomize();
    int b = @SimpleCalc.Randomize();

#line default
#line hidden
            BeginContext(174, 345, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4e3cd6b3104d98a01ff89f6a989082", async() => {
                BeginContext(180, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(191, 17, false);
#line 8 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(208, 34, true);
                WriteLiteral("</h1>\r\n    <p><b>Rand Value First:");
                EndContext();
                BeginContext(243, 1, false);
#line 9 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
                      Write(a);

#line default
#line hidden
                EndContext();
                BeginContext(244, 38, true);
                WriteLiteral("</b></p>\r\n    <p><b>Rand Value Second:");
                EndContext();
                BeginContext(283, 1, false);
#line 10 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
                       Write(b);

#line default
#line hidden
                EndContext();
                BeginContext(284, 41, true);
                WriteLiteral("</b></p>\r\n    <p><b>Add:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(326, 1, false);
#line 12 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
  Write(a);

#line default
#line hidden
                EndContext();
                BeginContext(327, 1, true);
                WriteLiteral("+");
                EndContext();
                BeginContext(329, 1, false);
#line 12 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
     Write(b);

#line default
#line hidden
                EndContext();
                BeginContext(330, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(335, 4, false);
#line 12 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
           Write(a+@b);

#line default
#line hidden
                EndContext();
                BeginContext(340, 37, true);
                WriteLiteral("</p>\r\n    <p><b>Sub:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(378, 1, false);
#line 14 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
  Write(a);

#line default
#line hidden
                EndContext();
                BeginContext(379, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(381, 1, false);
#line 14 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
     Write(b);

#line default
#line hidden
                EndContext();
                BeginContext(382, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(387, 7, false);
#line 14 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
           Write(@a - @b);

#line default
#line hidden
                EndContext();
                BeginContext(395, 38, true);
                WriteLiteral("</p>\r\n    <p><b>Mult:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(434, 1, false);
#line 16 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
  Write(a);

#line default
#line hidden
                EndContext();
                BeginContext(435, 1, true);
                WriteLiteral("*");
                EndContext();
                BeginContext(437, 1, false);
#line 16 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
     Write(b);

#line default
#line hidden
                EndContext();
                BeginContext(438, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(443, 7, false);
#line 16 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
           Write(@a * @b);

#line default
#line hidden
                EndContext();
                BeginContext(451, 37, true);
                WriteLiteral("</p>\r\n    <p><b>Div:</b></p>\r\n    <p>");
                EndContext();
                BeginContext(489, 1, false);
#line 18 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
  Write(a);

#line default
#line hidden
                EndContext();
                BeginContext(490, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(492, 1, false);
#line 18 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
     Write(b);

#line default
#line hidden
                EndContext();
                BeginContext(493, 3, true);
                WriteLiteral(" = ");
                EndContext();
                BeginContext(498, 7, false);
#line 18 "H:\web\web\WebApplication1WithCSS\WebApplication1WithCSS\Views\CalcService\AccessServiceDirectly.cshtml"
           Write(@a / @b);

#line default
#line hidden
                EndContext();
                BeginContext(506, 6, true);
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
        public Web1.Services.ICalc SimpleCalc { get; private set; }
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

#pragma checksum "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Divisionespdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3a2998d199bf5c7f388e98950a5328c88307aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Divisionespdf), @"mvc.1.0.view", @"/Views/Home/Divisionespdf.cshtml")]
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
#line 1 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\_ViewImports.cshtml"
using Aplicacion_Web1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\_ViewImports.cshtml"
using Aplicacion_Web1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\_ViewImports.cshtml"
using Kiosko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\_ViewImports.cshtml"
using Kiosko.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3a2998d199bf5c7f388e98950a5328c88307aa", @"/Views/Home/Divisionespdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e45bbc00f4664a9570e70ee21b5e26da204f6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Divisionespdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kiosko.Models.Divisione>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("900"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("1200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Divisionespdf.cshtml"
  
    ViewData["Title"] = "Divisionespdf";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br /><br /><br /><br /><br />\r\n\r\n<h1>Descarga el plan de estudio de: ");
#nullable restore
#line 9 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Divisionespdf.cshtml"
                               Write(Html.DisplayFor(model=>model.Nombredivision));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb3a2998d199bf5c7f388e98950a5328c88307aa5264", async() => {
                WriteLiteral("\r\n    <h1> PLAN DE ESTUDIO</h1>\r\n    <center>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("iframe", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb3a2998d199bf5c7f388e98950a5328c88307aa5583", async() => {
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 329, "~/img/", 329, 6, true);
#nullable restore
#line 14 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Divisionespdf.cshtml"
AddHtmlAttributeValue("", 335, Html.DisplayFor(model=> model.Planestudio), 335, 43, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </center>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kiosko.Models.Divisione> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea1560739c85d08b5b3d18c344c386699e9b4ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Proyectos), @"mvc.1.0.view", @"/Views/Home/Proyectos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea1560739c85d08b5b3d18c344c386699e9b4ac", @"/Views/Home/Proyectos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e45bbc00f4664a9570e70ee21b5e26da204f6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Proyectos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kiosko.Models.Proyecto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "infoDivision", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InfoProyecto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main id=""main"">



    <!-- ======= Cta Section ======= -->
    <section id=""cta"" class=""cta"">
        <div class=""container"" data-aos=""zoom-in"">

            <div class=""row"">
                <div class=""col-lg-9 text-center text-lg-start"">
                    <h3>Mira todos los proyectos disponibles</h3>
                    <p>los proyecto y la inovacion son lo que mueve al mundo, en la UNIVERSIDAD TECNOLOGICA METROPOLITANA son uno de nuestras prioridades y tambien son lo que mas nos enorguyesen</p>
                </div>
                <div class=""col-lg-3 cta-btn-container text-center"">
                    <a class=""cta-btn align-middle"" href""why-us"" >VER</a>
                </div>
            </div>

        </div>
    </section><!-- End Cta Section -->
    <footer id=""footer"">

        <div class=""footer-newsletter"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-lg-6"">
                        <");
            WriteLiteral("h4>Busca cualquier proyecto</h4>\r\n                        <p>busca el nombre del proyecto o escribe el la division para ver todos sus proyectos</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ea1560739c85d08b5b3d18c344c386699e9b4ac7933", async() => {
                WriteLiteral("\r\n                            <input type=\"email\" name=\"email\"><input type=\"submit\" value=\"buscar\">\r\n                        ");
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n\r\n\r\n\r\n\r\n\r\n    <!-- ======= Why Us Section ======= -->\r\n    <section id=\"why-us\" class=\"why-us section-bg\">\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
         foreach (var item in Model)
        {




#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container-fluid"" data-aos=""fade-up"">

            <div class=""row"">

                <div class=""col-lg-7 d-flex flex-column justify-content-center align-items-stretch  order-2 order-lg-1"">

                    <div class=""content"">
                        <h3><strong>");
#nullable restore
#line 63 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Nombreproyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h3>\r\n                        <p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ea1560739c85d08b5b3d18c344c386699e9b4ac10826", async() => {
#nullable restore
#line 65 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
                                                                                                                        Write(Html.DisplayFor(modelItem => item.IddivisionesNavigation.Nombredivision));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
                                                                                             WriteLiteral(item.Iddivisiones);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                    <div class=\"accordion-list\">\r\n                        <ul>\r\n                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ea1560739c85d08b5b3d18c344c386699e9b4ac14078", async() => {
                WriteLiteral("conoce mas del proyecto <i class=\"bx bx-chevron-down icon-show\"></i><i></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
                                                                                                                  WriteLiteral(item.Idproyectos);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                <div id=\"accordion-list-1\">\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 75 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descripcionproyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                </div>
                            </li>
                        </ul>
                    </div>

                </div>

                <div class=""col-lg-5 align-items-stretch order-1 order-lg-2 img"" data-aos=""fade-right"" data-aos-delay=""100"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ea1560739c85d08b5b3d18c344c386699e9b4ac17760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3357, "~/img/", 3357, 6, true);
#nullable restore
#line 85 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"
AddHtmlAttributeValue("", 3363, Html.DisplayFor(modelItem => item.Fotoproyecto), 3363, 48, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n            \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 99 "C:\Users\Luiss\OneDrive\Escritorio\aplicaciones web\kioskoutm\Nueva carpeta\Nueva carpeta\Kiosko\Views\Home\Proyectos.cshtml"




        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    </section>



















    <section id=""cliens1"" class=""cliens section-bg"">
        <div class=""container"">

            <div class=""row"" data-aos=""zoom-in"">

                <div class=""col"">
                    <h1>NO OLVIDES VISITAR LOS PROYECTOS</h1>
                </div>
            </div>

        </div>

    </section>




</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kiosko.Models.Proyecto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

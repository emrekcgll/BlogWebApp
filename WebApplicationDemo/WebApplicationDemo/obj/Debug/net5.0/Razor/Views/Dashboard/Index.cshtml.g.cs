#pragma checksum "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0226f302ee7b74ca42869bd3d56cee63fd45c8c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\_ViewImports.cshtml"
using WebApplicationDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\_ViewImports.cshtml"
using WebApplicationDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0226f302ee7b74ca42869bd3d56cee63fd45c8c7", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519a6507560b6c59f57449537e6f42ac31b5daea", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/WriterPanel/assets/images/dashboard/circle.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-absolute"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("circle-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0226f302ee7b74ca42869bd3d56cee63fd45c8c74783", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""assets/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""assets/vendors/css/vendor.bundle.base.css"">
    <link rel=""stylesheet"" href=""assets/css/style.css"">
    <link rel=""shortcut icon"" href=""assets/images/favicon.ico"" />
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0226f302ee7b74ca42869bd3d56cee63fd45c8c76053", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 13 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("WriterAboutOnDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""container-scroller"">
        <div class=""content-wrapper"">
            <div class=""page-header"">
                <h3 class=""page-title"">
                    <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                        <i class=""mdi mdi-home""></i>
                    </span> Dashboard
                </h3>
                <nav aria-label=""breadcrumb"">
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item active"" aria-current=""page"">
                            <span></span>Overview <i class=""mdi mdi-alert-circle-outline icon-sm text-primary align-middle""></i>
                        </li>
                    </ul>
                </nav>
            </div>
            <div class=""row"">
                <div class=""col-md-4 stretch-card grid-margin"">
                    <div class=""card bg-gradient-danger card-img-holder text-white"">
                        <div class=""card-body"">
                       ");
                WriteLiteral("     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0226f302ee7b74ca42869bd3d56cee63fd45c8c77692", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <h4 class=""font-weight-normal mb-3"">
                                Toplam Blog Sayısı <i class=""mdi mdi-chart-line mdi-24px float-right""></i>
                            </h4>
                            <h2 class=""mb-5"">");
#nullable restore
#line 39 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
                                        Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                            <h6 class=""card-text"">Text</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 stretch-card grid-margin"">
                    <div class=""card bg-gradient-info card-img-holder text-white"">
                        <div class=""card-body"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0226f302ee7b74ca42869bd3d56cee63fd45c8c79873", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <h4 class=""font-weight-normal mb-3"">
                                Sizin Blog Sayınız <i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                            </h4>
                            <h2 class=""mb-5"">");
#nullable restore
#line 51 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
                                        Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                            <h6 class=""card-text"">Text</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4 stretch-card grid-margin"">
                    <div class=""card bg-gradient-success card-img-holder text-white"">
                        <div class=""card-body"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0226f302ee7b74ca42869bd3d56cee63fd45c8c712063", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <h4 class=\"font-weight-normal mb-3\">\r\n                                Toplam Yazar Sayısı<i class=\"mdi mdi-diamond mdi-24px float-right\"></i>\r\n                            </h4>\r\n                            <h2 class=\"mb-5\">");
#nullable restore
#line 63 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                            <h6 class=""card-text"">Text</h6>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-7 grid-margin stretch-card"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""clearfix"">
                                <h4 class=""card-title float-left"">Visit And Sales Statistics</h4>
                                <div id=""visit-sale-chart-legend"" class=""rounded-legend legend-horizontal legend-top-right float-right""></div>
                            </div>
                            <canvas id=""visit-sale-chart"" class=""mt-4""></canvas>
                        </div>
                    </div>
                </div>
                <div class=""col-md-5 grid-margin stretch-card"">
                    <div class=""card"">
                        <div class=""card-body"">
                ");
                WriteLiteral(@"            <h4 class=""card-title"">Traffic Sources</h4>
                            <canvas id=""traffic-chart""></canvas>
                            <div id=""traffic-chart-legend"" class=""rounded-legend legend-vertical legend-bottom-left pt-4""></div>
                        </div>
                    </div>
                </div>
            </div>
            ");
#nullable restore
#line 91 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n            ");
#nullable restore
#line 96 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Dashboard\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryListDashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

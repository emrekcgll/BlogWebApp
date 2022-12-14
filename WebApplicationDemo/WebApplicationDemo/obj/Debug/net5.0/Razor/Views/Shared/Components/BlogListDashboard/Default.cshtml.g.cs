#pragma checksum "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a9c3b5194bcffa23b6447d5a501dc43ee932eb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#line 1 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\_ViewImports.cshtml"
using WebApplicationDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\_ViewImports.cshtml"
using WebApplicationDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9c3b5194bcffa23b6447d5a501dc43ee932eb7", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519a6507560b6c59f57449537e6f42ac31b5daea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son Bloglar</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> Ba??l??k </th>
                                <th> Konu </th>
                                <th> Kategori </th>
                                <th> Durum </th>
                                <th> Son G??ncelleme </th>
                                <th> Blog Id </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1016, "\"", 1035, 1);
#nullable restore
#line 26 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1022, item.BlogImg, 1022, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"><a");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1101, 2);
            WriteAttributeValue("", 1071, "/Blog/BlogReadAll/", 1071, 18, true);
#nullable restore
#line 26 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1089, item.BlogId, 1089, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                                                                              Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 28 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 70).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("..</td>\r\n                                    <td>");
#nullable restore
#line 29 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n");
#nullable restore
#line 31 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                         if (item.BlogStatus == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <label class=\"badge badge-gradient-success\">Aktif</label>\r\n");
#nullable restore
#line 34 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <label class=\"badge badge-secondary\">Pasif</label>\r\n");
#nullable restore
#line 38 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>");
#nullable restore
#line 40 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 41 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 43 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591

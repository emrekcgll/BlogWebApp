#pragma checksum "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ce4fea40534a8fc2f4c7b5a206ce346a0ff862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ce4fea40534a8fc2f4c7b5a206ce346a0ff862", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519a6507560b6c59f57449537e6f42ac31b5daea", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazarın Blogları</h1>
<table class=""table table-hover"">
    <tr>
        <th>#</th>
        <th>Blog Başlığı</th>
        <th>Oluşturma Tarihi</th>
        <th>Kategori</th>
        <th>Durum</th>
        <th>Sil</th>
        <th>Düzenle</th>

    </tr>
");
#nullable restore
#line 21 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogCreateDate.ToString("dd.MM.yyyy | HH : mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 29 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
                 if (item.BlogStatus==true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-success\">Aktif</span>\r\n");
#nullable restore
#line 32 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-secondary\">Pasif</span>\r\n");
#nullable restore
#line 36 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1052, 2);
            WriteAttributeValue("", 1023, "/Blog/BlogDelete/", 1023, 17, true);
#nullable restore
#line 38 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1040, item.BlogId, 1040, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-google\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1109, "\"", 1143, 2);
            WriteAttributeValue("", 1116, "/Blog/EditBlog/", 1116, 15, true);
#nullable restore
#line 39 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1131, item.BlogId, 1131, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Düzenle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Emre\OneDrive\Masaüstü\WebApplicationDemo\WebApplicationDemo\Views\Blog\BlogListByWriter.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Blog/BlogAdd\" class=\"btn btn-primary\">Yeni Blog Ekle</a>\r\n");
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
#pragma checksum "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205e9180f80542d725f1986f46436c294980f60e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/Index.cshtml")]
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
#line 1 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplicationDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplicationDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205e9180f80542d725f1986f46436c294980f60e", @"/Areas/Admin/Views/AdminRole/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac3796c745f3ba87163f56067f82771546c62ba", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5>Hover Table  </h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                    <i class=""fa fa-wrench""></i>
                </a>
                <ul class=""dropdown-menu dropdown-user"">
                    <li>
                        <a href=""#"" class=""dropdown-item"">Config option 1</a>
                    </li>
                    <li>
                        <a href=""#"" class=""dropdown-item"">Config option 2</a>
                    </li>
                </ul>
                <a class=""close-link"">
                    <i class=""fa fa-times""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">

            <table class=""table table-hover"">
                <th");
            WriteLiteral("ead>\r\n                    <tr>\r\n                        <th>#</th>\r\n                        <th>Başlık</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 44 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 47 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1624, "\"", 1667, 2);
            WriteAttributeValue("", 1631, "/Admin/AdminRole/DeleteRole/", 1631, 28, true);
#nullable restore
#line 49 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 1659, item.Id, 1659, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\"><i class=\"fa fa-times\"></i> Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1768, "\"", 1811, 2);
            WriteAttributeValue("", 1775, "/Admin/AdminRole/UpdateRole/", 1775, 28, true);
#nullable restore
#line 50 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
WriteAttributeValue("", 1803, item.Id, 1803, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-reddit\"><i class=\"fa fa-recycle\"></i> Güncelle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminRole\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <a href=""/Admin/AdminRole/AddRole/"" class=""btn btn-outline-primary"">Yeni Rol Ekle</a>
            <a href=""/Admin/AdminRole/UserRoleList/"" class=""btn btn-outline-primary"">Kullanıcı Rol Listesi</a>

        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591

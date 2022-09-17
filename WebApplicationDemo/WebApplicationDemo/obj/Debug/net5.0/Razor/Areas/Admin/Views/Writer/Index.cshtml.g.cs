#pragma checksum "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a23b97368a8d2c6e5105b8e95bef37cc436e13e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a23b97368a8d2c6e5105b8e95bef37cc436e13e", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Yazar İşlemleri</h1>
<button type=""button"" id=""btngetlist"" class=""btn btn-primary"">Yazar Listesi</button>
<div id=""writerlist"">
</div>
<br />
<h1>Yazar Ara</h1>
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar id değerini girin"" class=""form-control"" />
</div>
<button type=""button"" id=""btngetbyid"" class=""btn btn-primary"">Yazar Getir</button>
<br />
<div id=""writerget"">
</div>
<br />
<h1>Yazar Ekle</h1>
<div>
    <input type=""text"" id=""txtwriterid"" placeholder=""Yazar Id"" class=""form-control"" />
    <input type=""text"" id=""txtwritername"" placeholder=""Yazar Adı"" class=""form-control"" />
</div>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-primary"">Yazar Ekle</button>
<br />
<h1>Yazar Kaldır</h1>
<div>
    <input type=""text"" id=""txtid"" placeholder=""Silinecek Yazar Id"" class=""form-control"" />
</div>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-primary"">Yazar Sil</button>
<br />
<h1>Yazar Güncelle</h1>
<input type=""text"" id=""txtid1"" placeholder=""Güncel");
            WriteLiteral("lenecek Id\" class=\"form-control\" />\r\n<input type=\"text\" id=\"txtwritername1\" placeholder=\"Güncellenecek Ad\" class=\"form-control\" />\r\n<button type=\"button\" id=\"btnupdatewriter\" class=\"btn btn-primary\">Yazar Güncelle</button>\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class=table table-bordered> <tr> <th>Yazar Id</th> <th>Yazar Adı</th> </tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr> <td>${value.id}</td> <td>${value.name}</td> </tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
    ");
                WriteLiteral(@"            type: ""get"",
                url: ""/Admin/Writer/GetWriterById/"",
                data: { writerid: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);


                    let getvalue = `<table class=table table-bordered> <tr><th>Yazar Id</th> <th>Yazar Adı</th></tr> <tr><td>${w.id}</td><td>${w.name}</td></tr></table>`;
                    $(""#writerget"").html(getvalue);
                }
            });
        });

        $(""#btnaddwriter"").click(function () {
            let writer = {
                id: $(""#txtwriterid"").val(),
                name: $(""#txtwritername"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/AddWriter/"",
                data: writer,
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar ekleme işlemi başarılı bir şeki");
                WriteLiteral(@"lde gerçekleşti."");
                }
            });
        });

        $(""#btndeletewriter"").click(x => {
            let id = $(""#txtid"").val();

            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar silme işlemi başarılı bir şekilde gerçekleşti."");
                }
            });
        });

        $(""#btnupdatewriter"").click(function () {
            let writer = {
                id: $(""#txtid1"").val(),
                name: $(""#txtwritername1"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data: writer,
                success: function (func) {
                    alert(""Güncelleme başarılı."");
                }
            });
        });

    </script");
                WriteLiteral(">\r\n");
            }
            );
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

#pragma checksum "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5274aa30af52d9ad1f91c749d5f561826071857b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_Sendbox), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/Sendbox.cshtml")]
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
#line 1 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5274aa30af52d9ad1f91c749d5f561826071857b", @"/Areas/Admin/Views/AdminMessage/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac3796c745f3ba87163f56067f82771546c62ba", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminMessage_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right mail-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
  
    ViewData["Title"] = "Sendbox";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5274aa30af52d9ad1f91c749d5f561826071857b5125", async() => {
                WriteLiteral(@"
    <div id=""wrapper"">
        <div class=""wrapper wrapper-content"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""ibox "">
                        <div class=""ibox-content mailbox-content"">
                            <div class=""file-manager"">
                                <a class=""btn btn-block btn-primary compose-mail"" href=""/Admin/AdminMessage/ComposeMail/"">Mesaj Gönder</a>
                                <div class=""space-25""></div>
                                <h5>Folders</h5>
                                <ul class=""folder-list m-b-md"" style=""padding: 0"">
                                    <li><a href=""/Admin/AdminMessage/Inbox/""> <i class=""fa fa-inbox ""></i> Inbox</a></li>
                                    <li><a href=""/Admin/AdminMessage/Sendbox/""> <i class=""fa fa-envelope-o""></i> Send Mail</a></li>
                                    <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Trash</a></li>
             ");
                WriteLiteral(@"                   </ul>
                                <div class=""clearfix""></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-9 animated fadeInRight"">
                    <div class=""mail-box-header"">

                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5274aa30af52d9ad1f91c749d5f561826071857b6828", async() => {
                    WriteLiteral(@"
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control form-control-sm"" name=""search"" placeholder=""Search email"">
                                <div class=""input-group-btn"">
                                    <button type=""submit"" class=""btn btn-sm btn-primary"">
                                        Search
                                    </button>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                        <h2>
                            Sendbox
                        </h2>
                        <div class=""mail-tools tooltip-demo m-t-md"">
                            <div class=""btn-group float-right"">
                                <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-left""></i></button>
                                <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-right""></i></button>

                            </div>
                            <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""left"" title=""Refresh inbox""><i class=""fa fa-refresh""></i> Refresh</button>
                            <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Mark as read""><i class=""fa fa-eye""></i> </button>
                            <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Mark as important""><i class=""fa fa-exclamation""></i> </button>
  ");
                WriteLiteral(@"                          <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Move to trash""><i class=""fa fa-trash-o""></i> </button>

                        </div>
                    </div>
                    <div class=""mail-box"">

                        <table class=""table table-hover table-mail"">
                            <tbody>

");
#nullable restore
#line 67 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <tr class=""unread"">
                                        <td class=""check-mail"">
                                            <input type=""checkbox"" class=""i-checks"">
                                        </td>
                                        <td class=""mail-ontact""><a href=""mail_detail.html"">");
#nullable restore
#line 73 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
                                                                                      Write(item.ReceiverUser.WriterName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                        <td class=\"mail-subject\"><a href=\"mail_detail.html\">");
#nullable restore
#line 74 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
                                                                                       Write(item.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                        <td");
                BeginWriteAttribute("class", " class=\"", 4220, "\"", 4228, 0);
                EndWriteAttribute();
                WriteLiteral("></td>\r\n                                        <td class=\"text-right mail-date\">");
#nullable restore
#line 76 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
                                                                    Write(item.MessageDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 78 "D:\GitHub\BlogWebApp\WebApplicationDemo\WebApplicationDemo\Areas\Admin\Views\AdminMessage\Sendbox.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Mainly scripts -->
    <script src=""js/jquery-3.1.1.min.js""></script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.js""></script>
    <script src=""js/plugins/metisMenu/jquery.metisMenu.js""></script>
    <script src=""js/plugins/slimscroll/jquery.slimscroll.min.js""></script>

    <!-- Custom and plugin javascript -->
    <script src=""js/inspinia.js""></script>
    <script src=""js/plugins/pace/pace.min.js""></script>

    <!-- iCheck -->
    <script src=""js/plugins/iCheck/icheck.min.js""></script>
    <script>
        $(document).ready(function () {
            $('.i-checks').iCheck({
                checkboxClass: 'icheckbox_square-green',
                radioClass: 'iradio_square-green',
            });
        });</script>
");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74c6a61896c41184fcf9cce8b7ff1da47b559a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_PhieuTra_Index), @"mvc.1.0.view", @"/Areas/User/Views/PhieuTra/Index.cshtml")]
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
#line 1 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b74c6a61896c41184fcf9cce8b7ff1da47b559a0", @"/Areas/User/Views/PhieuTra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/User/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_User_Views_PhieuTra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.CTPM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/PhieuTra/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/PhieuTra/Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/User/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\nsetTimeout(function () {\r\n            $(\'#msgAlert\').fadeOut(\'slow\');\r\n        }, 2000);</script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container-fluid"">
    <h1 class=""mt-4"">Danh sách phiếu trả</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/User/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách phiếu trả</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    <a class=""btn btn-success"" href=""/User/PhieuTra/Create"">Tạo mới</a>
                </div>
            </div>
        </div>

        <div class=""card-body"">
            <div class=""row"">
");
#nullable restore
#line 29 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                 if (ViewBag.SuccessMsg != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                        ");
#nullable restore
#line 32 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                   Write(ViewBag.SuccessMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>");
#nullable restore
#line 33 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""card mb-4"">
                <div class=""card-header""><i class=""fas fa-table mr-1""></i>Phiếu mượn</div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 43 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 46 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 49 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 52 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 55 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 58 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 61 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 68 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 72 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 75 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 78 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 81 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 84 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 87 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 90 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b74c6a61896c41184fcf9cce8b7ff1da47b559a013340", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4582, "\"", 4600, 1);
#nullable restore
#line 94 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
WriteAttributeValue("", 4590, item.MaPM, 4590, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4684, "\"", 4704, 1);
#nullable restore
#line 95 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
WriteAttributeValue("", 4692, item.MaSach, 4692, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"mas\" />\r\n                                                <input type=\"submit\" value=\"Sửa\" class=\"btn btn-outline-success\" />\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b74c6a61896c41184fcf9cce8b7ff1da47b559a016354", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5151, "\"", 5169, 1);
#nullable restore
#line 102 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
WriteAttributeValue("", 5159, item.MaPM, 5159, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5253, "\"", 5273, 1);
#nullable restore
#line 103 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
WriteAttributeValue("", 5261, item.MaSach, 5261, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"mas\" />\r\n                                                <input type=\"submit\" value=\"Chi tiết\" class=\"btn btn-outline-warning\" />\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 108 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/User/Views/PhieuTra/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.CTPM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

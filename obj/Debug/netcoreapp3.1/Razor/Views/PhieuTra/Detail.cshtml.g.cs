#pragma checksum "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddd12790065cb7d6297040915ae88677ea1a931d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhieuTra_Detail), @"mvc.1.0.view", @"/Views/PhieuTra/Detail.cshtml")]
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
#line 1 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd12790065cb7d6297040915ae88677ea1a931d", @"/Views/PhieuTra/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PhieuTra_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PJC.Models.CTPM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PhieuTra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1 class=""mt-4"">Chi tiết</h1>
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/Home"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Chi tiết</li>
    </ol>
    <div class=""card mb-4"">
        <div class=""card-header"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddd12790065cb7d6297040915ae88677ea1a931d4596", async() => {
                WriteLiteral("Về danh sách");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <h4>CTPM</h4>\r\n            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 23 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 26 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaPM));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 29 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 32 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.MaSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 35 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 38 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.NgayTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 41 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 44 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.TinhTrangSach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 47 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 50 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.TinhTrangTra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 53 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 56 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 59 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayNameFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 62 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
               Write(Html.DisplayFor(model => model.GhiChu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n            <div>\r\n                ");
#nullable restore
#line 66 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Views/PhieuTra/Detail.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=Model.MaPM,Model.MaSach }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n               \r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PJC.Models.CTPM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

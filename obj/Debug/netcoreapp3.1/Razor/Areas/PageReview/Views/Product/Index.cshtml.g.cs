#pragma checksum "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29b49c036f123eea0328260a550d630b389da00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PageReview_Views_Product_Index), @"mvc.1.0.view", @"/Areas/PageReview/Views/Product/Index.cshtml")]
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
#line 1 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/_ViewImports.cshtml"
using PJC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/_ViewImports.cshtml"
using PJC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e29b49c036f123eea0328260a550d630b389da00", @"/Areas/PageReview/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01766513dca41114e40f89b458a8a274af3bbe90", @"/Areas/PageReview/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_PageReview_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PJC.Models.Sach>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/PageReview/Product/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Areas/PageReview/Views/Shared/_LayoutReView.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .hidden {
        opacity: 0;
        visibility: hidden;
        display: none;
    }

    .search-fa {
        padding-top: 10px;
    }

    .button-add-to-cart {
        position: absolute;
        bottom: 10%;
    }

    .media-wrapper {
        position: relative;
    }

    .button-add-to-cart-wrapper {
        height: 50px;
    }
</style>
<section class=""section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""search-fa"">
                <p>Tìm Kiếm:</p>
            </div>
            <div class=""col-md-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29b49c036f123eea0328260a550d630b389da005015", async() => {
                WriteLiteral("\r\n                    <input class=\"form-control\" type=\"text\" name=\"searchString\" placeholder=\"Nhập tên sách, thể loại, tác giả...\" />\r\n                ");
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
            WriteLiteral(@"
            </div>

        </div>
        <div class=""row"">
            <br />
        </div>
        <div class=""card mb-4"">
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <div class=""row list "">
");
#nullable restore
#line 49 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 1459, "\"", 1522, 6);
            WriteAttributeValue("", 1467, "col-md-6", 1467, 8, true);
            WriteAttributeValue(" ", 1475, "col-lg-4", 1476, 9, true);
            WriteAttributeValue(" ", 1484, "media-wrapper", 1485, 14, true);
#nullable restore
#line 52 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
WriteAttributeValue(" ", 1498, item.TheLoai, 1499, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 1512, "item", 1514, 6, true);
            WriteAttributeValue(" ", 1518, "All", 1519, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"media block-6 d-block\">\r\n                        <div class=\"media-body \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e29b49c036f123eea0328260a550d630b389da008514", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 1751, "\"", 1771, 1);
#nullable restore
#line 56 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
WriteAttributeValue("", 1757, item.ImageUrl, 1757, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"imageCell\" style=\"width: 200px; height:300px\" />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1671, "~/PageReview/Product/Detail/", 1671, 28, true);
#nullable restore
#line 55 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
AddHtmlAttributeValue("", 1699, item.MaSach, 1699, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <h3 class=\"heading\">");
#nullable restore
#line 58 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
                                           Write(item.TenSach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p><strong>Giá: </strong>");
#nullable restore
#line 59 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
                                                Write(item.GiaTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p><strong>Số lượng: </strong>");
#nullable restore
#line 60 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
                                                     Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"button-add-to-cart-wrapper\">\r\n                                <button id=\"button-add-to-cart\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2214, "\"", 2249, 3);
            WriteAttributeValue("", 2224, "addToCart(\'", 2224, 11, true);
#nullable restore
#line 62 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
WriteAttributeValue("", 2235, item.MaSach, 2235, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2247, "\')", 2247, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"button-add-to-cart\">Thêm vào giỏ hàng</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>");
#nullable restore
#line 66 "/Users/nguyenhoangphuong/Downloads/1670/PJC/Areas/PageReview/Views/Product/Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>

</section>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js""></script>

<script>
$('#selectType').on('change', function () {
        var type = $('#selectType').val();
        console.log(type);
        $('.list .item').each(function () {
            if ($(this).hasClass(type)) {
                $(this).removeClass('hidden');
                $(this).addClass('zoomIn animated');
            }
            else {
                $(this).addClass('hidden');
                $(this).removeClass('zoomIn animated');
            }
        });
        });
    async function addToCart(code) {
        const formData = new FormData()
        formData.append('code', code)
        try {
            const result = await axios.post('/PageReview/Cart/AddToCart', formData)
            alert('Add success')
        } catch (err) {
            console.log(err)
       ");
            WriteLiteral(" }\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PJC.Models.Sach>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "E:\code\Shop-Swan\be-shop-swan\ShopSwan\ShopSwan\Views\Home\PersionalBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9efae89e5b01ec910e64cf4880e2c7517d7c053b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersionalBill), @"mvc.1.0.view", @"/Views/Home/PersionalBill.cshtml")]
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
#line 1 "E:\code\Shop-Swan\be-shop-swan\ShopSwan\ShopSwan\Views\_ViewImports.cshtml"
using ShopSwan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\code\Shop-Swan\be-shop-swan\ShopSwan\ShopSwan\Views\_ViewImports.cshtml"
using ShopSwan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9efae89e5b01ec910e64cf4880e2c7517d7c053b", @"/Views/Home/PersionalBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db8b8866c674883b69a6c0470668cdfd7f6c8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersionalBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/all/cart/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\code\Shop-Swan\be-shop-swan\ShopSwan\ShopSwan\Views\Home\PersionalBill.cshtml"
  
    ViewData["Title"] = "PersionalBill";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""main-cart"">
            <div class=""d-flex"">
                <div class=""col-4"">
                    <div class=""form-common"">
                        <div class=""form-login"">
                            <div class=""form-group"">
                                <h2>Nguyễn Phương Thanh</h2>
                            </div>
                            <div class=""form-group"">
                                <a href=""/home/persional"" class=""btn-white text-center"">Thông tin cá nhân</a>
                            </div>
                            <div class=""form-group"">
                                <a href=""/home/PersionalBill"" class=""btn-black text-center"">Danh sách đơn hàng</a>
                            </div>
                            <div class=""form-group"">
                                <a class=""btn-white text-center"" id=""btn-log-out"">Đăng xuất</a>
                            </div>
                        </div>
                    </div>
                </d");
            WriteLiteral(@"iv>
                <div class=""col-8"">
                    <div class=""form-common-left"">
                        <div class=""form-group"">
                            <h2>Danh sách đơn hàng</h2>
                        </div>
                        <div class=""box-bill"">
                            <div class=""bill-header"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div>
                                            <p>Ảnh</p>
                                        </div>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-3"">
                                        <div>
                                            <p>Tên sản phẩm</p>
                                        </div>
                                    </div>
                                    <div class=""");
            WriteLiteral(@"col-2"">
                                        <div>
                                            <p>Số lượng</p>
                                        </div>
                                    </div>
                                    <div class=""col-3"">
                                        <p>Đơn giá</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""bill-item"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 2759, "\"", 2767, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9efae89e5b01ec910e64cf4880e2c7517d7c053b7067", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                                    <div class=""col-1""></div>
                                    <div class=""col-3 text-align-center"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 3133, "\"", 3141, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <p>ÁO NỈ MŨ TRÁI TIM</p>
                                        </div>
                                    </div>
                                    <div class=""col-2 text-align-center"">
                                        <div>
                                            <p>x1</p>
                                        </div>
                                    </div>
                                    <div class=""col-3 text-align-center"">
                                        <p>199.000đ</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""bill-item"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 4046, "\"", 4054, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9efae89e5b01ec910e64cf4880e2c7517d7c053b9706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                                    <div class=""col-1""></div>
                                    <div class=""col-3 text-align-center"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 4420, "\"", 4428, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <p>ÁO NỈ MŨ TRÁI TIM</p>
                                        </div>
                                    </div>
                                    <div class=""col-2 text-align-center"">
                                        <div>
                                            <p>x1</p>
                                        </div>
                                    </div>
                                    <div class=""col-3 text-align-center"">
                                        <p>199.000đ</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""line-black""></div>
                            <div class=""mt-20 text-right"">
                                <p><b>Trạng thái</b>: Đang giao &nbsp
                                    <b>Tổng tiền</b>: 343.000đ </p>
                            </div>
                            <div class=""mt");
            WriteLiteral(@"-20 mb-20 text-right"">
                                <a href=""/home/PersionalBillDetail"" class=""btn-black"" style=""display: inline-block;"">Chi tiết</a>
                                <a href=""/home/contact"" class=""btn-black"" style=""display: inline-block;"">Liên hệ</a>
                            </div>
                        </div>
                        <div class=""box-bill"">
                            <div class=""bill-header"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div>
                                            <p>Ảnh</p>
                                        </div>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-3"">
                                        <div>
                                            <p>Tên sản phẩm</p>
                                ");
            WriteLiteral(@"        </div>
                                    </div>
                                    <div class=""col-2"">
                                        <div>
                                            <p>Số lượng</p>
                                        </div>
                                    </div>
                                    <div class=""col-3"">
                                        <p>Đơn giá</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""bill-item"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 7245, "\"", 7253, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9efae89e5b01ec910e64cf4880e2c7517d7c053b14355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                                    <div class=""col-1""></div>
                                    <div class=""col-3 text-align-center"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 7619, "\"", 7627, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <p>ÁO NỈ MŨ TRÁI TIM</p>
                                        </div>
                                    </div>
                                    <div class=""col-2 text-align-center"">
                                        <div>
                                            <p>x1</p>
                                        </div>
                                    </div>
                                    <div class=""col-3 text-align-center"">
                                        <p>199.000đ</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""bill-item"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 8532, "\"", 8540, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9efae89e5b01ec910e64cf4880e2c7517d7c053b16995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                                    <div class=""col-1""></div>
                                    <div class=""col-3 text-align-center"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 8906, "\"", 8914, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <p>ÁO NỈ MŨ TRÁI TIM</p>
                                        </div>
                                    </div>
                                    <div class=""col-2 text-align-center"">
                                        <div>
                                            <p>x1</p>
                                        </div>
                                    </div>
                                    <div class=""col-3 text-align-center"">
                                        <p>199.000đ</p>
                                    </div>
                                </div>
                            </div>
                            <div class=""line-black""></div>
                            <div class=""mt-20 text-right"">
                                <p><b>Trạng thái</b>: Đang giao &nbsp
                                    <b>Tổng tiền</b>: 343.000đ </p>
                            </div>
                            <div class=""mt");
            WriteLiteral(@"-20 mb-20 text-right"">
                                <a href=""/home/productdetail"" class=""btn-black"" style=""display: inline-block;"">Mua Lại</a>
                                <a href=""/home/PersionalBillDetail"" class=""btn-black"" style=""display: inline-block;"">Chi tiết</a>
                                <a href=""/home/contact"" class=""btn-black"" style=""display: inline-block;"">Liên hệ</a>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>");
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
#pragma checksum "E:\code\Shop-Swan\be-shop-swan\ShopSwan\ShopSwan\Views\Admin\ManageBillDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b0a5f5fb3213b6b28c50835ce1dac8e3bdfcf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ManageBillDetail), @"mvc.1.0.view", @"/Views/Admin/ManageBillDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b0a5f5fb3213b6b28c50835ce1dac8e3bdfcf0", @"/Views/Admin/ManageBillDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db8b8866c674883b69a6c0470668cdfd7f6c8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ManageBillDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "E:\code\Shop-Swan\be-shop-swan\ShopSwan\ShopSwan\Views\Admin\ManageBillDetail.cshtml"
  
    ViewData["Title"] = "ManageBillDetail";
    Layout = "~/Views/Shared/_Layout2.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
        <div class=""main-cart"">
            <div class=""d-flex"">
                <div class=""col-6"">
                    <div class=""form-common"">
                        <div class=""form-cart"">
                            <div class=""form-group"">
                                <h2>Thông tin tài khoản</h2>
                            </div>
                            <div class=""form-group"">
                                <div class=""n-row"">
                                    <div class=""col-3"">
                                        <p>Họ tên</p>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-8"">
                                        <input type=""text"" class=""form-control"" placeholder=""Nhập họ tên"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
   ");
            WriteLiteral(@"                             <div class=""n-row"">
                                    <div class=""col-3"">
                                        <p>Email</p>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-8"">
                                        <input type=""text"" class=""form-control"" placeholder=""Nhập Email"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""n-row"">
                                    <div class=""col-3"">
                                        <p>Số điện thoại</p>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-8"">
                                        <input type=""text"" class=""form-control"" pl");
            WriteLiteral(@"aceholder=""Nhập số điện thoại"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""n-row"">
                                    <div class=""col-3"">
                                        <p>Địa chỉ</p>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-8"">
                                        <input type=""text"" class=""form-control"" placeholder=""Nhập địa chỉ"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""n-row"">
                                    <div class=""col-3"">
                                        <p>Ngày đặt hàng</p>
                                ");
            WriteLiteral(@"    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-8"">
                                        <input type=""text"" class=""form-control"" placeholder=""Nhập địa chỉ"" value=""13/10/2022"">
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""n-row"">
                                    <div class=""col-3"">
                                        <p>Ghi chú</p>
                                    </div>
                                    <div class=""col-1""></div>
                                    <div class=""col-8"">
                                        <textarea class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 4010, "\"", 4017, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4018, "\"", 4023, 0);
            EndWriteAttribute();
            WriteLiteral(@" cols=""30"" rows=""3"" placeholder=""Nhập ghi chú""></textarea>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""form-common-left"">
                        <div class=""form-group"">
                            <h2>Danh sách đơn hàng</h2>
                        </div>
                        <div class=""box-bill"">
                            <div class=""bill-item"">
                                <div class=""n-row form-group"">
                                    <div class=""col-3"">
                                        <div");
            BeginWriteAttribute("class", " class=\"", 4782, "\"", 4790, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a4b0a5f5fb3213b6b28c50835ce1dac8e3bdfcf09446", async() => {
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
            BeginWriteAttribute("class", " class=\"", 5156, "\"", 5164, 0);
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
            BeginWriteAttribute("class", " class=\"", 6069, "\"", 6077, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a4b0a5f5fb3213b6b28c50835ce1dac8e3bdfcf012085", async() => {
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
            BeginWriteAttribute("class", " class=\"", 6443, "\"", 6451, 0);
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
                            <div class=""mt-20 "">
                                    <b>Tổng tiền</b>: 343.000đ </p>
                            </div>
                            <div class=""box-btn mt-40"">
                                <a href=""#"" class=""btn-black"" style=""display: inline-block;"">Xác nhận đơn hàng</a>
          ");
            WriteLiteral(@"                      <a href=""#"" class=""btn-black"" style=""display: inline-block;"">Hủy đơn hàng</a>
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

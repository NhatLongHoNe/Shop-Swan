#pragma checksum "C:\Users\nhathl\Desktop\be-shop-swan\ShopSwan\ShopSwan\Views\Admin\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7c2fceb885bcd945b2a9fea635a210ec377e42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Manage), @"mvc.1.0.view", @"/Views/Admin/Manage.cshtml")]
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
#line 1 "C:\Users\nhathl\Desktop\be-shop-swan\ShopSwan\ShopSwan\Views\_ViewImports.cshtml"
using ShopSwan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nhathl\Desktop\be-shop-swan\ShopSwan\ShopSwan\Views\_ViewImports.cshtml"
using ShopSwan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7c2fceb885bcd945b2a9fea635a210ec377e42", @"/Views/Admin/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db8b8866c674883b69a6c0470668cdfd7f6c8bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nhathl\Desktop\be-shop-swan\ShopSwan\ShopSwan\Views\Admin\Manage.cshtml"
  
    ViewData["Title"] = "Manage";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <div class=""revenue"">
            <div class=""n-row"">
                <div class=""col-3"">
                    <ul class=""list-group"">
                        <li class=""list-group-item border-top-0 active"" aria-current=""true"">Tất cả đơn hàng</li>
                        <li class=""list-group-item"">Chờ xác nhận</li>
                        <li class=""list-group-item"">Đã xác nhận</li>
                        <li class=""list-group-item"">Đang giao hàng</li>
                        <li class=""list-group-item"">Đã giao hàng</li>
                        <li class=""list-group-item"">Đã hủy</li>
                    </ul>
                </div>
                <div class=""col-9"">
                    <div class=""pl-30"">
                        <table class=""table"">
                            <thead>
                                <tr class=""border-top-0"">
                                    <th>ID</th>
                                    <th>Đơn hàng</th>
                                    <th>Ng");
            WriteLiteral(@"ày tạo đơn</th>
                                    <th>Trạng thái</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <th>1</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr>
                                <tr>
                                    <th>2");
            WriteLiteral(@"</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr>
                                <tr>
                                    <th>3</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
 ");
            WriteLiteral(@"                                   <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr>
                                <tr>
                                    <th>4</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr");
            WriteLiteral(@">
                                <tr>
                                    <th>5</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr>
                                <tr>
                                    <th>6</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                   ");
            WriteLiteral(@"                 </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr>
                                <tr>
                                    <th>7</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a");
            WriteLiteral(@">
                                    </td>
                                </tr>
                                <tr>
                                    <th>8</th>
                                    <td>
                                        <b>Đơn hàng 1</b>
                                        <br>
                                        Áo nỉ mũ trái tim
                                    </td>
                                    <td>13/10/2022</td>
                                    <td>Chờ xác nhận</td>
                                    <td>
                                        <a href=""/admin/ManageBillDetail"" class=""btn-black"" style=""display:inline-block"">Chi tiết</a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <div>
                            <nav aria-label=""Page navigation example"">
                                <ul class=""pagination""");
            WriteLiteral(@">
                                    <li class=""page-item active""><a class=""page-link"" href=""#"">1</a></li>
                                    <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                    <li class=""page-item""><a class=""page-link"" href=""#"">4</a></li>
                                </ul>
                            </nav>
                        </div>
                    </div>

                </div>
            </div>
        </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\Pages\Product\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c26e1c60684358f998fba00c216f7913c877e3eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShopLapTop.Server.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\_Imports.razor"
using ShopLapTop.Server.Pages.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/Add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "D:\DoAnTotNghiep\DOANTOTNGHIEP\Đồ Án Tốt Nghiệp\ShopLapTop.Server\Pages\Product\Add.razor"
        
    int Amount;
    DateTime Date = new DateTime();
    IEnumerable<Employee> employees;
    protected override void OnInitialized()
    {
        Date = DateTime.Now;
        base.OnInitialized();
    }
    public class Employee
    {
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public int DonGia { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7cdf92084ac4a92a44b9b68fe23293f4442c309"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-57el9359e3");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-57el9359e3>CarRentalManagement</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-57el9359e3");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-57el9359e3></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 14 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-57el9359e3");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
            __builder.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(19, "li");
                __builder2.AddAttribute(20, "class", "nav-item px-3");
                __builder2.AddAttribute(21, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
                __builder2.AddAttribute(23, "class", "nav-link");
                __builder2.AddAttribute(24, "href", "authentication/profile");
                __builder2.AddAttribute(25, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 19 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-57el9359e3></span> Hello, ");
#nullable restore
#line 20 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
__builder3.AddContent(28, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(29, "!\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "li");
                __builder2.AddAttribute(32, "class", "nav-item px-3");
                __builder2.AddAttribute(33, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
                __builder2.AddAttribute(35, "class", "nav-link");
                __builder2.AddAttribute(36, "href", "#");
                __builder2.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                 BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 24 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-57el9359e3></span> Log out\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(41, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(42, "li");
                __builder2.AddAttribute(43, "class", "nav-item px-3");
                __builder2.AddAttribute(44, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "class", "nav-link");
                __builder2.AddAttribute(47, "href", "authentication/register");
                __builder2.AddAttribute(48, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 31 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-57el9359e3></span> Register\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "li");
                __builder2.AddAttribute(53, "class", "nav-item px-3");
                __builder2.AddAttribute(54, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(55);
                __builder2.AddAttribute(56, "class", "nav-link");
                __builder2.AddAttribute(57, "href", "authentication/login");
                __builder2.AddAttribute(58, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 36 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "<span class=\"oi oi-account-login\" aria-hidden=\"true\" b-57el9359e3></span> Log In\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "li");
            __builder.AddAttribute(63, "class", "nav-item px-3");
            __builder.AddAttribute(64, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(65);
            __builder.AddAttribute(66, "class", "nav-link");
            __builder.AddAttribute(67, "href", "");
            __builder.AddAttribute(68, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 43 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(70, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-57el9359e3></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "nav-item px-3");
            __builder.AddAttribute(74, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
            __builder.AddAttribute(76, "class", "nav-link");
            __builder.AddAttribute(77, "href", "makes/");
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Makes\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "li");
            __builder.AddAttribute(82, "class", "nav-item px-3");
            __builder.AddAttribute(83, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(84);
            __builder.AddAttribute(85, "class", "nav-link");
            __builder.AddAttribute(86, "href", "models/");
            __builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(88, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Models\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.OpenElement(90, "li");
            __builder.AddAttribute(91, "class", "nav-item px-3");
            __builder.AddAttribute(92, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(93);
            __builder.AddAttribute(94, "class", "nav-link");
            __builder.AddAttribute(95, "href", "colours/");
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Colours\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.OpenElement(99, "li");
            __builder.AddAttribute(100, "class", "nav-item px-3");
            __builder.AddAttribute(101, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(102);
            __builder.AddAttribute(103, "class", "nav-link");
            __builder.AddAttribute(104, "href", "vehicles/");
            __builder.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(106, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Vehicles\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "li");
            __builder.AddAttribute(109, "class", "nav-item px-3");
            __builder.AddAttribute(110, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(111);
            __builder.AddAttribute(112, "class", "nav-link");
            __builder.AddAttribute(113, "href", "customers/");
            __builder.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(115, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Customers\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n        ");
            __builder.OpenElement(117, "li");
            __builder.AddAttribute(118, "class", "nav-item px-3");
            __builder.AddAttribute(119, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(120);
            __builder.AddAttribute(121, "class", "nav-link");
            __builder.AddAttribute(122, "href", "bookings/");
            __builder.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(124, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Bookings\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591

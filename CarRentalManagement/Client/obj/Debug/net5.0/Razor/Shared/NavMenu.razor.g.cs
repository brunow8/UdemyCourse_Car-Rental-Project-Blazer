#pragma checksum "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99fb09818b9ac840b2341da5f68d2a26e27ed5b"
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
#line 1 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Static;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Shared.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\_Imports.razor"
using CarRentalManagement.Client.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
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
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar sideNavTitle");
            __builder.AddAttribute(2, "b-57el9359e3");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand title\" href b-57el9359e3>Car Rental Management</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
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
            __builder.AddAttribute(11, "class", "sideNav");
            __builder.AddAttribute(12, "b-57el9359e3");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", 
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-57el9359e3");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "nav flex-column");
            __builder.AddAttribute(19, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(20);
            __builder.AddAttribute(21, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(22, "li");
                __builder2.AddAttribute(23, "class", "nav-item px-3");
                __builder2.AddAttribute(24, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
                __builder2.AddAttribute(26, "class", "nav-link");
                __builder2.AddAttribute(27, "href", "authentication/profile");
                __builder2.AddAttribute(28, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 20 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                       NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-57el9359e3></span> Hello, <br b-57el9359e3>");
#nullable restore
#line 21 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
__builder3.AddContent(31, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(32, "!\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "li");
                __builder2.AddAttribute(35, "class", "nav-item px-3");
                __builder2.AddAttribute(36, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
                __builder2.AddAttribute(38, "class", "nav-link");
                __builder2.AddAttribute(39, "href", "#");
                __builder2.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                     BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 25 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "<span class=\"oi oi-account-logout\" aria-hidden=\"true\" b-57el9359e3></span> Log out\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(44, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(45, "li");
                __builder2.AddAttribute(46, "class", "nav-item px-3");
                __builder2.AddAttribute(47, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
                __builder2.AddAttribute(49, "class", "nav-link");
                __builder2.AddAttribute(50, "href", "authentication/register");
                __builder2.AddAttribute(51, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 32 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(53, "<span class=\"oi oi-person\" aria-hidden=\"true\" b-57el9359e3></span> Register\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "li");
                __builder2.AddAttribute(56, "class", "nav-item px-3");
                __builder2.AddAttribute(57, "b-57el9359e3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(58);
                __builder2.AddAttribute(59, "class", "nav-link");
                __builder2.AddAttribute(60, "href", "authentication/login");
                __builder2.AddAttribute(61, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 37 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(63, "<span class=\"oi oi-account-login\" aria-hidden=\"true\" b-57el9359e3></span> Log In\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "nav-item px-3");
            __builder.AddAttribute(67, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
            __builder.AddAttribute(69, "class", "nav-link");
            __builder.AddAttribute(70, "href", "");
            __builder.AddAttribute(71, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 44 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-57el9359e3></span> Home\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "li");
            __builder.AddAttribute(76, "class", "nav-item px-3");
            __builder.AddAttribute(77, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(78);
            __builder.AddAttribute(79, "class", "nav-link");
            __builder.AddAttribute(80, "href", "makes/");
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Makes\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "li");
            __builder.AddAttribute(85, "class", "nav-item px-3");
            __builder.AddAttribute(86, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
            __builder.AddAttribute(88, "class", "nav-link");
            __builder.AddAttribute(89, "href", "models/");
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(91, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Models\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "nav-item px-3");
            __builder.AddAttribute(95, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(96);
            __builder.AddAttribute(97, "class", "nav-link");
            __builder.AddAttribute(98, "href", "colours/");
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(100, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Colors\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                ");
            __builder.OpenElement(102, "li");
            __builder.AddAttribute(103, "class", "nav-item px-3");
            __builder.AddAttribute(104, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(105);
            __builder.AddAttribute(106, "class", "nav-link");
            __builder.AddAttribute(107, "href", "vehicles/");
            __builder.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(109, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Vehicles\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "li");
            __builder.AddAttribute(112, "class", "nav-item px-3");
            __builder.AddAttribute(113, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(114);
            __builder.AddAttribute(115, "class", "nav-link");
            __builder.AddAttribute(116, "href", "customers/");
            __builder.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(118, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Customers\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                ");
            __builder.OpenElement(120, "li");
            __builder.AddAttribute(121, "class", "nav-item px-3");
            __builder.AddAttribute(122, "b-57el9359e3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(123);
            __builder.AddAttribute(124, "class", "nav-link");
            __builder.AddAttribute(125, "href", "bookings/");
            __builder.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(127, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-57el9359e3></span> Bookings\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Bruno Barbosa\Desktop\Blazer Rental Car\CarRentalManagement\Client\Shared\NavMenu.razor"
       
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

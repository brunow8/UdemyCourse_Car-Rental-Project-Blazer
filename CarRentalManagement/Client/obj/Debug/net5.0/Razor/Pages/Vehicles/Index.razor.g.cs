#pragma checksum "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba4e4a33456cc7793fbc51486d5982b95cbb0bb1"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Pages.Vehicles
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
#line 3 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 5 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

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
#line 2 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vehicles/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<CarRentalManagement.Client.Components.HeadingComponent>(0);
            __builder.AddAttribute(1, "Text", "Vehicles");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.AddMarkupContent(3, "<a href=\"/vehicles/create\" class=\"btn btn-secondary\"><span class=\"oi oi-plus\"></span>\r\n        Create New Vehicle\r\n    </a>\r\n    <br>\r\n    <br>");
#nullable restore
#line 14 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
     if (Vehicles == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<div class=\"alert alert-info\">Loading Vehicles...</div>");
#nullable restore
#line 17 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th></th>\r\n                    <th>Make</th>\r\n                    <th>Model</th>\r\n                    <th>Year</th>\r\n                    <th>Daily Rate</th>\r\n                    <th>Actions</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 32 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
                 foreach (var vehicle in Vehicles)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 35 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
                                       vehicle.ImageName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "style", "height: 150px; width: 150px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 36 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
__builder.AddContent(16, vehicle.Make.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 37 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
__builder.AddContent(19, vehicle.Model.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 38 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
__builder.AddContent(22, vehicle.Year);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 39 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
__builder.AddContent(25, vehicle.RentalRate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/vehicles/view/" + (
#nullable restore
#line 41 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
                                                     vehicle.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddMarkupContent(31, "<span class=\"oi oi-book\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "/vehicles/edit/" + (
#nullable restore
#line 44 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
                                                     vehicle.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-warning");
            __builder.AddMarkupContent(36, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
                                                                       ()=>Delete(vehicle.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Vehicles\Index.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

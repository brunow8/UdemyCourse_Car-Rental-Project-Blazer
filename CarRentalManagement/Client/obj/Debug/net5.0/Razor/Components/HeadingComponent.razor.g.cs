#pragma checksum "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Components\HeadingComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d874b97fdd50f1973cde25bd18b0376a4774d9f"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Components
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
    public partial class HeadingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron jumbotron-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "class", "display-4");
#nullable restore
#line 3 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Components\HeadingComponent.razor"
__builder.AddContent(6, Text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Components\HeadingComponent.razor"
       
    [Parameter] public string Text { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

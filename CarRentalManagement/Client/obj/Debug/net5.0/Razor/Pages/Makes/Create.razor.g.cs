#pragma checksum "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Makes\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618a297416cf33b709c229608d2d3265195c95b4"
// <auto-generated/>
#pragma warning disable 1591
namespace CarRentalManagement.Client.Pages.Makes
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/makes/create/")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Create New Make</h3>\r\n<hr>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<CarRentalManagement.Client.Pages.Makes.FormComponent>(1);
            __builder.AddAttribute(2, "ButtonText", "Create Make");
            __builder.AddAttribute(3, "make", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CarRentalManagement.Shared.Domain.Make>(
#nullable restore
#line 8 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Makes\Create.razor"
                                              make

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Bruno Barbosa\Desktop\Nova pasta\CarRentalManagement-Blazor-WASM\CarRentalManagement\Client\Pages\Makes\Create.razor"
                               CreateMake

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

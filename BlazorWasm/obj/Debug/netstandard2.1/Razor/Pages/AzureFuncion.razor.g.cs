#pragma checksum "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c35cd7b4b0a6b35f4100124862f031881f67a097"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using BlazorWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\_Imports.razor"
using BlazorWasm.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/azure-function")]
    public partial class AzureFuncion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 4 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
     pageHeadder

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
 if (azureFunctionHttpTrigger == string.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h3>Loading azure function http trigger</h3>");
#nullable restore
#line 9 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, "Azure function http trigger - ");
            __builder.AddContent(5, 
#nullable restore
#line 12 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
                                     azureFunctionHttpTrigger

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
 if (bikeModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 18 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
#nullable restore
#line 23 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
             foreach (var bike in bikeModel)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddAttribute(15, "style", "width: 18rem;");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "class", "card-img-top");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 28 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
                                                        bike.ImageUri

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "alt", 
#nullable restore
#line 28 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
                                                                             bike.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenElement(23, "h5");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, 
#nullable restore
#line 30 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
                                                    bike.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "card-text");
            __builder.AddContent(29, 
#nullable restore
#line 31 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
                                                  bike.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.AddMarkupContent(31, "<a href=\"#\" class=\"btn btn-primary\">More Details</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"


            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\IPGitHub\Repos\MyBlazorWasmAzureStaticWebAppRepo\BlazorWasm\Pages\AzureFuncion.razor"
      
 private string  pageHeadder = "Azure Functions";
 private string azureFunctionHttpTrigger = string.Empty;

  private IEnumerable<BikeModel> bikeModel;

 protected override async Task OnInitializedAsync()
 {
    azureFunctionHttpTrigger = await Http.GetStringAsync("https://myazurefunctionapps.azurewebsites.net/api/HttpTriggerFunctionServiceGetData");
    bikeModel = await Http.GetFromJsonAsync<IEnumerable<BikeModel>>("https://myazurefunctionapps.azurewebsites.net/api/HttpTriggerFunctionBikeService");
 }

     public class BikeModel
    {
        public int BikeId { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string ImageUri { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

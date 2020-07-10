#pragma checksum "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f72666346d349a7d0e0d4c12639ac2b9d3c6456"
// <auto-generated/>
#pragma warning disable 1591
namespace SportsStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\_Imports.razor"
using SportsStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>ID</th>");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
                            Product.ProductID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Name</th>");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 8 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
                              Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Description</th>");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 9 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
                                     Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Category</th>");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 10 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
                                  Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>Price</th>");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 11 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
                               Product.Price.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "btn btn-warning");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 15 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "btn btn-secondary");
            __builder.AddAttribute(41, "href", "/admin/products");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(43, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Details.razor"
       

    [Inject]
    public IStoreRepository Repository { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Product Product { get; set; }

    protected override void OnParametersSet() {
        Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
    }

    public string EditUrl => $"/admin/products/edit/{Product.ProductID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

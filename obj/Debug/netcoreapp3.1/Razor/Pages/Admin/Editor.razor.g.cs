#pragma checksum "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da279d83a0e3ce30c55a16d985665700eb2cedd4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<IStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    div.validation-message { color: rgb(220, 53, 69); font-weight: 500 }\n</style>\n\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "bg-" + (
#nullable restore
#line 9 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
               ThemeColor

#line default
#line hidden
#nullable disable
            ) + " text-white" + " text-center" + " p-1");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                       TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " a Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                 Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                         SaveProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n");
#nullable restore
#line 12 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
     if(Product.ProductID != 0) {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\n            ");
                __builder2.AddMarkupContent(17, "<label>ID</label>\n            ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "disabled", true);
                __builder2.AddAttribute(21, "value", 
#nullable restore
#line 15 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                         Product.ProductID

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n");
#nullable restore
#line 17 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(24, "    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.AddMarkupContent(28, "<label>Name</label>\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 20 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\n        ");
                __builder2.AddMarkupContent(42, "<label>Description</label>\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 43, 44, 
#nullable restore
#line 25 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\n        ");
                __builder2.AddMarkupContent(56, "<label>Category</label>\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_2(__builder2, 57, 58, 
#nullable restore
#line 30 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Category

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(59, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                     Product.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Category = __value, Product.Category))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Category));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\n    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "\n        ");
                __builder2.AddMarkupContent(70, "<label>Price</label>\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 71, 72, 
#nullable restore
#line 35 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                  () => Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(73, "\n        ");
                __Blazor.SportsStore.Pages.Admin.Editor.TypeInference.CreateInputNumber_4(__builder2, 74, 75, "form-control", 76, 
#nullable restore
#line 36 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                                       Product.Price

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 78, () => Product.Price);
                __builder2.AddMarkupContent(79, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\n    ");
                __builder2.OpenElement(81, "button");
                __builder2.AddAttribute(82, "type", "submit");
                __builder2.AddAttribute(83, "class", "btn" + " btn-" + (
#nullable restore
#line 38 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
                                          ThemeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(84, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
                __builder2.AddAttribute(87, "class", "btn btn-secondary");
                __builder2.AddAttribute(88, "href", "/admin/products");
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(90, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Acer\Desktop\blazor\SportsSln\SportsStore\Pages\Admin\Editor.razor"
       

    public IStoreRepository Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public Product Product { get; set; } = new Product();

    protected override void OnParametersSet() {
        if (Id != 0) {
            Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
        }
    }

    public void SaveProduct() {
        if (Id == 0) {
            Repository.CreateProduct(Product);
        } else {
            Repository.SaveProduct(Product);
        }
        NavManager.NavigateTo("/admin/products");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.SportsStore.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

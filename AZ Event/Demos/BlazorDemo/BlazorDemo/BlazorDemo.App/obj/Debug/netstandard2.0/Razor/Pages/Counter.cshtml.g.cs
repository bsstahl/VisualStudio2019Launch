#pragma checksum "C:\Users\Admin\Source\Repos\VisualStudio2019Launch\AZ Event\Demos\BlazorDemo\BlazorDemo\BlazorDemo.App\Pages\Counter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fabfd6e6d002e957b53fad126e1419708789b9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using BlazorDemo.App;
    using BlazorDemo.App.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            builder.OpenElement(1, "p");
            builder.AddContent(2, "Current count: ");
            builder.AddContent(3, currentCount);
            builder.CloseElement();
            builder.AddContent(4, "\r\n\r\n");
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Components.UIMouseEventArgs>(IncrementCount));
            builder.AddContent(8, "Click me");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 9 "C:\Users\Admin\Source\Repos\VisualStudio2019Launch\AZ Event\Demos\BlazorDemo\BlazorDemo\BlazorDemo.App\Pages\Counter.cshtml"
            
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591

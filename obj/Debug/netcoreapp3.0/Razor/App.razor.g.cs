#pragma checksum "/Users/brett/Documents/projects/blazor/blazortest/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b13c31eea46a5248bf664cabef17d49b88311d"
// <auto-generated/>
#pragma warning disable 1591
namespace blazortest
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 5 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using blazortest;

#line default
#line hidden
#line 8 "/Users/brett/Documents/projects/blazor/blazortest/_Imports.razor"
using blazortest.Shared;

#line default
#line hidden
    public class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Microsoft.AspNetCore.Components.CascadingAuthenticationState>(0);
            builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(2, "\r\n    ");
                builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(3);
                builder2.AddAttribute(4, "AppAssembly", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 2 "/Users/brett/Documents/projects/blazor/blazortest/App.razor"
                         typeof(Startup).Assembly

#line default
#line hidden
                ));
                builder2.AddAttribute(5, "NotFoundContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder3) => {
                    builder3.AddMarkupContent(6, "\r\n            ");
                    builder3.AddMarkupContent(7, "<p>Sorry, there\'s nothing at this address.</p>\r\n        ");
                }
                ));
                builder2.CloseComponent();
                builder2.AddMarkupContent(8, "\r\n");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
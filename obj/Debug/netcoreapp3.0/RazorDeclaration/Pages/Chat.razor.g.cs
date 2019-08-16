#pragma checksum "/Users/brett/Documents/projects/blazor/blazortest/Pages/Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3826965de14c399ca331ae90a3f44cba563e6663"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazortest.Pages
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
#line 2 "/Users/brett/Documents/projects/blazor/blazortest/Pages/Chat.razor"
using blazortest.Data;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 19 "/Users/brett/Documents/projects/blazor/blazortest/Pages/Chat.razor"
 
    string Message;
    string UserName;
    List<string> ChatMessages = new List<string>();

    protected override async Task OnInitAsync()
    {
        Service.MessageReceived += ReceiveMessage;
    }

    private void ReceiveMessage(string message)
    {
        ChatMessages.Add(message);
        Invoke(StateHasChanged);
    }

    private void SendMessage()
    {
        if(!string.IsNullOrEmpty(Message))
        {
            Service.Send($"{UserName}: {Message}");
            Message = string.Empty;
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChatService Service { get; set; }
    }
}
#pragma warning restore 1591

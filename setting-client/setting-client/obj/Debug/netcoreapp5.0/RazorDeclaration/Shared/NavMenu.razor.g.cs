#pragma checksum "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ca724cef41aaf9616453683080fded8283826cd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace setting_client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using setting_client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\_Imports.razor"
using setting_client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Development\gumi\CSharp\dotnet_core\project\setting-client\setting-client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

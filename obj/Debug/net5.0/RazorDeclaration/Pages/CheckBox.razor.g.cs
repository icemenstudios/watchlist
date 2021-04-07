// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WatchList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using WatchList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using WatchList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/Icemen/Projects/PracticeProjects/WatchList/_Imports.razor"
using WatchList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/CheckBox.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/CheckBox.razor"
using WatchList.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkbox")]
    public partial class CheckBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/CheckBox.razor"
       

    private List<Entertainment> movies = new List<Entertainment>();
    private Entertainment selectedMovie;


    protected override async Task OnInitializedAsync()
    {

        movies = await MoviesService.GetMovies("Avengers");

    }

    private async Task<IEnumerable<Entertainment>> searchMovies(string searchTerm)
    {

        return await Task.FromResult(movies.Where(x => x.Title.ToLower().Contains(searchTerm.ToLower())).ToList());
        

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiGetMoviesService MoviesService { get; set; }
    }
}
#pragma warning restore 1591
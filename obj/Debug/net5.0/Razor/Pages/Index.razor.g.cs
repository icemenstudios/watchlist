#pragma checksum "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e12f43b3d4e4cea6cfcb8f7166c57229cb063f75"
// <auto-generated/>
#pragma warning disable 1591
namespace WatchList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 3 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
using WatchList.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
using WatchList.Components.Tabs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-xi3vx1uhy1");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-xi3vx1uhy1");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mb-3 col");
            __builder.AddAttribute(8, "b-xi3vx1uhy1");
            __builder.AddMarkupContent(9, "<label for=\"searchInput\" class=\"form-label\" b-xi3vx1uhy1>Search for a title</label>\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 16 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                            searchTerm

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                                   GetSearchEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 16 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                                                             () => searchTerm = null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-xi3vx1uhy1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.AddAttribute(20, "b-xi3vx1uhy1");
            __builder.OpenComponent<WatchList.Components.Tabs.TabControl>(21);
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<WatchList.Components.Tabs.TabPage>(23);
                __builder2.AddAttribute(24, "Text", "Search results");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 24 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                 if (movies?.Count != 0 && movies != null)
                {


#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(26, "div");
                    __builder3.AddAttribute(27, "class", "col");
                    __builder3.AddAttribute(28, "b-xi3vx1uhy1");
                    __builder3.OpenElement(29, "ul");
                    __builder3.AddAttribute(30, "class", "list-unstyled mt-3");
                    __builder3.AddAttribute(31, "b-xi3vx1uhy1");
#nullable restore
#line 29 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                             foreach (Entertainment movie in movies)
                            {
                                if (movie.Poster != "N/A")
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(32, "li");
                    __builder3.AddAttribute(33, "class", "media mb-3 link");
                    __builder3.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                          () => addMovie(movie)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "b-xi3vx1uhy1");
                    __builder3.OpenElement(36, "img");
                    __builder3.AddAttribute(37, "src", 
#nullable restore
#line 34 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                   movie.Poster

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(38, "class", "mr-3 img-fluid");
                    __builder3.AddAttribute(39, "width", "64");
                    __builder3.AddAttribute(40, "alt", 
#nullable restore
#line 34 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                                                         movie.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(41, "b-xi3vx1uhy1");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\n                                        ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "media-body");
                    __builder3.AddAttribute(45, "b-xi3vx1uhy1");
                    __builder3.OpenElement(46, "h5");
                    __builder3.AddAttribute(47, "class", "mt-0 mb-1");
                    __builder3.AddAttribute(48, "b-xi3vx1uhy1");
                    __builder3.AddContent(49, 
#nullable restore
#line 36 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                   movie.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\n                                            ");
                    __builder3.OpenElement(51, "small");
                    __builder3.AddAttribute(52, "b-xi3vx1uhy1");
                    __builder3.AddContent(53, 
#nullable restore
#line 37 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                    movie.Type

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "<br b-xi3vx1uhy1>\n                                            ");
                    __builder3.OpenElement(55, "small");
                    __builder3.AddAttribute(56, "b-xi3vx1uhy1");
                    __builder3.AddContent(57, "Release: ");
                    __builder3.AddContent(58, 
#nullable restore
#line 38 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                             movie.Year

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 42 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 47 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(59, "<div class=\"col mt-3\" b-xi3vx1uhy1><p b-xi3vx1uhy1> No result </p></div>");
#nullable restore
#line 55 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddComponentReferenceCapture(60, (__value) => {
#nullable restore
#line 22 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                           searchResult = (WatchList.Components.Tabs.TabPage)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\n            ");
                __builder2.OpenComponent<WatchList.Components.Tabs.TabPage>(62);
                __builder2.AddAttribute(63, "Text", "Watch list");
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "id", "watchlist");
                    __builder3.AddAttribute(67, "class", "col-sm");
                    __builder3.AddAttribute(68, "b-xi3vx1uhy1");
#nullable restore
#line 61 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                     if (myList.Count != 0)
                    {


#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(69, "<h4 class=\"mt-3\" b-xi3vx1uhy1> My watchlist </h4>");
                    __builder3.OpenElement(70, "div");
                    __builder3.AddAttribute(71, "id", "filters");
                    __builder3.AddAttribute(72, "class", "btn-group col-sm-12");
                    __builder3.AddAttribute(73, "role", "group");
                    __builder3.AddAttribute(74, "aria-label", "Basic example");
                    __builder3.AddAttribute(75, "b-xi3vx1uhy1");
                    __builder3.OpenElement(76, "button");
                    __builder3.AddAttribute(77, "type", "button");
                    __builder3.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                            () => orderBy("Title")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "class", "btn btn-secondary");
                    __builder3.AddAttribute(80, "b-xi3vx1uhy1");
                    __builder3.AddContent(81, " Title ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\n\n                            ");
                    __builder3.OpenElement(83, "button");
                    __builder3.AddAttribute(84, "type", "button");
                    __builder3.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                            () => orderBy("Runtime")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "class", "btn btn-secondary");
                    __builder3.AddAttribute(87, "b-xi3vx1uhy1");
                    __builder3.AddContent(88, " Runtime ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\n\n                            ");
                    __builder3.OpenElement(90, "button");
                    __builder3.AddAttribute(91, "type", "button");
                    __builder3.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                            () => orderBy("Ratings")

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "class", "btn btn-secondary");
                    __builder3.AddAttribute(94, "b-xi3vx1uhy1");
                    __builder3.AddContent(95, " Ratings ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.OpenElement(96, "ul");
                    __builder3.AddAttribute(97, "class", "list-unstyled mt-3");
                    __builder3.AddAttribute(98, "b-xi3vx1uhy1");
#nullable restore
#line 78 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                             foreach (var item in myList)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(99, "li");
                    __builder3.AddAttribute(100, "class", "media mb-3");
                    __builder3.AddAttribute(101, "b-xi3vx1uhy1");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(102);
                    __builder3.AddAttribute(103, "href", 
#nullable restore
#line 81 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                     $"/detail/{item.ImdbID}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(105, "img");
                        __builder4.AddAttribute(106, "src", 
#nullable restore
#line 82 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                   item.Poster

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(107, "class", "mr-3 img-fluid");
                        __builder4.AddAttribute(108, "width", "64");
                        __builder4.AddAttribute(109, "alt", 
#nullable restore
#line 82 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                                                        item.Title

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(110, "b-xi3vx1uhy1");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(111, "\n                                    ");
                    __builder3.OpenElement(112, "div");
                    __builder3.AddAttribute(113, "class", "media-body");
                    __builder3.AddAttribute(114, "b-xi3vx1uhy1");
                    __builder3.OpenElement(115, "h5");
                    __builder3.AddAttribute(116, "class", "mt-0 mb-1");
                    __builder3.AddAttribute(117, "b-xi3vx1uhy1");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(118);
                    __builder3.AddAttribute(119, "href", 
#nullable restore
#line 85 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                                 $"/detail/{ item.ImdbID}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(121, 
#nullable restore
#line 85 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                                                                               item.Title

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(122, "\n                                        ");
                    __builder3.OpenElement(123, "small");
                    __builder3.AddAttribute(124, "b-xi3vx1uhy1");
                    __builder3.AddContent(125, 
#nullable restore
#line 86 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                 item.Runtime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(126, " |\n                                        ");
                    __builder3.OpenElement(127, "small");
                    __builder3.AddAttribute(128, "b-xi3vx1uhy1");
                    __builder3.AddContent(129, " Rating: ");
                    __builder3.AddContent(130, 
#nullable restore
#line 87 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                         item.Rate

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(131, "\n                                        ");
                    __builder3.OpenElement(132, "button");
                    __builder3.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                                                          () => deleteMovie(item)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(134, "class", "btn btn-danger float-right");
                    __builder3.AddAttribute(135, "b-xi3vx1uhy1");
                    __builder3.AddContent(136, " Delete ");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
#nullable restore
#line 91 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"

                            }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 94 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.AddComponentReferenceCapture(137, (__value) => {
#nullable restore
#line 57 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                           watchListPage = (WatchList.Components.Tabs.TabPage)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(138, (__value) => {
#nullable restore
#line 21 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
                          controlTab = (WatchList.Components.Tabs.TabControl)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 188 "/Users/Icemen/Projects/PracticeProjects/WatchList/Pages/Index.razor"
       

    private List<Entertainment> movies = new List<Entertainment>();
    List<Entertainment> myList = new List<Entertainment>();
    string searchTerm = "";
    bool toggle = true;
    bool watchListReturn = false;

    private TabControl controlTab;
    private TabPage watchListPage;
    private TabPage searchResult;

   



    async void GetSearchEvent(ChangeEventArgs args)
    {
        searchTerm = args.Value.ToString();
        if (searchTerm != "" || searchTerm != null)
        {
            movies = await MoviesService.GetMovies(searchTerm);
        }
        else
        {
            movies = null;
        }
        controlTab.ActivatePage(searchResult);
        StateHasChanged();
    }
    [Parameter]
    public EventCallback onAddList { get; set; }

    private async Task addMovie(Entertainment e)
    {
        Entertainment selectedMovie = new Entertainment();

        selectedMovie = await MoviesService.GetMovie(e.ImdbID);
        myList.Add(selectedMovie);
        movies.Remove(e);

        await ProtectedSessionStore.SetAsync("myList", myList);

        controlTab.ActivatePage(watchListPage);


    }

    private async Task deleteMovie(Entertainment e)
    {
        myList.Remove(e);
        movies.Add(e);
        await ProtectedSessionStore.SetAsync("myList", myList);
    }

    protected override async Task OnInitializedAsync()
    {
        var result = await ProtectedSessionStore.GetAsync<List<Entertainment>>("myList");
        var resultTab = await ProtectedSessionStore.GetAsync<bool>("watchListReturn");
        if (result.Value != null)
        {
            myList = result.Value;
            StateHasChanged();
        }

        if (resultTab.Value != false)
        {
            controlTab.ActivatePage(watchListPage);
        }

    }


    private async Task orderBy(string orderName)
    {
        toggle = !toggle;

        switch (orderName)
        {
            case "Runtime":
                if (toggle)
                {
                    myList = myList.OrderBy(x => int.Parse(x.Runtime.Replace("min", ""))).ToList();

                }
                else
                {
                    myList = myList.OrderByDescending(x => int.Parse(x.Runtime.Replace("min", ""))).ToList();

                }

                break;
            case "Title":
                if (toggle)
                {
                    myList = myList.OrderBy(x => x.Title).ToList();
                }
                else
                {
                    myList = myList.OrderByDescending(x => x.Title).ToList();
                }
                break;
            case "Ratings":
                if (toggle)
                {
                    myList = myList.OrderBy(x => decimal.Parse(x.Rate.Replace("/10", ""))).ToList();
                }
                else
                {
                    myList = myList.OrderByDescending(x => decimal.Parse(x.Rate.Replace("/10", ""))).ToList();
                }
                break;
            default:
                myList = myList.OrderBy(x => x.Title).ToList();
                break;
        }

        await ProtectedSessionStore.SetAsync("myList", myList);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiGetMoviesService MoviesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a70325fd7abfd0010fdf955eb323443d18fcc044"
// <auto-generated/>
#pragma warning disable 1591
namespace dotnetcoreapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using dotnetcoreapp;
    using dotnetcoreapp.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Jokes : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "progress status-loader");
            builder.AddContent(2, "\n");
#line 4 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
     if (IsBusy == true)
    {


#line default
#line hidden
            builder.AddContent(3, "        ");
            builder.AddMarkupContent(4, "<div class=\"progress-bar progress-bar-striped progress-bar-animated\" aria-valuenow=\"100\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 100%\">\n            Loading joke!\n        </div>\n");
#line 10 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.AddMarkupContent(6, "<p>This component demonstrates fetching data from the server.</p>\n");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "btn-toolbar mb-3");
            builder.AddContent(9, "\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "input-group mr-2");
            builder.AddContent(12, "\n        ");
            builder.AddMarkupContent(13, "<div class=\"input-group-prepend\">\n            <div class=\"input-group-text\" id=\"btnGroupAddon\">\n                <span class=\"oi oi-fork\" aria-hidden=\"true\"></span>\n            </div>\n        </div>\n        ");
            builder.OpenElement(14, "select");
            builder.AddAttribute(15, "class", "form-control");
            builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(categorySelected));
            builder.AddContent(17, "\n            ");
            builder.AddMarkupContent(18, "<option value=\"\">-- Select Category --</option>\n");
#line 23 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
             foreach (var category in categories)
            {

#line default
#line hidden
            builder.AddContent(19, "                ");
            builder.OpenElement(20, "option");
            builder.AddAttribute(21, "value", category);
            builder.AddContent(22, category);
            builder.CloseElement();
            builder.AddContent(23, "\n");
#line 26 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
            }

#line default
#line hidden
            builder.AddContent(24, "        ");
            builder.CloseElement();
            builder.AddContent(25, "\n    ");
            builder.CloseElement();
            builder.AddContent(26, "\n    ");
            builder.OpenElement(27, "div");
            builder.AddAttribute(28, "class", "btn-group" + " " + (@jokes.Count > 0 || @searchResults.total > 0 ? "mr-2" : "mr-auto"));
            builder.AddContent(29, "\n        ");
            builder.OpenElement(30, "button");
            builder.AddAttribute(31, "class", "btn btn-primary");
            builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(FetchJoke));
            builder.AddAttribute(33, "disabled", IsBusy);
            builder.AddMarkupContent(34, "\n            <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Fetch a Joke!\n        ");
            builder.CloseElement();
            builder.AddContent(35, "\n    ");
            builder.CloseElement();
            builder.AddContent(36, "\n");
#line 34 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
     if(jokes.Count > 0 || searchResults.total > 0)
    {

#line default
#line hidden
            builder.AddContent(37, "        ");
            builder.OpenElement(38, "div");
            builder.AddAttribute(39, "class", "btn-group mr-auto");
            builder.AddContent(40, "\n            ");
            builder.OpenElement(41, "button");
            builder.AddAttribute(42, "class", "btn btn-outline-danger");
            builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(RemoveJokes));
            builder.AddAttribute(44, "disabled", IsBusy);
            builder.AddMarkupContent(45, "\n                <span class=\"oi oi-trash\" aria-hidden=\"true\"></span> Clear all\n            ");
            builder.CloseElement();
            builder.AddContent(46, "\n        ");
            builder.CloseElement();
            builder.AddContent(47, "\n");
#line 41 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
    }

#line default
#line hidden
            builder.AddContent(48, "    ");
            builder.OpenElement(49, "div");
            builder.AddAttribute(50, "class", "input-group");
            builder.AddContent(51, "\n        ");
            builder.OpenElement(52, "input");
            builder.AddAttribute(53, "type", "text");
            builder.AddAttribute(54, "class", "form-control");
            builder.AddAttribute(55, "placeholder", "Search for joke content!");
            builder.AddAttribute(56, "aria-label", "Search for joke content!");
            builder.AddAttribute(57, "aria-describedby", "basic-addon2");
            builder.AddAttribute(58, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(searchQuery));
            builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => searchQuery = __value, searchQuery));
            builder.CloseElement();
            builder.AddContent(60, "\n        ");
            builder.OpenElement(61, "div");
            builder.AddAttribute(62, "class", "input-group-append");
            builder.AddContent(63, "\n            ");
            builder.OpenElement(64, "button");
            builder.AddAttribute(65, "class", "input-group-text btn");
            builder.AddAttribute(66, "id", "basic-addon2");
            builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(getSearch));
            builder.AddMarkupContent(68, "\n                <span class=\"oi oi-magnifying-glass\"></span>\n            ");
            builder.CloseElement();
            builder.AddContent(69, "\n        ");
            builder.CloseElement();
            builder.AddContent(70, "\n    ");
            builder.CloseElement();
            builder.AddContent(71, "\n");
            builder.CloseElement();
            builder.AddContent(72, "\n\n\n");
            builder.OpenElement(73, "div");
            builder.AddAttribute(74, "class", "container-fluid");
            builder.AddContent(75, "\n    ");
            builder.OpenElement(76, "div");
            builder.AddAttribute(77, "class", "row increased");
            builder.AddContent(78, "\n");
#line 64 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
         foreach (var item in jokes)
        {

#line default
#line hidden
            builder.AddContent(79, "            ");
            builder.OpenElement(80, "div");
            builder.AddAttribute(81, "class", "card-wrap col-md-3 ");
            builder.AddContent(82, "\n                ");
            builder.OpenElement(83, "div");
            builder.AddAttribute(84, "class", "card animated zoomIn");
            builder.AddContent(85, "\n                    ");
            builder.OpenElement(86, "div");
            builder.AddAttribute(87, "class", "card-body");
            builder.AddContent(88, "\n                        ");
            builder.OpenElement(89, "p");
            builder.AddAttribute(90, "class", "card-text");
            builder.AddContent(91, "\n                            ");
            builder.AddContent(92, item.value);
            builder.AddContent(93, "\n                        ");
            builder.CloseElement();
            builder.AddContent(94, "\n                        ");
            builder.OpenElement(95, "button");
            builder.AddAttribute(96, "class", "btn btn-outline-danger");
            builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(() => RemoveJoke(@item.fetchIndex)));
            builder.AddMarkupContent(98, "\n                            <span class=\"oi oi-x\" aria-hidden=\"true\"></span>\n                        ");
            builder.CloseElement();
            builder.AddContent(99, "\n                    ");
            builder.CloseElement();
            builder.AddContent(100, "\n                ");
            builder.CloseElement();
            builder.AddContent(101, "\n            ");
            builder.CloseElement();
            builder.AddContent(102, "\n");
#line 80 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
        }

#line default
#line hidden
            builder.AddContent(103, "        ");
#line 81 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
         if(searchResults.total > 0)
        {
            

#line default
#line hidden
#line 83 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
             foreach (var item in searchResults.result)
            {

#line default
#line hidden
            builder.AddContent(104, "                ");
            builder.OpenElement(105, "div");
            builder.AddAttribute(106, "class", "card-wrap col-md-3 ");
            builder.AddContent(107, "\n                    ");
            builder.OpenElement(108, "div");
            builder.AddAttribute(109, "class", "card animated zoomIn");
            builder.AddContent(110, "\n                        ");
            builder.OpenElement(111, "div");
            builder.AddAttribute(112, "class", "card-body");
            builder.AddContent(113, "\n                            ");
            builder.OpenElement(114, "p");
            builder.AddAttribute(115, "class", "card-text");
            builder.AddContent(116, "\n                                ");
            builder.AddContent(117, item.value);
            builder.AddContent(118, "\n                            ");
            builder.CloseElement();
            builder.AddContent(119, "\n                        ");
            builder.CloseElement();
            builder.AddContent(120, "\n                    ");
            builder.CloseElement();
            builder.AddContent(121, "\n                ");
            builder.CloseElement();
            builder.AddContent(122, "\n");
#line 94 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
            }

#line default
#line hidden
#line 94 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
             
        }

#line default
#line hidden
            builder.AddContent(123, "\n    ");
            builder.CloseElement();
            builder.AddContent(124, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 100 "/home/aldin/Desktop/dotnetcoreapp/Pages/Jokes.cshtml"
            
    ChuckJoke joke;
    IList<ChuckJoke> jokes = new List<ChuckJoke>();
    int index=0;
    bool IsBusy = false;
    IList<string> categories = new List<string>();
    string category;
    public string searchQuery { get; set; }
    SearchResults searchResults = new SearchResults();

    //Fetch random joke https://api.chucknorris.io/jokes/random

    protected async Task FetchJoke()
    {
        IsBusy = true;
        if(category != "")
        {
            joke = await Http.GetJsonAsync<ChuckJoke>("https://api.chucknorris.io/jokes/random?category="+ category);
        }
        else
        {
            joke = await Http.GetJsonAsync<ChuckJoke>("https://api.chucknorris.io/jokes/random");
        }
        if(searchResults.total > 0)
        {
            searchResults = new SearchResults();
        }
        joke.fetchIndex = index;
        index++;
        jokes.Add(joke);
        IsBusy = false;
        StateHasChanged();
    }

    //Fetch jokes categories https://api.chucknorris.io/jokes/categories

    protected override async Task OnInitAsync()
    {
        categories = await Http.GetJsonAsync<IList<string>>("https://api.chucknorris.io/jokes/categories");
    }

    void categorySelected(UIChangeEventArgs categoryEvent)
    {
        category = categoryEvent.Value.ToString();
    }

    void EmptyCurrentJoke()
    {
        joke = null;
    }

    public void RemoveJoke(int i)
    {
        var itemToRemove = jokes.Single(j => j.fetchIndex == i);
        jokes.Remove(itemToRemove);
    }

    public void RemoveJokes()
    {
        joke = null;
        jokes.Clear();
        searchResults = new SearchResults();
    }

    public async void getSearch()
    {
        IsBusy = true;
        jokes.Clear();
        Console.WriteLine("Let's search!");
        Console.WriteLine(@searchQuery);
        searchResults = await Http.GetJsonAsync<SearchResults>("https://api.chucknorris.io/jokes/search?query="+searchQuery);
        IsBusy = false;
        StateHasChanged();
    }

    class ChuckJoke
    {
        public string icon_url { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string value { get; set; }
        public int fetchIndex { get; set; }
    }

    public class Result
    {
        public List<string> category { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }

    public class SearchResults
    {
        public int total { get; set; }
        public List<Result> result { get; set; }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

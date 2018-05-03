#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.SearchResults
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Frontend.Search.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Libraries.Model;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Libraries;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchResults/SearchResults.cshtml")]
    public partial class SearchResults : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchResultsModel>
    {
        public SearchResults()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 318), Tuple.Create("\"", 342)
            
            #line 9 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create(" ", 326), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 327), false)
);

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (@Model.Results.TotalCount > 0)
                {
                if(ViewBag.IsFilteredbyPermission)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h1>");

            
            #line 17 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                   Write(Html.HtmlSanitize(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 18 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <h1>");

            
            #line 21 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                   Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 21 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                             Write(Html.HtmlSanitize(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 22 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                <h1>");

            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
               Write(Html.Resource("No"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 26 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                    Write(Html.HtmlSanitize(Model.ResultText));

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");

            
            #line 27 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

            
            #line 30 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (Model.AllowSorting && @Model.Results.TotalCount > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <label>");

            
            #line 32 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                  Write(Html.Resource("SortBy"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <select");

WriteLiteral(" class=\"userSortDropdown\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1183), Tuple.Create("\"", 1221)
            
            #line 33 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1191), Tuple.Create<System.Object, System.Int32>(Html.Resource("SortDropdown")
            
            #line default
            #line hidden
, 1191), false)
);

WriteLiteral(">\r\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1256), Tuple.Create("\"", 1289)
            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1264), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Relevance
            
            #line default
            #line hidden
, 1264), false)
);

WriteLiteral(" ");

            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                              Write(Model.OrderBy == OrderByOptions.Relevance ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                                     Write(Html.Resource("Relevance"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1432), Tuple.Create("\"", 1462)
            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1440), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Newest
            
            #line default
            #line hidden
, 1440), false)
);

WriteLiteral(" ");

            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                           Write(Model.OrderBy == OrderByOptions.Newest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 35 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                               Write(Html.Resource("NewestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1604), Tuple.Create("\"", 1634)
            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 1612), Tuple.Create<System.Object, System.Int32>(OrderByOptions.Oldest
            
            #line default
            #line hidden
, 1612), false)
);

WriteLiteral(" ");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                           Write(Model.OrderBy == OrderByOptions.Oldest ? "selected=selected" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 36 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                               Write(Html.Resource("OldestFirst"));

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n                    </select>\r\n                </label>\r\n");

            
            #line 39 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n\r\n");

            
            #line 43 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.Languages.Length > 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div>\r\n            <span>");

            
            #line 46 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             Write(Html.Resource("ChangeResultsLanguageLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 47 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             for (var i = 0; i < Model.Languages.Length; i++)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2075), Tuple.Create("\"", 2158)
            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create<System.Object, System.Int32>(String.Format(ViewBag.LanguageSearchUrlTemplate, Model.Languages[i].Name)
            
            #line default
            #line hidden
, 2082), false)
);

WriteLiteral(">");

            
            #line 49 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                  Write(Model.Languages[i].DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 50 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                if (i < Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span>, </span>\r\n");

            
            #line 53 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
                else if (i == Model.Languages.Length - 2)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <span> ");

            
            #line 56 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                      Write(Html.Resource("OrLabel"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

            
            #line 57 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 60 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    }   

            
            #line default
            #line hidden
WriteLiteral("             \r\n    <div");

WriteLiteral(" class=\"sf-search-results media-list\"");

WriteLiteral(">\r\n");

            
            #line 63 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        
            
            #line default
            #line hidden
            
            #line 63 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
         foreach (var item in Model.Results.Data)
        {
            var hasLink = item.GetValue("Link") != null && !String.IsNullOrEmpty(item.GetValue("Link").ToString());

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media sf-media\"");

WriteLiteral(">\r\n\r\n");

            
            #line 68 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            
            
            #line default
            #line hidden
            
            #line 68 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
             if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Image).ToString())
            {
    

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"media-left sf-img-thmb\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3060), Tuple.Create("\"", 3089)
            
            #line 72 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3067), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3067), false)
);

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3117), Tuple.Create("\"", 3145)
            
            #line 73 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3123), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3123), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3146), Tuple.Create("\"", 3175)
            
            #line 73 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3152), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3152), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral("/>\r\n                </a>\r\n            </div>\r\n");

            
            #line 76 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }

            else if (((Telerik.Sitefinity.Services.Search.Model.Document)item).ItemType.ToString() == typeof(Telerik.Sitefinity.Libraries.Model.Video).ToString())
            {
                LibrariesManager librariesManager = LibrariesManager.GetManager();
                var videoTmbId = new Guid((string)item.GetValue("Id"));
                Video video = librariesManager.GetVideo(videoTmbId);
                if (video != null)
                {
                    var thumbUrl = video.ThumbnailUrl;
                

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"media-left\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"sf-video-thmb\"");

WriteLiteral(">\r\n\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3905), Tuple.Create("\"", 3934)
            
            #line 90 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3912), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 3912), false)
);

WriteLiteral(">\r\n                            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3970), Tuple.Create("\"", 3985)
            
            #line 91 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3976), Tuple.Create<System.Object, System.Int32>(thumbUrl
            
            #line default
            #line hidden
, 3976), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3986), Tuple.Create("\"", 4015)
            
            #line 91 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 3992), Tuple.Create<System.Object, System.Int32>(item.GetValue("Title")
            
            #line default
            #line hidden
, 3992), false)
);

WriteLiteral(" width=\"120\"");

WriteLiteral("/>\r\n                        \r\n                            <div");

WriteLiteral(" class=\"sf-icon-play\"");

WriteLiteral("></div>\r\n                        \r\n                        </a>\r\n                " +
"    </div>\r\n                </div>\r\n");

            
            #line 98 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            }

            else
            {

            }

            
            #line default
            #line hidden
WriteLiteral("            \r\n            \r\n            <div");

WriteLiteral(" class=\"media-body sf-media-body\"");

WriteLiteral(">\r\n\r\n                <h3>\r\n");

            
            #line 111 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 111 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                     if (hasLink)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4504), Tuple.Create("\"", 4533)
            
            #line 113 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4511), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4511), false)
);

WriteLiteral(">");

            
            #line 113 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                    Write(item.GetValue("Title"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 114 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                    }
                    else
                    {
                        
            
            #line default
            #line hidden
            
            #line 117 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                   Write(item.GetValue("Title"));

            
            #line default
            #line hidden
            
            #line 117 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                               
                    }

            
            #line default
            #line hidden
WriteLiteral("                </h3>\r\n\r\n                <p>");

            
            #line 121 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
              Write(Html.HtmlSanitize((string)item.GetValue("HighLighterResult")));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 122 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (hasLink)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4892), Tuple.Create("\"", 4921)
            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 4899), Tuple.Create<System.Object, System.Int32>(item.GetValue("Link")
            
            #line default
            #line hidden
, 4899), false)
);

WriteLiteral(">");

            
            #line 124 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                Write(item.GetValue("Link"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 125 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            </div>\r\n");

            
            #line 128 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

            
            #line 132 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
    
            
            #line default
            #line hidden
            
            #line 132 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
     if (Model.DisplayMode == ListDisplayMode.Paging && Model.TotalPagesCount != null && Model.TotalPagesCount > 1)
    {
        if(ViewBag.IsFilteredbyPermission) 
        {

            
            #line default
            #line hidden
WriteLiteral("             <ul");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

            
            #line 137 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                
            
            #line default
            #line hidden
            
            #line 137 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.CurrentPage > 1)
				{

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n\t\t\t\t\t    <a");

WriteAttribute("href", Tuple.Create(" href=\'", 5344), Tuple.Create("\'", 5421)
            
            #line 140 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5351), Tuple.Create<System.Object, System.Int32>(string.Format(ViewBag.RedirectPageUrlTemplate, Model.CurrentPage - 1)
            
            #line default
            #line hidden
, 5351), false)
);

WriteLiteral(">");

            
            #line 140 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                    Write(Html.Resource("Prev"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 142 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 143 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                 if (Model.CurrentPage < @Model.TotalPagesCount)
				{

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\'", 5610), Tuple.Create("\'", 5687)
            
            #line 146 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 5617), Tuple.Create<System.Object, System.Int32>(string.Format(ViewBag.RedirectPageUrlTemplate, Model.CurrentPage + 1)
            
            #line default
            #line hidden
, 5617), false)
);

WriteLiteral(">");

            
            #line 146 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                    Write(Html.Resource("Next"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 148 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n");

            
            #line 150 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
        else 
        {
            if (Model.CurrentPage == Model.TotalPagesCount)
            {

            
            #line default
            #line hidden
WriteLiteral("                <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 155 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                   Write((Model.ItemsPerPage * Model.TotalPagesCount) - Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 155 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                                                                                Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 156 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 159 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                  Write(Model.ItemsPerPage);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 159 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
                                                         Write(Model.Results.TotalCount);

            
            #line default
            #line hidden
WriteLiteral(" results</em>\r\n");

            
            #line 160 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
            }
            

            
            #line default
            #line hidden
WriteLiteral("            <div>\r\n");

WriteLiteral("                ");

            
            #line 163 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
           Write(Html.Action("Index", "ContentPager", new
                {
                    currentPage = Model.CurrentPage,
                    totalPagesCount = Model.TotalPagesCount,
                    redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
                }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 170 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResOrderBy\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6623), Tuple.Create("\'", 6662)
            
            #line 173 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6631), Tuple.Create<System.Object, System.Int32>(Request.QueryString["orderBy"]
            
            #line default
            #line hidden
, 6631), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResLanguage\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6725), Tuple.Create("\'", 6765)
            
            #line 174 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6733), Tuple.Create<System.Object, System.Int32>(Request.QueryString["language"]
            
            #line default
            #line hidden
, 6733), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResIndexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6834), Tuple.Create("\'", 6880)
            
            #line 175 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6842), Tuple.Create<System.Object, System.Int32>(Request.QueryString["indexCatalogue"]
            
            #line default
            #line hidden
, 6842), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResQuery\"");

WriteAttribute("value", Tuple.Create(" value=\'", 6940), Tuple.Create("\'", 6983)
            
            #line 176 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 6948), Tuple.Create<System.Object, System.Int32>(Request.QueryString["searchQuery"]
            
            #line default
            #line hidden
, 6948), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchResWordsMode\"");

WriteAttribute("value", Tuple.Create(" value=\'", 7047), Tuple.Create("\'", 7088)
            
            #line 177 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
, Tuple.Create(Tuple.Create("", 7055), Tuple.Create<System.Object, System.Int32>(Request.QueryString["wordsMode"]
            
            #line default
            #line hidden
, 7055), false)
);

WriteLiteral(" />\r\n        \r\n</div>\r\n\r\n");

            
            #line 181 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 182 "..\..MVC\Views\SearchResults\SearchResults.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchResults/Search-results.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
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

namespace ASP
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/News/Detail.News.cshtml")]
    public partial class _MVC_Views_News_Detail_News_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public _MVC_Views_News_Detail_News_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<style>\r\n    .products-container-content {\r\n        display: none;\r\n    }\r\n</styl" +
"e>\r\n\r\n<div");

WriteLiteral(" class=\"sfContentBlock\"");

WriteLiteral(">\r\n<p>");

            
            #line 10 "..\..\MVC\Views\News\Detail.News.cshtml"
Write(Html.Raw(Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n</div>\r\n\r\n");

            
            #line 13 "..\..\MVC\Views\News\Detail.News.cshtml"
 if (Model.Item.Fields.Photos != null)
{
    foreach (var photo in Model.Item.Fields.Photos)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 388), Tuple.Create("\"", 416)
            
            #line 18 "..\..\MVC\Views\News\Detail.News.cshtml"
, Tuple.Create(Tuple.Create("", 394), Tuple.Create<System.Object, System.Int32>(photo.Fields.MediaUrl
            
            #line default
            #line hidden
, 394), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n        </div>\r\n");

            
            #line 20 "..\..\MVC\Views\News\Detail.News.cshtml"
    }
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591

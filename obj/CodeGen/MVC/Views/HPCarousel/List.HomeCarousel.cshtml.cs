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
    
    #line 2 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/HPCarousel/List.HomeCarousel.cshtml")]
    public partial class _MVC_Views_HPCarousel_List_HomeCarousel_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_HPCarousel_List_HomeCarousel_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<style>\r\n    .owl-dots {\r\n        position: absolute;\r\n        bottom: 0px;\r\n  " +
"  }\r\n\r\n    .owl-nav {\r\n        display: none;\r\n    }\r\n</style>\r\n<div");

WriteLiteral(" class=\"page-section-demo\"");

WriteLiteral(">\r\n   <img");

WriteAttribute("src", Tuple.Create("  src=\"", 302), Tuple.Create("\"", 356)
, Tuple.Create(Tuple.Create("", 309), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/homepage/demo-banner.png")
, 309), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591

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
"  }\r\n\r\n    .owl-nav {\r\n        display: none;\r\n    }\r\n</style>\r\n\r\n<div");

WriteLiteral(" class=\"page-section-demo herobanner-owl-carousel owl-carousel\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 391), Tuple.Create("\"", 422)
            
            #line 18 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
, Tuple.Create(Tuple.Create("", 398), Tuple.Create<System.Object, System.Int32>(item.Fields.RedirectUrl
            
            #line default
            #line hidden
, 398), false)
);

WriteLiteral(" class=\"page-section-demo-item\"");

WriteLiteral(">\r\n\r\n");

            
            #line 20 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
             foreach (var photo in item.Fields.Photo)
            {

            
            #line default
            #line hidden
WriteLiteral("                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 549), Tuple.Create("\"", 577)
            
            #line 22 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
, Tuple.Create(Tuple.Create("", 555), Tuple.Create<System.Object, System.Int32>(photo.Fields.MediaUrl
            
            #line default
            #line hidden
, 555), false)
);

WriteLiteral(" />\r\n");

            
            #line 23 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 24 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
             if (item.Fields.FullPhotoBanner != true)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"page-section-demo-item-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"page-section-demo-item-content-title\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"page-section-demo-item-content-title__text1\"");

WriteLiteral(">\r\n                            <span>");

            
            #line 29 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
                             Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n            " +
"        <div");

WriteLiteral(" class=\"page-section-demo-item-content-text2\"");

WriteLiteral(">\r\n                        <p>");

            
            #line 33 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
                      Write(item.Fields.SubTitle);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");

            
            #line 36 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            \r\n        </a>\r\n");

            
            #line 39 "..\..\MVC\Views\HPCarousel\List.HomeCarousel.cshtml"

        
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
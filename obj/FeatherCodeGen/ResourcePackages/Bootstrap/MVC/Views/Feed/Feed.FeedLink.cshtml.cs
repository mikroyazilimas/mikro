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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Feed
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
    
    #line 3 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
    using Telerik.Sitefinity.Frontend.Publishing.Mvc.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Feed/Feed.FeedLink.cshtml")]
    public partial class Feed_FeedLink : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Publishing.Mvc.Models.FeedViewModel>
    {
        public Feed_FeedLink()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 135), Tuple.Create("\"", 158)
            
            #line 5 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 143), false)
);

WriteLiteral(">\n");

            
            #line 6 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
 if ((Model.InsertionOption == FeedInsertionOption.PageOnly || Model.InsertionOption == FeedInsertionOption.PageAndAddressBar) && !string.IsNullOrEmpty(Model.Url))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 333), Tuple.Create("\"", 350)
            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 340), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 340), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 351), Tuple.Create("\"", 373)
            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 359), Tuple.Create<System.Object, System.Int32>(Model.Tooltip
            
            #line default
            #line hidden
, 359), false)
);

WriteLiteral(" ");

            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
                                            Write(Model.OpenInNewWindow ? "target=_blank" : "");

            
            #line default
            #line hidden
WriteLiteral("><span");

WriteLiteral(" class=\"sf-icon-feed\"");

WriteLiteral("></span>");

            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
                                                                                                                             Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 9 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591

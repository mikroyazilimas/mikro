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
    
    #line 3 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 4 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
    using Telerik.Sitefinity.Pages.Model;
    
    #line default
    #line hidden
    
    #line 6 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.PageMenu.cshtml")]
    public partial class _MVC_Views_Navigation_NavigationView_PageMenu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _MVC_Views_Navigation_NavigationView_PageMenu_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 8 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
  SitefinityWebApp.Library.ToolsSF t = new SitefinityWebApp.Library.ToolsSF();

    var manager = PageManager.GetManager();
    PageManager pm = new PageManager();
    PageSiteNode current = SiteMapBase.GetActualCurrentNode();
    string selectTab = "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 16 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
 foreach (var item in t.GetMegaMenu(current.ParentNode.Url))
{
    if (item.UrlName == current.UrlName)
    { selectTab = " select-tab"; }
    else
    { selectTab = ""; }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 630), Tuple.Create("\"", 689)
            
            #line 22 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
, Tuple.Create(Tuple.Create("", 638), Tuple.Create<System.Object, System.Int32>(String.Format("page-right-menu-item{0}",selectTab)
            
            #line default
            #line hidden
, 638), false)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 703), Tuple.Create("\"", 740)
            
            #line 23 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
, Tuple.Create(Tuple.Create("", 710), Tuple.Create<System.Object, System.Int32>(item.GetUrl().Replace("~","")
            
            #line default
            #line hidden
, 710), false)
);

WriteLiteral(">");

            
            #line 23 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
                                            Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n");

            
            #line 25 "..\..\MVC\Views\Navigation\NavigationView.PageMenu.cshtml"
    
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591

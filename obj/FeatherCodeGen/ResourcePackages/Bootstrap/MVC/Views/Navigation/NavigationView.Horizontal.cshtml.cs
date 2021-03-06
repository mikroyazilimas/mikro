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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.Navigation
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
    
    #line 3 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.Horizontal.cshtml")]
    public partial class NavigationView_Horizontal : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 40 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 41 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 
    if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-toggle\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 45 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                         WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n            </a>\r\n            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 49 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </ul>\r\n        </li>\r\n");


#line 52 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1993), Tuple.Create("\"", 2016)

#line 55 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2001), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 2001), false)
);

WriteLiteralTo(__razor_helper_writer, "><a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2020), Tuple.Create("\"", 2036)

#line 55 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2027), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 2027), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2037), Tuple.Create("\"", 2062)

#line 55 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 2046), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 55 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                    WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></li>\r\n");


#line 56 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
    }


#line default
#line hidden
});

#line 57 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

#line 60 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 61 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "             <li");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-submenu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2385), Tuple.Create("\"", 2406)

#line 67 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2392), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2392), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2407), Tuple.Create("\"", 2437)

#line 67 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2416), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2416), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 67 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                </a>\r\n                <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 71 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </ul>\r\n            </li>\r\n");


#line 74 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2729), Tuple.Create("\"", 2757)

#line 77 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2737), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2737), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2779), Tuple.Create("\"", 2800)

#line 78 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2786), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2786), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2801), Tuple.Create("\"", 2831)

#line 78 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 2810), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2810), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 78 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </li>\r\n");


#line 80 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
        }
    }


#line default
#line hidden
});

#line 82 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

#line 85 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 86 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 90 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 90 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 94 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 94 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 96 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
}
#line default
#line hidden

        public NavigationView_Horizontal()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Bootstrap/js/bootstrap.min.js"), "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 399), Tuple.Create("\"", 422)
            
            #line 11 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
, Tuple.Create(Tuple.Create("", 407), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 407), false)
);

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n\r\n    <nav");

WriteLiteral(" class=\"navbar navbar-default\"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n              <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\"#bs-example-navbar-collapse-1\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle navigation</span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n              </button>\r\n              <a");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Brand</a>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"collapse navbar-collapse\"");

WriteLiteral(" id=\"bs-example-navbar-collapse-1\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 29 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                     foreach (var node in Model.Nodes)
                    {
                        
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                   Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\Navigation\NavigationView.Horizontal.cshtml"
                                                  ;
                    }

            
            #line default
            #line hidden
WriteLiteral("              </ul>\r\n            </div><!-- /.navbar-collapse -->\r\n        </div>" +
"<!-- /.container-fluid -->\r\n    </nav>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591

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
    
    #line 3 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.Pills.cshtml")]
    public partial class NavigationView_Pills : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 23 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 24 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 790), Tuple.Create("\"", 822)
, Tuple.Create(Tuple.Create("", 798), Tuple.Create("dropdown", 798), true)

#line 25 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 806), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 807), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 26 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        

#line default
#line hidden

#line 26 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteLiteralTo(__razor_helper_writer, " href=\"#\"");

WriteLiteralTo(__razor_helper_writer, " data-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-toggle expandable-node\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 28 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                         WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n            </a>\r\n");

WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 32 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </ul>\r\n");


#line 34 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1199), Tuple.Create("\"", 1215)

#line 37 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1206), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1206), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1216), Tuple.Create("\"", 1241)

#line 37 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1225), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1225), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 37 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                            WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 38 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\r\n");


#line 40 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"


#line default
#line hidden
});

#line 40 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 43 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 44 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    foreach (var childNode in node.ChildNodes)
    {
        if(childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "             <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1528), Tuple.Create("\"", 1573)
, Tuple.Create(Tuple.Create("", 1536), Tuple.Create("dropdown-submenu", 1536), true)

#line 49 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1552), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 1553), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1595), Tuple.Create("\"", 1616)

#line 50 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1602), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 1602), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1617), Tuple.Create("\"", 1647)

#line 50 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1626), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 1626), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 50 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"right-caret\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n                </a>\r\n                <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 54 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </ul>\r\n            </li>\r\n");


#line 57 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1939), Tuple.Create("\"", 1967)

#line 60 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1947), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 1947), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1989), Tuple.Create("\"", 2010)

#line 61 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1996), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 1996), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 2011), Tuple.Create("\"", 2041)

#line 61 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 2020), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 2020), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 61 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </li>\r\n");


#line 63 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
    }


#line default
#line hidden
});

#line 65 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 68 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 69 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 73 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 73 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 77 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 77 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 79 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

        public NavigationView_Pills()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 9 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Bootstrap/js/bootstrap.min.js"), "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 406), Tuple.Create("\"", 429)
            
            #line 11 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 414), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 414), false)
);

WriteLiteral(">\r\n    ");

WriteLiteral("\r\n\r\n    <ul");

WriteLiteral(" class=\"nav nav-pills\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
         foreach (var node in Model.Nodes)
        {
            
            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
       Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                      ;
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 81 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.WidgetContent("MVC/Scripts/Navigation/pills.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591

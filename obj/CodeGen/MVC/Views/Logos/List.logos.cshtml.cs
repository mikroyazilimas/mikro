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
    
    #line 3 "..\..\MVC\Views\Logos\List.logos.cshtml"
    using SitefinityWebApp.Mvc.Models.ViewModel;
    
    #line default
    #line hidden
    
    #line 2 "..\..\MVC\Views\Logos\List.logos.cshtml"
    using Telerik.Sitefinity.DynamicModules.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Logos/List.logos.cshtml")]
    public partial class _MVC_Views_Logos_List_logos_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_Logos_List_logos_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\MVC\Views\Logos\List.logos.cshtml"
  
    List<KeyValuePair<string, List<KeyValuePair<string, string>>>> items = Model.Items.OrderBy(p => p.Fields.GroupOrder).GroupBy(p => p.Fields.Group.ToString()).Select(x => new KeyValuePair<string, List<KeyValuePair<string, string>>>
    (
        x.Key,
        x.Select(xx => new KeyValuePair<string, string>
        (
            xx.Fields.ImageTitle,
            ((Telerik.Sitefinity.Frontend.Mvc.Models.ItemViewModel)xx.Fields.Image).Fields.MediaUrl
        )).ToList()
    )).ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    .logo-content-item {\r\n        display: inline-block;\r\n    }\r\n</style>\r\n\r\n<" +
"div");

WriteLiteral(" class=\"logo-title\"");

WriteLiteral(">\r\n    <h2>MİKRO YAZILIM\'DA DEĞİŞİM DÖNEMİ!</h2>\r\n</div>\r\n<div");

WriteLiteral(" class=\"logo-content\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\MVC\Views\Logos\List.logos.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\MVC\Views\Logos\List.logos.cshtml"
     foreach (var item in items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"logo-content-item-group\"");

WriteLiteral(" style=\"width:100%;padding: 0px 10px;margin-bottom: 40px;\"");

WriteLiteral(">\r\n            <h2");

WriteLiteral(" style=\"border-bottom:1px solid #ccc;/* margin-bottom:30px; */padding-bottom:5px;" +
"\"");

WriteLiteral(">");

            
            #line 29 "..\..\MVC\Views\Logos\List.logos.cshtml"
                                                                                             Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n            <div");

WriteLiteral(" class=\"logo-content-items\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\MVC\Views\Logos\List.logos.cshtml"
                
            
            #line default
            #line hidden
            
            #line 31 "..\..\MVC\Views\Logos\List.logos.cshtml"
                 foreach (var photo in item.Value)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"logo-content-item\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1341), Tuple.Create("\"", 1360)
            
            #line 34 "..\..\MVC\Views\Logos\List.logos.cshtml"
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create<System.Object, System.Int32>(photo.Value
            
            #line default
            #line hidden
, 1348), false)
);

WriteLiteral(" download>\r\n                            <div");

WriteLiteral(" class=\"logo-content-item-img\"");

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1474), Tuple.Create("\"", 1492)
            
            #line 36 "..\..\MVC\Views\Logos\List.logos.cshtml"
, Tuple.Create(Tuple.Create("", 1480), Tuple.Create<System.Object, System.Int32>(photo.Value
            
            #line default
            #line hidden
, 1480), false)
);

WriteLiteral(" style=\"border: 1px solid #cecece;\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"logo-content-item-title\"");

WriteLiteral(">\r\n                                <span>");

            
            #line 39 "..\..\MVC\Views\Logos\List.logos.cshtml"
                                 Write(photo.Key);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n      " +
"              </div>\r\n");

            
            #line 43 "..\..\MVC\Views\Logos\List.logos.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n");

            
            #line 46 "..\..\MVC\Views\Logos\List.logos.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591

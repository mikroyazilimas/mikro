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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/BasinOdasi/List.BasinOdasi.cshtml")]
    public partial class _MVC_Views_BasinOdasi_List_BasinOdasi_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_BasinOdasi_List_BasinOdasi_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\n    .container-sub-content-item-content-left a { text-decoration: none; color:" +
" #3b475a; }\r\n</style>\r\n\r\n<div");

WriteLiteral(" class=\"container-sub\"");

WriteLiteral(">\r\n    \r\n    <div");

WriteLiteral(" class=\"container-sub-content\"");

WriteLiteral(">\r\n        <!-- DÖNGÜ -->\r\n");

            
            #line 11 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
         foreach (var item in Model.Items.OrderByDescending(x => (DateTime?)x.Fields.FileDateTime))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"container-sub-content-item\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"container-sub-content-item-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"container-sub-content-item-content-left\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 631), Tuple.Create("\"", 676)
            
            #line 16 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
, Tuple.Create(Tuple.Create("", 638), Tuple.Create<System.Object, System.Int32>(String.Format("{0}", item.DefaultUrl)
            
            #line default
            #line hidden
, 638), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"container-sub-content-item-content-left__date\"");

WriteLiteral(">\r\n");

            
            #line 18 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 18 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
                                 if (item.Fields.FileDateTime != null && (DateTime?)item.Fields.FileDateTime != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span>");

            
            #line 20 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
                                      Write(((DateTime?)item.Fields.FileDateTime).Value.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("tr-TR")));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 21 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </div>\r\n                            <div");

WriteLiteral(" class=\"container-sub-content-item-content-left__title\"");

WriteLiteral(">\r\n                                <span>");

            
            #line 24 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
                                 Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"container-sub-content-item-content-left__text\"");

WriteLiteral(">\r\n                                <span>");

            
            #line 27 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
                                 Write(item.Fields.ShortText);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </div>\r\n                        </a>\r\n      " +
"              </div>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1644), Tuple.Create("\"", 1689)
            
            #line 31 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
, Tuple.Create(Tuple.Create("", 1651), Tuple.Create<System.Object, System.Int32>(String.Format("{0}", item.DefaultUrl)
            
            #line default
            #line hidden
, 1651), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"container-sub-content-item-content-right\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fas fa-eye container-sub-content-item-content-rigth__icon\"");

WriteLiteral("></i>\r\n                            <div");

WriteLiteral(" class=\"container-sub-content-item-content-right__title\"");

WriteLiteral(">\r\n                                <span>Detayı Gör</span>\r\n                     " +
"       </div>\r\n                        </div>\r\n                    </a>\r\n       " +
"         </div>\r\n            </div>\r\n");

            
            #line 41 "..\..\MVC\Views\BasinOdasi\List.BasinOdasi.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <!-- //// -->\r\n    </div>\r\n</div>\r\n\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
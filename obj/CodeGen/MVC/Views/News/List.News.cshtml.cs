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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/News/List.News.cshtml")]
    public partial class _MVC_Views_News_List_News_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_News_List_News_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"container-sub\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container-sub-content\"");

WriteLiteral(">\r\n        <!-- DÖNGÜ -->\r\n");

            
            #line 7 "..\..\MVC\Views\News\List.News.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\MVC\Views\News\List.News.cshtml"
         foreach (var item in Model.Items.OrderByDescending(x => (DateTime?)x.Fields.DateTime))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"container-sub-content-item\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"container-sub-content-item-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"container-sub-content-item-content-left\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"container-sub-content-item-content-left__date\"");

WriteLiteral(">\r\n");

            
            #line 13 "..\..\MVC\Views\News\List.News.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 13 "..\..\MVC\Views\News\List.News.cshtml"
                             if (item.Fields.DateTime != null && (DateTime?)item.Fields.DateTime != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>");

            
            #line 15 "..\..\MVC\Views\News\List.News.cshtml"
                                  Write(((DateTime?)item.Fields.DateTime).Value.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("tr-TR")));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 16 "..\..\MVC\Views\News\List.News.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"container-sub-content-item-content-left__title\"");

WriteLiteral(">\r\n                            <span>");

            
            #line 20 "..\..\MVC\Views\News\List.News.cshtml"
                             Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"container-sub-content-item-content-left__text\"");

WriteLiteral(">\r\n                            <span>Dijitalleşen Dünyada KOBİ’lerin En Önemli Pa" +
"rtnerlerinden Biriyiz</span>\r\n                        </div>\r\n                  " +
"  </div>\r\n");

            
            #line 26 "..\..\MVC\Views\News\List.News.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 26 "..\..\MVC\Views\News\List.News.cshtml"
                     if (item.Fields.DateTime != null && (DateTime?)item.Fields.DateCreated != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1501), Tuple.Create("\"", 1636)
            
            #line 28 "..\..\MVC\Views\News\List.News.cshtml"
, Tuple.Create(Tuple.Create("", 1508), Tuple.Create<System.Object, System.Int32>(String.Format("basinda-mikro/{0}{1}", (((DateTime?)item.Fields.DateCreated).Value.ToString("yyyy/MM/dd/")),item.Fields.UrlName)
            
            #line default
            #line hidden
, 1508), false)
);

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"container-sub-content-item-content-right\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fas fa-eye container-sub-content-item-content-rigth__icon\"");

WriteLiteral("></i>\r\n                                <div");

WriteLiteral(" class=\"container-sub-content-item-content-right__title\"");

WriteLiteral(">\r\n                                    <span>Haberi Gör</span>\r\n                 " +
"               </div>\r\n                            </div>\r\n                     " +
"   </a>\r\n");

            
            #line 36 "..\..\MVC\Views\News\List.News.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n");

            
            #line 41 "..\..\MVC\Views\News\List.News.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <!-- //// -->\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591

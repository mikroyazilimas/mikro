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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/KampanyalarList/List.KampanyalarList.cshtml")]
    public partial class _MVC_Views_KampanyalarList_List_KampanyalarList_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_KampanyalarList_List_KampanyalarList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"landing-content\"");

WriteLiteral(">\r\n");

            
            #line 4 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"landing-content-item\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 7 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
         foreach (var photo in item.Fields.Image)
        {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"landing-content-item__img\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 315), Tuple.Create("\"", 343)
            
            #line 10 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
, Tuple.Create(Tuple.Create("", 321), Tuple.Create<System.Object, System.Int32>(photo.Fields.MediaUrl
            
            #line default
            #line hidden
, 321), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n        </div>\r\n");

            
            #line 12 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"landing-content-item-other\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"landing-content-item-other__title\"");

WriteLiteral(">\r\n                <span>");

            
            #line 15 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
                 Write(Html.Raw(item.Fields.PageTitle));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"landing-content-item-other__description\"");

WriteLiteral(">\r\n                <p>");

            
            #line 18 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
              Write(Html.Raw(item.Fields.PageDescription));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"landing-content-item-other__button\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 805), Tuple.Create("\"", 828)
            
            #line 21 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
, Tuple.Create(Tuple.Create("", 812), Tuple.Create<System.Object, System.Int32>(item.DefaultUrl
            
            #line default
            #line hidden
, 812), false)
);

WriteLiteral(">Detay<i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></a>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");

            
            #line 26 "..\..\MVC\Views\KampanyalarList\List.KampanyalarList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591

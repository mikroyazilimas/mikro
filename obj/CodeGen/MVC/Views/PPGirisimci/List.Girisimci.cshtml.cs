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
    
    #line 2 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/PPGirisimci/List.Girisimci.cshtml")]
    public partial class _MVC_Views_PPGirisimci_List_Girisimci_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_PPGirisimci_List_Girisimci_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"products-container-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"products-container-content-left\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"scrolldown sticky-one\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"products-container-content-left__img\"");

WriteLiteral(">   \r\n                <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-run/\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 390), Tuple.Create("\"", 437)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/run-big-banner.png")
, 396), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral("></a>                 \r\n            </div> \r\n            <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-run/\"");

WriteLiteral(" class=\"products-container-content-left__text\"");

WriteLiteral(">\r\n                <span>Girişimciler İçin</span>\r\n                <span>Mikro Ru" +
"n</span>\r\n            </a>\r\n            <div");

WriteLiteral(" class=\"products-container-content-left-button\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"/ucretsiz-demo-talep\"");

WriteLiteral(" title=\"demo\"");

WriteLiteral(" class=\"products-container-content-left-button__demo\"");

WriteLiteral(">Ücretsiz Demo <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"Fiyat ve Nasıl Satın Alabilirim\"");

WriteLiteral(" class=\"products-container-content-left-button__price\"");

WriteLiteral(" >Fiyat ve Nasıl Satın Alabilirim\r\n                <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"products-container-content-right\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"shortText\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
       Write(Html.Raw(@Model.Items.Where(x => x.Fields.IsMainProduct == true).FirstOrDefault().Fields.ShortText));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

            
            #line 28 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
        
            
            #line default
            #line hidden
            
            #line 28 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
         foreach (var item in Model.Items.Where(x => x.Fields.IsMainProduct != true))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"products-container-content-right-item\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"products-container-content-right-item__title\"");

WriteLiteral(">\r\n                    <span>");

            
            #line 32 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
                     Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"products-container-content-right-item__text\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
               Write(Html.Raw(item.Fields.ShortText));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 38 "..\..\MVC\Views\PPGirisimci\List.Girisimci.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"sticky-stopper-one\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n\r\n   \r\n\r\n</script>");

        }
    }
}
#pragma warning restore 1591
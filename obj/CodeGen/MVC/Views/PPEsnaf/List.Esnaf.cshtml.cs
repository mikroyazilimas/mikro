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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/PPEsnaf/List.Esnaf.cshtml")]
    public partial class _MVC_Views_PPEsnaf_List_Esnaf_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_PPEsnaf_List_Esnaf_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!-- Popup Musavir-->\r\n<div");

WriteLiteral(" class=\"musavir-popup\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"popup\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"popup-price\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"popup-price-buy musavir-top-buy\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"popup-price__pricetext\"");

WriteLiteral(">1290 TL + KDV</span>\r\n                <span");

WriteLiteral(" class=\"popup-price__text\"");

WriteLiteral(">Başlayan Fiyatlarla Satın Alın</span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"popup-price-rent musavir-top-rent\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"popup-price__pricetext\"");

WriteLiteral(">516 TL + KDV/Yıl</span>\r\n                <span");

WriteLiteral(" class=\"popup-price__text\"");

WriteLiteral(">Fiyatlarla Kiralayın.</span>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"popup-tabs\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/ucretsiz-demo-talep?product=MUSAVIR\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"popup-tabs-buy\"");

WriteLiteral(">\r\n                    <span>Satın Al</span>\r\n                </div>\r\n           " +
" </a>\r\n            <a");

WriteLiteral(" href=\"/ucretsiz-demo-talep?product=MUSAVIR\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"popup-tabs-rent\"");

WriteLiteral(">\r\n                    <span>Kirala</span>\r\n                </div>\r\n            <" +
"/a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"popup-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"popup-content-right__description\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"popup-content-right__logo\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" src=\"/Frontend/dist/images/products/mikro-musavir.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(@">
                </div>
                <p>
                    Tüm muhasebe işlemlerinizi güvenle takip etmek istiyorsanız Mikro Müşavir tam size göre!

                    Kolay kullanımı ve işlevselliği ile genel muhasebeden personele, işletme defterinden amortisman takibine kadar geniş bir yelpazede çözüm sunuyor.

                </p>
                <ul>
                    <li>Muhasebe Yönetimi</li>
                    <li>Sabit Kıymetler Yönetimi</li>
                    <li>Enflasyon Muhasebesi (IAS-29 ve SPK Uyumlu)</li>
                    <li>Mükellefler için Stok Yönetimi</li>
                    <li>Finans Yönetimi</li>
                    <li>Konsolide İşlemler</li>
                    <li>Bildirge, beyanname, yazışma ve genel amaçlı programlar</li>
                </ul>
            </div>
        </div>
        <div");

WriteLiteral(" class=\"popup-button\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/ucretsiz-demo-talep?product=MUSAVIR\"");

WriteLiteral(">Demo Talep Formu</a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"close-popup\"");

WriteLiteral(">X</div>\r\n    </div>\r\n</div>\r\n<!--Popup Finish-->\r\n\r\n<div");

WriteLiteral(" class=\"products-container-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"products-container-content-left\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"products-container-content-left__img\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-musavir\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 2633), Tuple.Create("\"", 2688)
, Tuple.Create(Tuple.Create("", 2639), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/products/mikro-musavir.png")
, 2639), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral("></a>\r\n        </div>\r\n\r\n        <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-musavir\"");

WriteLiteral(" class=\"products-container-content-left__text\"");

WriteLiteral(">\r\n            <span>Mali Müşavirler için</span>\r\n            <span>Mikro Müşavir" +
"</span>\r\n        </a>\r\n        <div");

WriteLiteral(" class=\"products-container-content-left-button\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/ucretsiz-demo-talep?product=MUSAVIR\"");

WriteLiteral(" title=\"Ücretsiz Demo\"");

WriteLiteral(" class=\"products-container-content-left-button__demo\"");

WriteLiteral(">Ücretsiz Demo <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"Fiyat ve Nasıl Satın Alabilirim\"");

WriteLiteral(" class=\"products-container-content-left-button__price\"");

WriteLiteral(" id=\"musavir\"");

WriteLiteral(">\r\n                Fiyat ve Nasıl Satın Alabilirim\r\n                <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"products-container-content-right\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"shortText\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 79 "..\..\MVC\Views\PPEsnaf\List.Esnaf.cshtml"
       Write(Html.Raw(@Model.Items.Where(x => x.Fields.IsMainProduct == true).FirstOrDefault().Fields.ShortText));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

            
            #line 82 "..\..\MVC\Views\PPEsnaf\List.Esnaf.cshtml"
        
            
            #line default
            #line hidden
            
            #line 82 "..\..\MVC\Views\PPEsnaf\List.Esnaf.cshtml"
         foreach (var item in Model.Items.Where(x => x.Fields.IsMainProduct != true))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"products-container-content-right-item\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"products-container-content-right-item__title\"");

WriteLiteral(">\r\n                    <span>");

            
            #line 86 "..\..\MVC\Views\PPEsnaf\List.Esnaf.cshtml"
                     Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"products-container-content-right-item__text\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 89 "..\..\MVC\Views\PPEsnaf\List.Esnaf.cshtml"
               Write(Html.Raw(item.Fields.ShortText));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 92 "..\..\MVC\Views\PPEsnaf\List.Esnaf.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591

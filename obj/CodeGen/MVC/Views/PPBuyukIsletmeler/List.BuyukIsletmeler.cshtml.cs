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
    
    #line 2 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/PPBuyukIsletmeler/List.BuyukIsletmeler.cshtml")]
    public partial class _MVC_Views_PPBuyukIsletmeler_List_BuyukIsletmeler_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_PPBuyukIsletmeler_List_BuyukIsletmeler_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
  
    var pField = Model.Items.Where(x => x.Fields.IsMainProduct == true).FirstOrDefault().Fields;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!-- Popup Fly-->\r\n<div");

WriteLiteral(" class=\"fly-popup\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"popup\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"popup-price fly-top\"");

WriteLiteral(">\r\n            <span>Proje Bazlı Tekliflendirilmektedir.</span>\r\n        </div>\r\n" +
"        <div");

WriteLiteral(" class=\"popup-tabs\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/iletisim/bize-ulasin\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"popup-tabs-buy\"");

WriteLiteral(">\r\n                    <span>Satın Al</span>\r\n                </div>\r\n           " +
" </a>\r\n            <a");

WriteLiteral(" href=\"/iletisim/bize-ulasin\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"popup-tabs-rent\"");

WriteLiteral(">\r\n                    <span>Kirala</span>\r\n                    <span>*Tek seferl" +
"ik bir giriş bedeli alınmaktadır.</span>\r\n                </div>\r\n            </" +
"a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"popup-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"popup-content-left\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" src=\"/Frontend/dist/images/products/pop-up/products-fly-chart.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"popup-content-right\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"popup-content-right__logo\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" src=\"/Frontend/dist/images/products/pop-up/products-fly-logo.svg\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"popup-content-right__description\"");

WriteLiteral(@">
                    <p>Büyük Bir işletmeye sahipseniz ama en büyük olmak istiyorsunuz, rekabetin dışında kalmak değil, önünde yer almak istiyorsanız Mikro FLY tam size göre! Mikro FLY ile grup içindeki tüm şirketlerinizi tek yönetimde birleştirebilir, tedarikçinizden müşterilerinize kadar uzanan bütünleşik bir yapı kurabilirsiniz. </p>
                    <ul>
                        <li>Limitsiz Kullanıcı Arttırımı</li>
                        <li>En Geniş Fonksiyonalite</li>
                        <li>Tüm İş Süreçlerinin Otomasyonu</li>
                        <li>Çoklu Dil Desteği</li>
                    </ul>
                </div>
            </div>
        </div>
        <div");

WriteLiteral(" class=\"popup-button\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/iletisim/bize-ulasin\"");

WriteLiteral(">\r\n                Şirketinize ücretsiz demo sunumu için\r\n                formu d" +
"oldurun.\r\n            </a>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"close-popup\"");

WriteLiteral(">X</div>\r\n    </div>\r\n</div>\r\n<!--Popup Finish-->\r\n\r\n<div");

WriteLiteral(" class=\"products-container-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"products-container-content-left\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"scrolldown sticky-three\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"products-container-content-left__img\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-fly/\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 2634), Tuple.Create("\"", 2685)
, Tuple.Create(Tuple.Create("", 2640), Tuple.Create<System.Object, System.Int32>(Href("~/Frontend/dist/images/products/mikro-fly.svg")
, 2640), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral("></a>\r\n            </div>\r\n            <a");

WriteLiteral(" href=\"/urunler-ve-hizmetler/mikro-fly/\"");

WriteLiteral(" class=\"products-container-content-left__text\"");

WriteLiteral(">\r\n                <span>Büyük İşletmeler için</span>\r\n                <span>Mikr" +
"o Fly</span>\r\n            </a>\r\n            <div");

WriteLiteral(" class=\"products-container-content-left-button\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" href=\"/iletisim/bize-ulasin\"");

WriteLiteral(" title=\"Ücretsiz Demo\"");

WriteLiteral(" class=\"products-container-content-left-button__demo\"");

WriteLiteral(">Ücretsiz Demo <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"Fiyat ve Nasıl Satın Alabilirim\"");

WriteLiteral(" class=\"products-container-content-left-button__price\"");

WriteLiteral(" id=\"fly\"");

WriteLiteral(">\r\n                    Fiyat ve Nasıl Satın Alabilirim\r\n                    <span" +
"><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div" +
">\r\n    <div");

WriteLiteral(" class=\"products-container-content-right\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"shortText\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 78 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
       Write(Html.Raw(@Model.Items.Where(x => x.Fields.IsMainProduct == true).FirstOrDefault().Fields.ShortText));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

            
            #line 81 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
        
            
            #line default
            #line hidden
            
            #line 81 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
         foreach (var item in Model.Items.Where(x => x.Fields.IsMainProduct != true))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"products-container-content-right-item\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"products-container-content-right-item__title\"");

WriteLiteral(">\r\n                    <span>");

            
            #line 85 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
                     Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"products-container-content-right-item__text\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 88 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
               Write(Html.Raw(item.Fields.ShortText));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n");

            
            #line 91 "..\..\MVC\Views\PPBuyukIsletmeler\List.BuyukIsletmeler.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"sticky-stopper-three\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591

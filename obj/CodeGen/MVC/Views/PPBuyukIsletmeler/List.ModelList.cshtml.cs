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
    
    #line 3 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/PPBuyukIsletmeler/List.ModelList.cshtml")]
    public partial class _MVC_Views_PPBuyukIsletmeler_List_ModelList_cshtml : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public _MVC_Views_PPBuyukIsletmeler_List_ModelList_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
  
    var pField = Model.Items.Where(x => x.Fields.IsMainProduct == true).FirstOrDefault().Fields;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- Overlay -->\r\n<div");

WriteLiteral(" class=\"overlay\"");

WriteLiteral("></div>\r\n<!-- Popup Fly-->\r\n<div");

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

WriteLiteral(">Şirketinize ücretsiz demo sunumu için formu doldurun.</a>\r\n        </div>\r\n     " +
"   <div");

WriteLiteral(" class=\"close-popup\"");

WriteLiteral(">X</div>\r\n    </div>\r\n\r\n    <!--Popup Finish-->\r\n\r\n\r\n    <div");

WriteLiteral(" class=\"detail-product\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"detail-product-content\"");

WriteLiteral(">\r\n\r\n");

            
            #line 60 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 60 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
             if (pField.MainPhoto != null)
            {
                foreach (var pht in pField.MainPhoto)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"detail-product-content__img\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2673), Tuple.Create("\"", 2699)
            
            #line 65 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
, Tuple.Create(Tuple.Create("", 2679), Tuple.Create<System.Object, System.Int32>(pht.Fields.MediaUrl
            
            #line default
            #line hidden
, 2679), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n");

            
            #line 67 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                }

            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"detail-product-content-other\"");

WriteLiteral(">\r\n\r\n                <div");

WriteLiteral(" class=\"detail-product-content-other__text\"");

WriteLiteral(">\r\n                    <p>\r\n");

WriteLiteral("                        ");

            
            #line 75 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                   Write(Html.Raw(pField.Detail));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"products-container-content-left-button product-detail-content-buttons\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"/iletisim/bize-ulasin\"");

WriteLiteral(" title=\"demo\"");

WriteLiteral(" class=\"products-container-content-left-button__demo\"");

WriteLiteral(">Ücretsiz Demo <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a>\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"Fiyat ve Nasıl Satın Alabilirim\"");

WriteLiteral(" class=\"products-container-content-left-button__price\"");

WriteLiteral(" id=\"fly\"");

WriteLiteral(">Fiyat ve Nasıl Satın Alabilirim <span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a></a>\r\n                </div>\r\n            </div>\r\n        </div>\r" +
"\n\r\n\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"detail-product-description\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"detail-product-description-left\"");

WriteLiteral(">\r\n");

            
            #line 90 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 90 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
             if (pField.ProductProperties != null)
            {
                foreach (var pItem in pField.ProductProperties)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"products-container-content-right-item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"products-container-content-right-item__title\"");

WriteLiteral(">\r\n\r\n                            <div>\r\n                                <span>");

            
            #line 98 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                                 Write(pItem.Fields.PropertyName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n" +
"                        <div");

WriteLiteral(" class=\"products-container-content-right-item__text\"");

WriteLiteral(">\r\n                            <p>");

            
            #line 104 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                          Write(Html.Raw(pItem.Fields.Detailinfo));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");

            
            #line 107 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"detail-product-description-right\"");

WriteLiteral(">\r\n");

            
            #line 112 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 112 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
             if (pField.ChartPhoto != null)
            {
                foreach (var photo in pField.ChartPhoto)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"detail-product-description-right-content\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4767), Tuple.Create("\"", 4795)
            
            #line 117 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
, Tuple.Create(Tuple.Create("", 4773), Tuple.Create<System.Object, System.Int32>(photo.Fields.MediaUrl
            
            #line default
            #line hidden
, 4773), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n                    </div>\r\n");

            
            #line 119 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"management-services modules-owl-carousel owl-carousel\"");

WriteLiteral(">\r\n\r\n");

            
            #line 127 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 127 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
         foreach (var item in Model.Items.Where(x => x.Fields.IsMainProduct != true))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"management-services-item\"");

WriteLiteral(">\r\n\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5145), Tuple.Create("\"", 5247)
            
            #line 131 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
, Tuple.Create(Tuple.Create("", 5152), Tuple.Create<System.Object, System.Int32>(item.DefaultUrl.Replace("urunler-ve-hizmetler/genel-bakis/","urunler-ve-hizmetler/mikro-fly/")
            
            #line default
            #line hidden
, 5152), false)
);

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"management-services-item__img\"");

WriteLiteral(">\r\n");

            
            #line 133 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 133 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                         if (item.Fields.IconImage != null)
                        {
                            foreach (var photo in item.Fields.IconImage)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 5545), Tuple.Create("\"", 5573)
            
            #line 137 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
, Tuple.Create(Tuple.Create("", 5551), Tuple.Create<System.Object, System.Int32>(photo.Fields.MediaUrl
            
            #line default
            #line hidden
, 5551), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n");

            
            #line 138 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"management-services-item__title\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 143 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
                         Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");

            
            #line 147 "..\..\MVC\Views\PPBuyukIsletmeler\List.ModelList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <!--<div class=\"numbers\">\r\n        <div class=\"numbers-contents\">" +
"\r\n            <div class=\"numbers-contents-item\">\r\n                <div class=\"n" +
"umbers-contents-item__img\">\r\n                    <img src=\"/Frontend/dist/images" +
"/product-detail/section2-bottom1.png\" alt=\"\">\r\n                </div>\r\n         " +
"        <div class=\"numbers-contents-item-text\">\r\n                    <div class" +
"=\"numbers-contents-item-text__text1\">\r\n                        <span data-number" +
"-animate data-number=\"105000\">105000+</span>\r\n                    </div>\r\n      " +
"              <div class=\"numbers-contents-item-text__text2\">\r\n                 " +
"       <span>Kayıtlı Şirket Sayısı</span>\r\n                    </div>\r\n         " +
"       </div>\r\n            </div>\r\n            <div class=\"numbers-contents-item" +
"\">\r\n                <div class=\"numbers-contents-item__img\">\r\n                  " +
"  <img src=\"/Frontend/dist/images/product-detail/section2-bottom2.png\" alt=\"\">\r\n" +
"                </div>\r\n                <div class=\"numbers-contents-item-text\">" +
"\r\n                    <div class=\"numbers-contents-item-text__text1 \">\r\n        " +
"                <span data-number-animate data-number=\"2000000\">1</span>\r\n      " +
"              </div>\r\n                    <div class=\"numbers-contents-item-text" +
"__text2\">\r\n                        <span>Yazılan Satır Kod</span>\r\n             " +
"       </div>\r\n                </div>\r\n            </div>\r\n            <div clas" +
"s=\"numbers-contents-item\">\r\n                <div class=\"numbers-contents-item__i" +
"mg\">\r\n                    <img src=\"/Frontend/dist/images/product-detail/section" +
"2-bottom3.png\" alt=\"\">\r\n                </div>\r\n                <div class=\"numb" +
"ers-contents-item-text\">\r\n                    <div class=\"numbers-contents-item-" +
"text__text1\">\r\n                        <span data-number-animate data-number=\"10" +
"0\">1</span>\r\n                    </div>\r\n                    <div class=\"numbers" +
"-contents-item-text__text2\">\r\n                        <span>Hedeflenen Kullanıcı" +
"</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r" +
"\n        </div>\r\n    </div>-->\r\n    <div");

WriteLiteral(" class=\"story-products-wizard\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"story-products-wizard-left\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"story-products-wizard-left-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"story-products-wizard-left-content__title\"");

WriteLiteral(">\r\n                    <span>Ürün<strong>Sihirbazı</strong></span>\r\n             " +
"   </div>\r\n                <div");

WriteLiteral(" class=\"story-products-wizard-left-content__hr\"");

WriteLiteral(">\r\n\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"product-detail-section3-left-content-button\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"/urun-secme-sihirbazi\"");

WriteLiteral(" title=\"Sizin İçin Doğru Ürünü Seçin\"");

WriteLiteral(" class=\"product-detail-section3-left-content-button__wizard\"");

WriteLiteral(">Sizin İçin Doğru &nbsp;<strong>Ürünü Seçin</strong><span><i");

WriteLiteral(" class=\"fas fa-arrow-right\"");

WriteLiteral("></i></span></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n   " +
"     <div");

WriteLiteral(" class=\"story-products-wizard-right\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" src=\"/Frontend/dist/images/story/product-wizard.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591

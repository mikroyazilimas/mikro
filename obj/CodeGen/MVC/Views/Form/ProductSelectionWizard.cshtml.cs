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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Form/ProductSelectionWizard.cshtml")]
    public partial class _MVC_Views_Form_ProductSelectionWizard_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.ViewModel.ProductSelectionWizard>
    {
        public _MVC_Views_Form_ProductSelectionWizard_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"wizard\"");

WriteLiteral(">\r\n");

            
            #line 4 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
     using (@Html.BeginForm("Index", "DemoRequestForm", FormMethod.Post))
    { }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 6 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
     using (Html.BeginForm(null, null, FormMethod.Post, new { action = "https://webto.salesforce.com/servlet/servlet.WebToLead?encoding=UTF-8" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000SJktR\"");

WriteLiteral(" maxlength=\"255\"");

WriteLiteral(" name=\"00N0Y00000SJktR\"");

WriteLiteral(" size=\"20\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000SJktb\"");

WriteLiteral(" maxlength=\"255\"");

WriteLiteral(" name=\"00N0Y00000SJktb\"");

WriteLiteral(" size=\"20\"");

WriteLiteral(" />\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000SJktl\"");

WriteLiteral(" maxlength=\"255\"");

WriteLiteral(" name=\"00N0Y00000SJktl\"");

WriteLiteral(" size=\"20\"");

WriteLiteral(" />\r\n");

            
            #line 11 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"

        
            
            #line default
            #line hidden
            
            #line 12 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
   Write(Html.HiddenFor(m => m.retURL, new { Value = String.Format("{0}?product={1}",Const.FormReturnUrl,"product")}));

            
            #line default
            #line hidden
            
            #line 12 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                                                                                                     


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"wizard-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"wizard-content__text\"");

WriteLiteral(@">
                <strong>Firmanıza en uygun Mikro yazılımını hemen seçin.</strong>
                <p>Mikro ürünleri arasında sizin ihtiyacınıza en uygun ürünler hangileri? Sadece 2 dakikanızı ayırarak Mikro’nun size en uygun ürününü seçin. İster hemen satın alın, isterseniz size özel fiyatlarımız için bizden teklif isteyin.</p>
            </div>

            <div");

WriteLiteral(" class=\"wizard-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"wizard-form-left\"");

WriteLiteral(">\r\n\r\n\r\n");

            
            #line 24 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                
            
            #line default
            #line hidden
            
            #line 24 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                 if (Model.FormItems != null && Model.FormItems.Count > 0)
                {
                    foreach (var item in Model.FormItems)
                    {
                        if (item.InputType == SitefinityWebApp.Library.InputType.Hidden)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1637), Tuple.Create("\"", 1657)
            
            #line 30 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 1642), Tuple.Create<System.Object, System.Int32>(item.InputName
            
            #line default
            #line hidden
, 1642), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1658), Tuple.Create("\"", 1680)
            
            #line 30 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 1665), Tuple.Create<System.Object, System.Int32>(item.InputName
            
            #line default
            #line hidden
, 1665), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1681), Tuple.Create("\"", 1705)
            
            #line 30 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                    , Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(item.InputValue
            
            #line default
            #line hidden
, 1689), false)
);

WriteLiteral(" required=\"required\"");

WriteLiteral("/>\r\n");

            
            #line 31 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"

                        }
                        else if (item.InputType == SitefinityWebApp.Library.InputType.TextBox)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1914), Tuple.Create("\"", 2010)
, Tuple.Create(Tuple.Create("", 1922), Tuple.Create("wizard-form-row", 1922), true)
            
            #line 35 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create(" ", 1937), Tuple.Create<System.Object, System.Int32>(item.InputClass
            
            #line default
            #line hidden
, 1938), false)
            
            #line 35 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create(" ", 1954), Tuple.Create<System.Object, System.Int32>(String.Format(item.InputNotVisible? "wizardhide" : "")
            
            #line default
            #line hidden
, 1955), false)
);

WriteLiteral(" >\r\n                                <label>");

            
            #line 36 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                  Write(item.LabelValue);

            
            #line default
            #line hidden
WriteLiteral("<span>");

            
            #line 36 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                                        Write(item.LabelValueShort);

            
            #line default
            #line hidden
WriteLiteral("</span></label>\r\n                                <input");

WriteLiteral(" type=\"text\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2164), Tuple.Create("\"", 2184)
            
            #line 37 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 2169), Tuple.Create<System.Object, System.Int32>(item.InputName
            
            #line default
            #line hidden
, 2169), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 2185), Tuple.Create("\"", 2207)
            
            #line 37 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 2192), Tuple.Create<System.Object, System.Int32>(item.InputName
            
            #line default
            #line hidden
, 2192), false)
);

WriteLiteral(" value=\"\"");

WriteLiteral(" required=\"required\"");

WriteLiteral(" maxlength=\"4\"");

WriteLiteral(" pattern=");

WriteLiteral(" \"[0-9]+\"/>\r\n                            </div>\r\n");

            
            #line 39 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                        }
                        else if (item.InputType == SitefinityWebApp.Library.InputType.DropDown)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 2492), Tuple.Create("\"", 2588)
, Tuple.Create(Tuple.Create("", 2500), Tuple.Create("wizard-form-row", 2500), true)
            
            #line 42 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create(" ", 2515), Tuple.Create<System.Object, System.Int32>(item.InputClass
            
            #line default
            #line hidden
, 2516), false)
            
            #line 42 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create(" ", 2532), Tuple.Create<System.Object, System.Int32>(String.Format(item.InputNotVisible? "wizardhide" : "")
            
            #line default
            #line hidden
, 2533), false)
);

WriteLiteral(">\r\n                                <label>");

            
            #line 43 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                  Write(item.LabelValue);

            
            #line default
            #line hidden
WriteLiteral("<span>");

            
            #line 43 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                                        Write(item.LabelValueShort);

            
            #line default
            #line hidden
WriteLiteral("</span></label>\r\n                                <select");

WriteAttribute("id", Tuple.Create(" id=\"", 2730), Tuple.Create("\"", 2750)
            
            #line 44 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 2735), Tuple.Create<System.Object, System.Int32>(item.InputName
            
            #line default
            #line hidden
, 2735), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 2751), Tuple.Create("\"", 2773)
            
            #line 44 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 2758), Tuple.Create<System.Object, System.Int32>(item.InputName
            
            #line default
            #line hidden
, 2758), false)
);

WriteLiteral(" required=\"required\"");

WriteLiteral(">\r\n                                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">Seçiniz</option>\r\n");

            
            #line 46 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 46 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                     foreach (var dItem in item.DropDownItem)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3033), Tuple.Create("\"", 3053)
            
            #line 48 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
, Tuple.Create(Tuple.Create("", 3041), Tuple.Create<System.Object, System.Int32>(dItem.Value
            
            #line default
            #line hidden
, 3041), false)
);

WriteLiteral(" data-field=\"");

            
            #line 48 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                                                            Write(dItem.FieldValue);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 48 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                                                                               Write(dItem.Text);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 49 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </select>\r\n                            </div>\r\n");

            
            #line 52 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                        }
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n               </div>\r\n                <div");

WriteLiteral(" class=\"wizard-form-right\"");

WriteLiteral(">\r\n\r\n                </div>\r\n\r\n                ");

WriteLiteral("\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n");

            
            #line 70 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"wizard-bottom\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"wizard-bottom-left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Adınız</label>\r\n");

WriteLiteral("                            ");

            
            #line 77 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                       Write(Html.TextBoxFor(m => m.Name, new { Name = "first_name", id = "first_name", required = "required", placeholder = "Adınız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Soyadınız</label>\r\n");

WriteLiteral("                            ");

            
            #line 81 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                       Write(Html.TextBoxFor(m => m.Surname, new { Name = "last_name", id = "last_name", required = "required", placeholder = "Soyadınız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Firmanızın Ünvanı</label>\r\n");

WriteLiteral("                            ");

            
            #line 85 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                       Write(Html.TextBoxFor(m => m.CompanyName, new { Name = "company", id = "company", required = "required", placeholder = "Firmanızın Ünvanı*", value="Seçiniz" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">E-Posta</label>\r\n");

WriteLiteral("                            ");

            
            #line 89 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { Name = "email", id = "email", pattern = "[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,3}$", required = "required", placeholder="E-Postanız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Telefon</label>\r\n");

WriteLiteral("                            ");

            
            #line 93 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                       Write(Html.TextBoxFor(m => m.Phone, new { Name = "phone", id = "phone", maxlength = "11", minlenght = "11", required = "required", @class = "phones", placeholder = "Telefonunuz*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text\"");

WriteLiteral(">\r\n                                <p>Kişisel Veriler Bilgilendirme Metni</p>\r\n  " +
"                              <i");

WriteLiteral(" class=\"fas fa-caret-down\"");

WriteLiteral("></i>\r\n\r\n                            </div>\r\n                            <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text__hide\"");

WriteLiteral(">\r\n                                <p>İşbu 6698 Sayılı Kişisel Verilerin Korunmas" +
"ı Kanunu ile yürürlükteki yasal mevzuata uygun olarak ve 6698 sayılı Kişisel Ver" +
"ilerin Korunması Kanunu <b>(“Kanun”) </b> kapsamında <b>“Veri Sorumlusu” </b> sı" +
"fatıyla Mikro Yazılımevi Yazılım Hizmetleri Bilgisayar Sanayi ve Ticaret A.Ş.’ye" +
" <b>(“Şirket”) </b>  ait www.mikro.com.tr alan adlı internet sitesinin kullanmas" +
"ı ile bağlantılı olarak elde edilen ve tarafımızca sağlanan verilerin toplanması" +
", işlenmesi ve kullanım türü, derecesi ve amacı ile ilgili olarak siz kullanıcıl" +
"arımıza bilgilendirme yapılması amaçlanmaktadır.</p>\r\n                          " +
"      <p>www.mikro.com.tr alan adlı internet sitesi Mikro Yazılımevi Yazılım Hiz" +
"metleri Bilgisayar Sanayi ve Ticaret A.Ş. tarafından işletilmektedir. Şirket kul" +
"lanıcıların kişi  sel verilerinin yönetilmesinde sorumlu kuruluştur. İşbu madde " +
"kapsamındaki bilgilendirme 6698 sayılı “Kişisel Verilerin Korunması Kanunu” kaps" +
"amında yapılmaktadır.</p>\r\n                                <p>Kişisel verilerini" +
"zinin, gizli bilgilerinizin korunmasını ve gizli tutulmasını ciddiye almaktayız." +
" Kanun ve ilgili mevzuat hükümlerine tarafımızca, çalışanlarımızca ve servis sağ" +
"layıcılarımızca görevlerini yerlerine getirirlerken gizliliklerine mutlaka dikka" +
"t edilmesini ve yalnızca sizlere bildirdiğimiz amaçlarla kullanılmasını sağlamak" +
" üzere teknik ve idari önlemleri almaktayız.</p>\r\n                              " +
"  <p>Kişisel verilerin işlenmesi, kişisel verilerin tamamen ve kısmen otomatik o" +
"lan (çerezler) ya da herhangi bir veri kayıt sisteminin parçası olmak kaydıyla o" +
"tomatik olmayan yollarla elde edilmesi, kaydedilmesi, depolanması, muhafaza edil" +
"mesi, değiştirilmesi, yeniden düzenlenmesi, açıklanması, aktarılması, devralınma" +
"sı, elde edilebilir hale getirilmesi, sınıflandırılması ya da kullanılmasının en" +
"gellenmesi gibi kişilere ait veriler üzerinde gerçekleştirilen her türlü işlemi " +
"ifade etmektedir.</p>\r\n                                <p>İnternet sitesine üyel" +
"iği kapsamında bizlere sağladığınız bilgileriniz, buna ek olarak mal ve hizmet a" +
"lımlarınız sırasında çerezler ve benzeri yöntemler aracılığı edinilen bilgiler; " +
"bizim tarafımızdan, mevcut ve ilerideki iştiraklerimiz, bağlı şirketlerimiz, his" +
"sedarlarımız, iş ortaklarımız, haleflerimiz, hizmet ve faaliyetlerimiz ile yan h" +
"izmetlerimizi yürütmek üzere hizmet aldığımız, işbirliği yaptığımız, yurt içinde" +
" ve/veya yurtdışında faaliyet gösteren program ortağı kuruluşlar ve diğer üçüncü" +
" kişiler (hukuk ve vergi danışmanlarımız, bankalar, bağımsız denetçiler dahil ve" +
" fakat bunlarla sınırlı olmamak üzere, sizlere hizmet sunabilmemiz için işbirliğ" +
"i yaptığımız veya yapabileceğimiz hizmet tedarikçileri) ve/veya bunların belirle" +
"yecekleri üçüncü kişiler/kuruluşlar tarafından muhtelif mal ve hizmetlerin sağla" +
"nması ve her türlü bilgilendirme, reklam-tanıtım, promosyon, satış, pazarlama ve" +
" üyelik uygulamaları amaçlı yapılacak elektronik ve diğer ticari-sosyal iletişim" +
"ler için, belirtilenler ve halefleri nezdinde süresiz olarak veya öngörecekleri " +
"süre ile kayda alınabilecek, basılı/manyetik arşivlerde saklanabilecek, gerekli " +
"görülen hallerde güncellenebilecek, paylaşılabilecek, aktarılabilecek, transfer " +
"edilebilecek, kullanılabilecek ve Kanun’un 5. ve 6. maddelerinde belirtilen kişi" +
"sel veri işleme şartları ve amaçları dahilinde işlenebilecektir. Buna ek olarak " +
"Kanun dahil ilgili mevzuat hükümleri dahilinde zorunlu olması durumunda bazı uyg" +
"ulamalar ve işlemler için ayrıca ilave izniniz de gerekebilecektir. Bu durumlard" +
"a sizlerle iletişime geçilecek ve sizlerin açık rızaları rica edilecektir. Bu ve" +
"rilere ek olarak bizlere iletmiş olduğunuz kişisel verileriniz hukukun gerekli k" +
"ıldığı durumlarda resmi kurum/kuruluşlar, mahkemeler tarafından talep edilmesi h" +
"alinde ilgili merci ve mahkemelere iletilebilecektir. </p>\r\n\r\n                  " +
"              <p>Kişisel verileriniz internet sitemizde siz kullanıcılarımıza da" +
"ha iyi hizmet sunabilmesi, hizmetlerimizin iyileştirebilmesi, ayrıca bu konuda i" +
"zin vermiş olmanız durumunda pazarlama faaliyetlerinde kullanılabilmesi, ürün/hi" +
"zmet teklifi, her türlü bilgilendirme, reklam-tanıtım, promosyon, satış, pazarla" +
"ma, mağaza kartı, kredi kartı ve üyelik uygulamaları, modelleme, raporlama, skor" +
"lama, internet sitesinin kullanımını kolaylaştırılması, kullanıcılarının ilgi al" +
"anlarına ve tercihlerine yönelik tarafımızca veya iştiraklerimiz tarafından yapı" +
"lacak geliştirme çalışmalarda kullanılabilecektir. İnternet sitesi üzerinde yapt" +
"ığınız hareketlerin çerezler ve benzeri yöntemlerle izlenebileceğini, kaydının t" +
"utulabileceğini, istatistiki veya yukarıda bahsedilen amaçlarla kullanılabilecek" +
"tir. Ancak buna ek olarak önemle belirtmek isteriz ki internet sitemize üyelik, " +
"ürün veya hizmetlerimizin satın alınması ve bilgi güncelleme amaçlı girilen bilg" +
"iler, kredi kartı ve banka kartlarına ait gizli bilgiler diğer internet kullanıc" +
"ıları tarafından görüntülenemez.</p>\r\n\r\n                                <p>Ebeve" +
"yninin veya velisinin izni olmadan küçüklerin kişisel verilerini göndermemeleri " +
"gerekmektedir.</p>\r\n                                <p>Şirket’e ait internet sit" +
"esinin, durumun niteliğine göre diğer internet sitelerine bağlantılar içermesi h" +
"alinde bu sitelerin operatörlerinin veri koruma hükümlerine uygun olup olmamalar" +
"ı hususunda hiçbir taahhütte bulunmamaktayız. Şirket, link veya benzeri başka yö" +
"ntemlerle bağlantı verdiği sitelerin içeriklerinden hiçbir zaman sorumlu değildi" +
"r.</p>\r\n                                <p>6698 Sayılı Kişisel Verilerin Korunma" +
"sı Kanunu’nun 11. maddesi uyarınca; kişisel verilerinizin işlenip işlenmediğini " +
"öğrenme, kişisel verileriniz işlenmişse buna ilişkin bilgi talep etme, kişisel v" +
"erilerinizin işlenme amacını ve bunların amacına uygun kullanılıp kullanılmadığı" +
"nı öğrenme, yurt içinde veya yurt dışında kişisel verilerinizin aktarıldığı üçün" +
"cü kişileri bilme, kişisel verilerinizin eksik veya yanlış işlenmiş olması halin" +
"de bunların düzeltilmesini isteme ve bu kapsamda yapılan işleme ilişkin olarak k" +
"işisel verilerinizin aktarıldığı üçüncü kişilere bildirilmesini isteme, Kanun’un" +
" ve ilgili sair mevzuat hükümlerine uygun olarak işlenmiş olmasına rağmen, işlen" +
"mesini gerektiren sebeplerin ortadan kalkması halinde kişisel verilerin silinmes" +
"ini veya yok edilmesini isteme ve bu kapsamda yapılan işlemin kişisel verilerini" +
"zin aktarıldığı üçüncü kişilere bildirilmesini isteme, işlenen verilerin münhası" +
"ran otomatik sistemler vasıtasıyla analiz edilmesi suretiyle aleyhinize bir sonu" +
"cun ortaya çıkmasına itiraz etme, kişisel verilerinizin Kanun’a aykırı olarak iş" +
"lenmesi sebebiyle zarara uğramanız halinde zararın giderilmesini talep etme hakl" +
"arına sahipsiniz. Kişisel veri sahipleri olarak, az önce saymış olduğumuz haklar" +
"ınıza ilişkin taleplerinizi, söz konusu yöntemlerle Şirket’e iletmeniz durumunda" +
" Şirketimiz talebin niteliğine göre en kısa sürede ve en geç otuz gün içinde ücr" +
"etsiz olarak sonuçlandıracaktır. Ancak, işlemin ayrıca bir maliyeti gerektirmesi" +
" halinde Kişisel Verileri Koruma Kurulunca belirlenen tarifedeki ücret alınabili" +
"r.</p>\r\n                                <p>Kanun’un 13. maddesinin 1. fıkrası ge" +
"reğince, yukarıda belirtilen haklarınızı kullanmak ile ilgili talebinizi, yazılı" +
" olarak veya Kişisel Verileri Koruma Kurulu’nun belirlediği diğer yöntemlerle Şi" +
"rket’e iletebilirsiniz. Kişisel Verileri Koruma Kurulu tarafından şu aşamada ilg" +
"ili haklarınızın kullanımına ilişkin herhangi bir yöntem belirlemediği için, baş" +
"vurunuzu Kanun gereğince, yazılı olarak Şirket’e iletmeniz gerekmektedir. </p>\r\n" +
"                                <p><b>Çerezler</b></p>\r\n                        " +
"        <p>İnternet sitemizde; IP adresi, kullanılan tarayıcı, bilgisayarınızdak" +
"i işletim sistemi, internet bağlantınız, site kullanımları hakkındaki bilgiler g" +
"ibi belirli verileri otomatik olarak elde etmemize yardımcı olan çerezler (cooki" +
"e) bulunmaktadır. Söz konusu çerezler bir internet sayfası sunucusu tarafından s" +
"abit sürücünüze iletilen küçük metin dosyalarıdır ve sitemizde bulunan çerezler," +
" bilgisayarınız için zararlı sayılabilecek virüsler göndermek için kullanılmamak" +
"tadır. </p>\r\n                                <p>Çerezler genellikle bilgisayarın" +
"ızda saklanarak, internet sitemizde yapmış olduğunuz işlemler, gezintileriniz es" +
"nasındaki tıklamalarınızın kaydedilmesi yolu ile internet sitesini hangi zaman d" +
"ilimi içerisinde, ne kadar süre ile kaç kişinin kullandığı, bir kişinin internet" +
" sitesini hangi amaçlarla, kaç kez ziyaret ettiği ve site üzerinde ne kadar vaki" +
"t harcadığı hakkında istatistiksel bilgileri elde etmek ve kullanıcı sayfalarınd" +
"an dinamik olarak reklam ve içerik üretilmesine yardımcı olmak amacı ile sağlanm" +
"aktadır. İnternet sitemizi kullanarak kullanılan çerezleri onaylamış olursunuz. " +
"Şirket, söz konusu çerezler aracılığı ile verilerinizi işleyebilir ve elde edile" +
"n bilgileri analiz etme amacı ile bu kapsamda yurtiçinde ve yurtdışında üçüncü k" +
"işilere aktarabilir.</p>\r\n                                <p>Çerezler tarafından" +
" verileriniz toplanmadan internet sitemizi görüntülemek istiyorsanız seçiminizi " +
"cihazınızın/tarayıcınızın ayarlarından her zaman değiştirebilirsiniz. Çerezlerin" +
" kullanımını durdurduğunuzda internet sitemizde her türlü işlemi belirli özellik" +
"lerinin çalışmayabileceğini lütfen unutmayınız.</p>\r\n                           " +
"     <p><b>Açık Rıza</b></p>\r\n                                <p>Sizler, interne" +
"t sitemize girerek tarafımıza sağlamış olduğunuz kişisel verilerinizin Kanun’a v" +
"e işbu 6698 Sayılı Kişisel Verilerin Korunması Kanunu’ne uygun bir şekilde ve be" +
"lirtilen amaçlarla işlenebileceğini bilmekte, kabul etmekte ve ayrıca işbu 6698 " +
"Sayılı Kişisel Verilerin Korunması Kanunu ile Kanun kapsamında yapılması gereken" +
" aydınlatma yükümlülüğü yerine getirildiğini, Sözleşme’yi okuduğunuzu, anladığın" +
"ızı, haklarınızın ve yükümlülüklerinin bilincinde olduğunuzu beyan etmektesiniz." +
"</p>\r\n                            </div>\r\n                        </div>\r\n      " +
"                  <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"Contract\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 124 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
                           Write(Html.CheckBoxFor(m => m.Contract, new { required="required" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                Kişisel Veriler Bilgilendirme Metni\'ni Kabul Ed" +
"iyorum\r\n                            </label>\r\n                            \r\n    " +
"                        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"SaveButton\"");

WriteLiteral(" value=\"Gönder\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"</div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"wizard-bottom-right\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" src=\"/Frontend/dist/images/product-wizard/bottom-img.png\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n");

            
            #line 137 "..\..\MVC\Views\Form\ProductSelectionWizard.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591

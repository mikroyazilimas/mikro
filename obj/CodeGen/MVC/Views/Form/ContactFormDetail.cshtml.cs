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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Form/ContactFormDetail.cshtml")]
    public partial class _MVC_Views_Form_ContactFormDetail_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.ViewModel.ContactForm>
    {
        public _MVC_Views_Form_ContactFormDetail_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
 using (@Html.BeginForm("Index", "ContactForm", FormMethod.Post))
{ }

            
            #line default
            #line hidden
            
            #line 6 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { action = "https://webto.salesforce.com/servlet/servlet.WebToLead?encoding=UTF-8", id= "contactDetailForm" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=hidden");

WriteLiteral(" name=\"oid\"");

WriteLiteral(" value=\"00D0Y0000035HER\"");

WriteLiteral(">\r\n");

WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000RE6zR\"");

WriteLiteral(" name=\"00N0Y00000RE6zR\"");

WriteLiteral(" />\r\n");

WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"00N0Y00000RBugB\"");

WriteLiteral(" name=\"00N0Y00000RBugB\"");

WriteLiteral(" value=\"Pre-sales channel\"");

WriteLiteral(">\r\n");

WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"mesaj\"");

WriteLiteral(" name=\"00N0Y00000QeNcc\"");

WriteLiteral(" value=\"ContactUs\"");

WriteLiteral(" />\r\n");

            
            #line 12 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"


   
            
            #line default
            #line hidden
            
            #line 14 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
Write(Html.HiddenFor(m => m.retURL, new { Value = Const.FormReturnUrl }));

            
            #line default
            #line hidden
            
            #line 14 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
                                                                      

    

            
            #line default
            #line hidden
WriteLiteral(" <div");

WriteLiteral(" class=\"wizard-bottom contact-us-area\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"wizard-bottom-left\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"wizard-bottom-left-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Adınız</label>\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextBoxFor(m => m.Name, new { Name = "first_name", id = "first_name", required = "required", placeholder = "Adınız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    \r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Soyadınız</label>\r\n");

WriteLiteral("                    ");

            
            #line 28 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextBoxFor(m => m.Surname, new { Name = "last_name", id = "last_name", required = "required", placeholder = "Soyadınız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">E-Postanız</label>\r\n");

WriteLiteral("                    ");

            
            #line 32 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextBoxFor(m => m.Email, new { Name = "email", id = "email", required = "required", pattern = @"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$", placeholder = "E-Postanız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Şirketinizin İsmi</label>\r\n");

WriteLiteral("                    ");

            
            #line 36 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextBoxFor(m => m.CompanyName, new { Name = "company", id = "company", required = "required", placeholder = "Şirketinizin ismi*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Telefon</label>\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextBoxFor(m => m.Phone, new { Name = "phone", id = "phone", type = "hidden", required = "required", placeholder = "Telefon Numaranız*", @class = "normal_phone" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextBoxFor(m => m.Phone, new { Name = "_phone", id = "_phone", pattern=".{0}|.{13,13}", required = "required", placeholder = "Telefon Numaranız*", @class = "phones", title = "Telefon numaranızı başında 0 olmadan 10 hane olacak şekilde yazınız" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row responsive-textarea\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Mesajınız</label>\r\n");

WriteLiteral("                    ");

            
            #line 45 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
               Write(Html.TextAreaFor(m => m.Message, new { Name = "00N0Y00000QeRBp", id = "00N0Y00000QeRBp",  placeholder = "Mesaj" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text\"");

WriteLiteral(">\r\n                        <p>Kişisel Veriler Bilgilendirme Metni</p>\r\n          " +
"              <svg");

WriteLiteral(" class=\"svg-inline--fa fa-caret-down fa-w-10\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" data-prefix=\"fas\"");

WriteLiteral(" data-icon=\"caret-down\"");

WriteLiteral(" role=\"img\"");

WriteLiteral(" xmlns=\"http://www.w3.org/2000/svg\"");

WriteLiteral(" viewBox=\"0 0 320 512\"");

WriteLiteral(" data-fa-i2svg=\"\"");

WriteLiteral("><path");

WriteLiteral(" fill=\"currentColor\"");

WriteLiteral(" d=\"M31.3 192h257.3c17.8 0 26.7 21.5 14.1 34.1L174.1 354.8c-7.8 7.8-20.5 7.8-28.3" +
" 0L17.2 226.1C4.6 213.5 13.5 192 31.3 192z\"");

WriteLiteral("></path></svg><!-- <i class=\"fas fa-caret-down\"></i> -->\r\n                       " +
"                 \r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text__hide\"");

WriteLiteral(">\r\n                        <p>İşbu 6698 Sayılı Kişisel Verilerin Korunması Kanunu" +
" ile yürürlükteki yasal mevzuata uygun olarak ve 6698 sayılı Kişisel Verilerin K" +
"orunması Kanunu <b>(“Kanun”) </b> kapsamında <b>“Veri Sorumlusu” </b> sıfatıyla " +
"Mikro Yazılımevi Yazılım Hizmetleri Bilgisayar Sanayi ve Ticaret A.Ş.’ye <b>(“Şi" +
"rket”) </b>  ait www.mikro.com.tr alan adlı internet sitesinin kullanması ile ba" +
"ğlantılı olarak elde edilen ve tarafımızca sağlanan verilerin toplanması, işlenm" +
"esi ve kullanım türü, derecesi ve amacı ile ilgili olarak siz kullanıcılarımıza " +
"bilgilendirme yapılması amaçlanmaktadır.</p>\r\n                        <p>www.mik" +
"ro.com.tr alan adlı internet sitesi Mikro Yazılımevi Yazılım Hizmetleri Bilgisay" +
"ar Sanayi ve Ticaret A.Ş. tarafından işletilmektedir. Şirket kullanıcıların kişi" +
"sel verilerinin yönetilmesinde sorumlu kuruluştur. İşbu madde kapsamındaki bilgi" +
"lendirme 6698 sayılı “Kişisel Verilerin Korunması Kanunu” kapsamında yapılmaktad" +
"ır.</p>\r\n                        <p>Kişisel verilerinizinin, gizli bilgilerinizi" +
"n korunmasını ve gizli tutulmasını ciddiye almaktayız. Kanun ve ilgili mevzuat h" +
"ükümlerine tarafımızca, çalışanlarımızca ve servis sağlayıcılarımızca görevlerin" +
"i yerlerine getirirlerken gizliliklerine mutlaka dikkat edilmesini ve yalnızca s" +
"izlere bildirdiğimiz amaçlarla kullanılmasını sağlamak üzere teknik ve idari önl" +
"emleri almaktayız.</p>\r\n                        <p>Kişisel verilerin işlenmesi, " +
"kişisel verilerin tamamen ve kısmen otomatik olan (çerezler) ya da herhangi bir " +
"veri kayıt sisteminin parçası olmak kaydıyla otomatik olmayan yollarla elde edil" +
"mesi, kaydedilmesi, depolanması, muhafaza edilmesi, değiştirilmesi, yeniden düze" +
"nlenmesi, açıklanması, aktarılması, devralınması, elde edilebilir hale getirilme" +
"si, sınıflandırılması ya da kullanılmasının engellenmesi gibi kişilere ait veril" +
"er üzerinde gerçekleştirilen her türlü işlemi ifade etmektedir.</p>\r\n           " +
"             <p>İnternet sitesine üyeliği kapsamında bizlere sağladığınız bilgil" +
"eriniz, buna ek olarak mal ve hizmet alımlarınız sırasında çerezler ve benzeri y" +
"öntemler aracılığı edinilen bilgiler; bizim tarafımızdan, mevcut ve ilerideki iş" +
"tiraklerimiz, bağlı şirketlerimiz, hissedarlarımız, iş ortaklarımız, haleflerimi" +
"z, hizmet ve faaliyetlerimiz ile yan hizmetlerimizi yürütmek üzere hizmet aldığı" +
"mız, işbirliği yaptığımız, yurt içinde ve/veya yurtdışında faaliyet gösteren pro" +
"gram ortağı kuruluşlar ve diğer üçüncü kişiler (hukuk ve vergi danışmanlarımız, " +
"bankalar, bağımsız denetçiler dahil ve fakat bunlarla sınırlı olmamak üzere, siz" +
"lere hizmet sunabilmemiz için işbirliği yaptığımız veya yapabileceğimiz hizmet t" +
"edarikçileri) ve/veya bunların belirleyecekleri üçüncü kişiler/kuruluşlar tarafı" +
"ndan muhtelif mal ve hizmetlerin sağlanması ve her türlü bilgilendirme, reklam-t" +
"anıtım, promosyon, satış, pazarlama ve üyelik uygulamaları amaçlı yapılacak elek" +
"tronik ve diğer ticari-sosyal iletişimler için, belirtilenler ve halefleri nezdi" +
"nde süresiz olarak veya öngörecekleri süre ile kayda alınabilecek, basılı/manyet" +
"ik arşivlerde saklanabilecek, gerekli görülen hallerde güncellenebilecek, paylaş" +
"ılabilecek, aktarılabilecek, transfer edilebilecek, kullanılabilecek ve Kanun’un" +
" 5. ve 6. maddelerinde belirtilen kişisel veri işleme şartları ve amaçları dahil" +
"inde işlenebilecektir. Buna ek olarak Kanun dahil ilgili mevzuat hükümleri dahil" +
"inde zorunlu olması durumunda bazı uygulamalar ve işlemler için ayrıca ilave izn" +
"iniz de gerekebilecektir. Bu durumlarda sizlerle iletişime geçilecek ve sizlerin" +
" açık rızaları rica edilecektir. Bu verilere ek olarak bizlere iletmiş olduğunuz" +
" kişisel verileriniz hukukun gerekli kıldığı durumlarda resmi kurum/kuruluşlar, " +
"mahkemeler tarafından talep edilmesi halinde ilgili merci ve mahkemelere iletile" +
"bilecektir. </p>\r\n\r\n                        <p>Kişisel verileriniz internet site" +
"mizde siz kullanıcılarımıza daha iyi hizmet sunabilmesi, hizmetlerimizin iyileşt" +
"irebilmesi, ayrıca bu konuda izin vermiş olmanız durumunda pazarlama faaliyetler" +
"inde kullanılabilmesi, ürün/hizmet teklifi, her türlü bilgilendirme, reklam-tanı" +
"tım, promosyon, satış, pazarlama, mağaza kartı, kredi kartı ve üyelik uygulamala" +
"rı, modelleme, raporlama, skorlama, internet sitesinin kullanımını kolaylaştırıl" +
"ması, kullanıcılarının ilgi alanlarına ve tercihlerine yönelik tarafımızca veya " +
"iştiraklerimiz tarafından yapılacak geliştirme çalışmalarda kullanılabilecektir." +
" İnternet sitesi üzerinde yaptığınız hareketlerin çerezler ve benzeri yöntemlerl" +
"e izlenebileceğini, kaydının tutulabileceğini, istatistiki veya yukarıda bahsedi" +
"len amaçlarla kullanılabilecektir. Ancak buna ek olarak önemle belirtmek isteriz" +
" ki internet sitemize üyelik, ürün veya hizmetlerimizin satın alınması ve bilgi " +
"güncelleme amaçlı girilen bilgiler, kredi kartı ve banka kartlarına ait gizli bi" +
"lgiler diğer internet kullanıcıları tarafından görüntülenemez.</p>\r\n\r\n          " +
"              <p>Ebeveyninin veya velisinin izni olmadan küçüklerin kişisel veri" +
"lerini göndermemeleri gerekmektedir.</p>\r\n                        <p>Şirket’e ai" +
"t internet sitesinin, durumun niteliğine göre diğer internet sitelerine bağlantı" +
"lar içermesi halinde bu sitelerin operatörlerinin veri koruma hükümlerine uygun " +
"olup olmamaları hususunda hiçbir taahhütte bulunmamaktayız. Şirket, link veya be" +
"nzeri başka yöntemlerle bağlantı verdiği sitelerin içeriklerinden hiçbir zaman s" +
"orumlu değildir.</p>\r\n                        <p>6698 Sayılı Kişisel Verilerin K" +
"orunması Kanunu’nun 11. maddesi uyarınca; kişisel verilerinizin işlenip işlenmed" +
"iğini öğrenme, kişisel verileriniz işlenmişse buna ilişkin bilgi talep etme, kiş" +
"isel verilerinizin işlenme amacını ve bunların amacına uygun kullanılıp kullanıl" +
"madığını öğrenme, yurt içinde veya yurt dışında kişisel verilerinizin aktarıldığ" +
"ı üçüncü kişileri bilme, kişisel verilerinizin eksik veya yanlış işlenmiş olması" +
" halinde bunların düzeltilmesini isteme ve bu kapsamda yapılan işleme ilişkin ol" +
"arak kişisel verilerinizin aktarıldığı üçüncü kişilere bildirilmesini isteme, Ka" +
"nun’un ve ilgili sair mevzuat hükümlerine uygun olarak işlenmiş olmasına rağmen," +
" işlenmesini gerektiren sebeplerin ortadan kalkması halinde kişisel verilerin si" +
"linmesini veya yok edilmesini isteme ve bu kapsamda yapılan işlemin kişisel veri" +
"lerinizin aktarıldığı üçüncü kişilere bildirilmesini isteme, işlenen verilerin m" +
"ünhasıran otomatik sistemler vasıtasıyla analiz edilmesi suretiyle aleyhinize bi" +
"r sonucun ortaya çıkmasına itiraz etme, kişisel verilerinizin Kanun’a aykırı ola" +
"rak işlenmesi sebebiyle zarara uğramanız halinde zararın giderilmesini talep etm" +
"e haklarına sahipsiniz. Kişisel veri sahipleri olarak, az önce saymış olduğumuz " +
"haklarınıza ilişkin taleplerinizi, söz konusu yöntemlerle Şirket’e iletmeniz dur" +
"umunda Şirketimiz talebin niteliğine göre en kısa sürede ve en geç otuz gün için" +
"de ücretsiz olarak sonuçlandıracaktır. Ancak, işlemin ayrıca bir maliyeti gerekt" +
"irmesi halinde Kişisel Verileri Koruma Kurulunca belirlenen tarifedeki ücret alı" +
"nabilir.</p>\r\n                        <p>Kanun’un 13. maddesinin 1. fıkrası gere" +
"ğince, yukarıda belirtilen haklarınızı kullanmak ile ilgili talebinizi, yazılı o" +
"larak veya Kişisel Verileri Koruma Kurulu’nun belirlediği diğer yöntemlerle Şirk" +
"et’e iletebilirsiniz. Kişisel Verileri Koruma Kurulu tarafından şu aşamada ilgil" +
"i haklarınızın kullanımına ilişkin herhangi bir yöntem belirlemediği için, başvu" +
"runuzu Kanun gereğince, yazılı olarak Şirket’e iletmeniz gerekmektedir. </p>\r\n  " +
"                      <p><b>Çerezler</b></p>\r\n                        <p>İnterne" +
"t sitemizde; IP adresi, kullanılan tarayıcı, bilgisayarınızdaki işletim sistemi," +
" internet bağlantınız, site kullanımları hakkındaki bilgiler gibi belirli verile" +
"ri otomatik olarak elde etmemize yardımcı olan çerezler (cookie) bulunmaktadır. " +
"Söz konusu çerezler bir internet sayfası sunucusu tarafından sabit sürücünüze il" +
"etilen küçük metin dosyalarıdır ve sitemizde bulunan çerezler, bilgisayarınız iç" +
"in zararlı sayılabilecek virüsler göndermek için kullanılmamaktadır. </p>\r\n     " +
"                   <p>Çerezler genellikle bilgisayarınızda saklanarak, internet " +
"sitemizde yapmış olduğunuz işlemler, gezintileriniz esnasındaki tıklamalarınızın" +
" kaydedilmesi yolu ile internet sitesini hangi zaman dilimi içerisinde, ne kadar" +
" süre ile kaç kişinin kullandığı, bir kişinin internet sitesini hangi amaçlarla," +
" kaç kez ziyaret ettiği ve site üzerinde ne kadar vakit harcadığı hakkında istat" +
"istiksel bilgileri elde etmek ve kullanıcı sayfalarından dinamik olarak reklam v" +
"e içerik üretilmesine yardımcı olmak amacı ile sağlanmaktadır. İnternet sitemizi" +
" kullanarak kullanılan çerezleri onaylamış olursunuz. Şirket, söz konusu çerezle" +
"r aracılığı ile verilerinizi işleyebilir ve elde edilen bilgileri analiz etme am" +
"acı ile bu kapsamda yurtiçinde ve yurtdışında üçüncü kişilere aktarabilir.</p>\r\n" +
"                        <p>Çerezler tarafından verileriniz toplanmadan internet " +
"sitemizi görüntülemek istiyorsanız seçiminizi cihazınızın/tarayıcınızın ayarları" +
"ndan her zaman değiştirebilirsiniz. Çerezlerin kullanımını durdurduğunuzda inter" +
"net sitemizde her türlü işlemi belirli özelliklerinin çalışmayabileceğini lütfen" +
" unutmayınız.</p>\r\n                        <p><b>Açık Rıza</b></p>\r\n            " +
"            <p>Sizler, internet sitemize girerek tarafımıza sağlamış olduğunuz k" +
"işisel verilerinizin Kanun’a ve işbu 6698 Sayılı Kişisel Verilerin Korunması Kan" +
"unu’ne uygun bir şekilde ve belirtilen amaçlarla işlenebileceğini bilmekte, kabu" +
"l etmekte ve ayrıca işbu 6698 Sayılı Kişisel Verilerin Korunması Kanunu ile Kanu" +
"n kapsamında yapılması gereken aydınlatma yükümlülüğü yerine getirildiğini, Sözl" +
"eşme’yi okuduğunuzu, anladığınızı, haklarınızın ve yükümlülüklerinin bilincinde " +
"olduğunuzu beyan etmektesiniz.</p>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"check\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"check\"");

WriteLiteral(" required=\"required\"");

WriteLiteral(">Kişisel Veriler Bilgilendirme Metni\'ni kabul ediyorum.</label>\r\n                " +
"    <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"SaveButton\"");

WriteLiteral(" value=\"Gönder\"");

WriteLiteral(" onclick=\"return formSubmit(\'contactDetailForm\',\'\',\'bize-ulasin\');\"");

WriteLiteral("/>\r\n                    ");

WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <di" +
"v");

WriteLiteral(" class=\"wizard-bottom-left-content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row contact-us-right-textarea\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">Mesajınız</label>\r\n            <textarea");

WriteLiteral(" name=\"\"");

WriteLiteral(" id=\"\"");

WriteLiteral(" cols=\"70\"");

WriteLiteral(" rows=\"18\"");

WriteLiteral("></textarea>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 89 "..\..\MVC\Views\Form\ContactFormDetail.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591

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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Form/ContactForm.cshtml")]
    public partial class _MVC_Views_Form_ContactForm_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.ViewModel.ContactForm>
    {
        public _MVC_Views_Form_ContactForm_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

    

    function contactFormSubmit(formId) {
        //you code 
        var dt = $('#' + formId + '').serialize();
        $.ajax({
            type: 'POST',
            url: '/urun-secme-sihirbazi/ContactSendMail?formId=' + formId,
            data: dt,
            success: function (msg) {
                if (msg == true) {
                    window.location.href = ""/tesekkurler"";
                   
                } else
                {
                    $("".errorMessage"").show();
                    $("".errorMessage"").html(""Teknik bir hata oluştu daha sonra tekrar deneyiniz"");
                    return false;
                }
            }
        });
        return false;
        //return false;
    }


    
    

</script>

");

            
            #line 37 "..\..\MVC\Views\Form\ContactForm.cshtml"
 using (@Html.BeginForm("Index", "ContactForm", FormMethod.Post))
{ }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 40 "..\..\MVC\Views\Form\ContactForm.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { action = "https://webto.salesforce.com/servlet/servlet.WebToLead?encoding=UTF-8", id = "contactForm" }))
{


            
            #line default
            #line hidden
WriteLiteral("<input");

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

            
            #line 46 "..\..\MVC\Views\Form\ContactForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 46 "..\..\MVC\Views\Form\ContactForm.cshtml"
Write(Html.HiddenFor(m => m.retURL, new { Value = Const.FormReturnUrl }));

            
            #line default
            #line hidden
            
            #line 46 "..\..\MVC\Views\Form\ContactForm.cshtml"
                                                                       



            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-textbox\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-textbox-form1\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
<<<<<<< HEAD
            #line 53 "..\..\MVC\Views\Form\ContactForm.cshtml"
=======
            #line 51 "..\..\MVC\Views\Form\ContactForm.cshtml"
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3
               Write(Html.TextBoxFor(m => m.Name, new { Name = "first_name", id = "first_name", required = "required", placeholder = "Adınız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
<<<<<<< HEAD
            #line 54 "..\..\MVC\Views\Form\ContactForm.cshtml"
=======
            #line 52 "..\..\MVC\Views\Form\ContactForm.cshtml"
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3
               Write(Html.TextBoxFor(m => m.Surname, new { Name = "last_name", id = "last_name", required = "required", placeholder = "Soyadınız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n\r\n                <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
<<<<<<< HEAD
            #line 58 "..\..\MVC\Views\Form\ContactForm.cshtml"
=======
            #line 56 "..\..\MVC\Views\Form\ContactForm.cshtml"
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3
               Write(Html.TextBoxFor(m => m.Email, new { Name = "email", id = "email", required = "required", pattern = @"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$", placeholder = "E-Postanız*" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n                <label");

WriteLiteral(" for=\"\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
<<<<<<< HEAD
            #line 61 "..\..\MVC\Views\Form\ContactForm.cshtml"
=======
            #line 59 "..\..\MVC\Views\Form\ContactForm.cshtml"
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3
               Write(Html.TextBoxFor(m => m.Phone, new { Name = "phone", id = "phone", maxlength = "11", required = "required", placeholder = "Telefon Numaranız*", @class = "phones", type = "text" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text flex homepage-contact-descriptio" +
"n-text desktop-contract-text\"");

WriteLiteral(">\r\n                    <p>Kişisel Veriler Bilgilendirme Metni</p>\r\n              " +
"      <i");

WriteLiteral(" class=\"fas fa-caret-down\"");

WriteLiteral("></i>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text__hide homepage-contact-descripti" +
"on-p desktop-contract-text\"");

WriteLiteral(">\r\n                    <p>İşbu 6698 Sayılı Kişisel Verilerin Korunması Kanunu ile" +
" yürürlükteki yasal mevzuata uygun olarak ve 6698 sayılı Kişisel Verilerin Korun" +
"ması Kanunu <b>(“Kanun”) </b> kapsamında <b>“Veri Sorumlusu” </b> sıfatıyla Mikr" +
"o Yazılımevi Yazılım Hizmetleri Bilgisayar Sanayi ve Ticaret A.Ş.’ye <b>(“Şirket" +
"”) </b>  ait www.mikro.com.tr alan adlı internet sitesinin kullanması ile bağlan" +
"tılı olarak elde edilen ve tarafımızca sağlanan verilerin toplanması, işlenmesi " +
"ve kullanım türü, derecesi ve amacı ile ilgili olarak siz kullanıcılarımıza bilg" +
"ilendirme yapılması amaçlanmaktadır.</p>\r\n                    <p>www.mikro.com.t" +
"r alan adlı internet sitesi Mikro Yazılımevi Yazılım Hizmetleri Bilgisayar Sanay" +
"i ve Ticaret A.Ş. tarafından işletilmektedir. Şirket kullanıcıların kişisel veri" +
"lerinin yönetilmesinde sorumlu kuruluştur. İşbu madde kapsamındaki bilgilendirme" +
" 6698 sayılı “Kişisel Verilerin Korunması Kanunu” kapsamında yapılmaktadır.</p>\r" +
"\n                    <p>Kişisel verilerinizinin, gizli bilgilerinizin korunmasın" +
"ı ve gizli tutulmasını ciddiye almaktayız. Kanun ve ilgili mevzuat hükümlerine t" +
"arafımızca, çalışanlarımızca ve servis sağlayıcılarımızca görevlerini yerlerine " +
"getirirlerken gizliliklerine mutlaka dikkat edilmesini ve yalnızca sizlere bildi" +
"rdiğimiz amaçlarla kullanılmasını sağlamak üzere teknik ve idari önlemleri almak" +
"tayız.</p>\r\n                    <p>Kişisel verilerin işlenmesi, kişisel verileri" +
"n tamamen ve kısmen otomatik olan (çerezler) ya da herhangi bir veri kayıt siste" +
"minin parçası olmak kaydıyla otomatik olmayan yollarla elde edilmesi, kaydedilme" +
"si, depolanması, muhafaza edilmesi, değiştirilmesi, yeniden düzenlenmesi, açıkla" +
"nması, aktarılması, devralınması, elde edilebilir hale getirilmesi, sınıflandırı" +
"lması ya da kullanılmasının engellenmesi gibi kişilere ait veriler üzerinde gerç" +
"ekleştirilen her türlü işlemi ifade etmektedir.</p>\r\n                    <p>İnte" +
"rnet sitesine üyeliği kapsamında bizlere sağladığınız bilgileriniz, buna ek olar" +
"ak mal ve hizmet alımlarınız sırasında çerezler ve benzeri yöntemler aracılığı e" +
"dinilen bilgiler; bizim tarafımızdan, mevcut ve ilerideki iştiraklerimiz, bağlı " +
"şirketlerimiz, hissedarlarımız, iş ortaklarımız, haleflerimiz, hizmet ve faaliye" +
"tlerimiz ile yan hizmetlerimizi yürütmek üzere hizmet aldığımız, işbirliği yaptı" +
"ğımız, yurt içinde ve/veya yurtdışında faaliyet gösteren program ortağı kuruluşl" +
"ar ve diğer üçüncü kişiler (hukuk ve vergi danışmanlarımız, bankalar, bağımsız d" +
"enetçiler dahil ve fakat bunlarla sınırlı olmamak üzere, sizlere hizmet sunabilm" +
"emiz için işbirliği yaptığımız veya yapabileceğimiz hizmet tedarikçileri) ve/vey" +
"a bunların belirleyecekleri üçüncü kişiler/kuruluşlar tarafından muhtelif mal ve" +
" hizmetlerin sağlanması ve her türlü bilgilendirme, reklam-tanıtım, promosyon, s" +
"atış, pazarlama ve üyelik uygulamaları amaçlı yapılacak elektronik ve diğer tica" +
"ri-sosyal iletişimler için, belirtilenler ve halefleri nezdinde süresiz olarak v" +
"eya öngörecekleri süre ile kayda alınabilecek, basılı/manyetik arşivlerde saklan" +
"abilecek, gerekli görülen hallerde güncellenebilecek, paylaşılabilecek, aktarıla" +
"bilecek, transfer edilebilecek, kullanılabilecek ve Kanun’un 5. ve 6. maddelerin" +
"de belirtilen kişisel veri işleme şartları ve amaçları dahilinde işlenebilecekti" +
"r. Buna ek olarak Kanun dahil ilgili mevzuat hükümleri dahilinde zorunlu olması " +
"durumunda bazı uygulamalar ve işlemler için ayrıca ilave izniniz de gerekebilece" +
"ktir. Bu durumlarda sizlerle iletişime geçilecek ve sizlerin açık rızaları rica " +
"edilecektir. Bu verilere ek olarak bizlere iletmiş olduğunuz kişisel verileriniz" +
" hukukun gerekli kıldığı durumlarda resmi kurum/kuruluşlar, mahkemeler tarafında" +
"n talep edilmesi halinde ilgili merci ve mahkemelere iletilebilecektir. </p>\r\n\r\n" +
"                    <p>Kişisel verileriniz internet sitemizde siz kullanıcılarım" +
"ıza daha iyi hizmet sunabilmesi, hizmetlerimizin iyileştirebilmesi, ayrıca bu ko" +
"nuda izin vermiş olmanız durumunda pazarlama faaliyetlerinde kullanılabilmesi, ü" +
"rün/hizmet teklifi, her türlü bilgilendirme, reklam-tanıtım, promosyon, satış, p" +
"azarlama, mağaza kartı, kredi kartı ve üyelik uygulamaları, modelleme, raporlama" +
", skorlama, internet sitesinin kullanımını kolaylaştırılması, kullanıcılarının i" +
"lgi alanlarına ve tercihlerine yönelik tarafımızca veya iştiraklerimiz tarafında" +
"n yapılacak geliştirme çalışmalarda kullanılabilecektir. İnternet sitesi üzerind" +
"e yaptığınız hareketlerin çerezler ve benzeri yöntemlerle izlenebileceğini, kayd" +
"ının tutulabileceğini, istatistiki veya yukarıda bahsedilen amaçlarla kullanılab" +
"ilecektir. Ancak buna ek olarak önemle belirtmek isteriz ki internet sitemize üy" +
"elik, ürün veya hizmetlerimizin satın alınması ve bilgi güncelleme amaçlı girile" +
"n bilgiler, kredi kartı ve banka kartlarına ait gizli bilgiler diğer internet ku" +
"llanıcıları tarafından görüntülenemez.</p>\r\n\r\n                    <p>Ebeveyninin" +
" veya velisinin izni olmadan küçüklerin kişisel verilerini göndermemeleri gerekm" +
"ektedir.</p>\r\n                    <p>Şirket’e ait internet sitesinin, durumun ni" +
"teliğine göre diğer internet sitelerine bağlantılar içermesi halinde bu siteleri" +
"n operatörlerinin veri koruma hükümlerine uygun olup olmamaları hususunda hiçbir" +
" taahhütte bulunmamaktayız. Şirket, link veya benzeri başka yöntemlerle bağlantı" +
" verdiği sitelerin içeriklerinden hiçbir zaman sorumlu değildir.</p>\r\n          " +
"          <p>6698 Sayılı Kişisel Verilerin Korunması Kanunu’nun 11. maddesi uyar" +
"ınca; kişisel verilerinizin işlenip işlenmediğini öğrenme, kişisel verileriniz i" +
"şlenmişse buna ilişkin bilgi talep etme, kişisel verilerinizin işlenme amacını v" +
"e bunların amacına uygun kullanılıp kullanılmadığını öğrenme, yurt içinde veya y" +
"urt dışında kişisel verilerinizin aktarıldığı üçüncü kişileri bilme, kişisel ver" +
"ilerinizin eksik veya yanlış işlenmiş olması halinde bunların düzeltilmesini ist" +
"eme ve bu kapsamda yapılan işleme ilişkin olarak kişisel verilerinizin aktarıldı" +
"ğı üçüncü kişilere bildirilmesini isteme, Kanun’un ve ilgili sair mevzuat hüküml" +
"erine uygun olarak işlenmiş olmasına rağmen, işlenmesini gerektiren sebeplerin o" +
"rtadan kalkması halinde kişisel verilerin silinmesini veya yok edilmesini isteme" +
" ve bu kapsamda yapılan işlemin kişisel verilerinizin aktarıldığı üçüncü kişiler" +
"e bildirilmesini isteme, işlenen verilerin münhasıran otomatik sistemler vasıtas" +
"ıyla analiz edilmesi suretiyle aleyhinize bir sonucun ortaya çıkmasına itiraz et" +
"me, kişisel verilerinizin Kanun’a aykırı olarak işlenmesi sebebiyle zarara uğram" +
"anız halinde zararın giderilmesini talep etme haklarına sahipsiniz. Kişisel veri" +
" sahipleri olarak, az önce saymış olduğumuz haklarınıza ilişkin taleplerinizi, s" +
"öz konusu yöntemlerle Şirket’e iletmeniz durumunda Şirketimiz talebin niteliğine" +
" göre en kısa sürede ve en geç otuz gün içinde ücretsiz olarak sonuçlandıracaktı" +
"r. Ancak, işlemin ayrıca bir maliyeti gerektirmesi halinde Kişisel Verileri Koru" +
"ma Kurulunca belirlenen tarifedeki ücret alınabilir.</p>\r\n                    <p" +
">Kanun’un 13. maddesinin 1. fıkrası gereğince, yukarıda belirtilen haklarınızı k" +
"ullanmak ile ilgili talebinizi, yazılı olarak veya Kişisel Verileri Koruma Kurul" +
"u’nun belirlediği diğer yöntemlerle Şirket’e iletebilirsiniz. Kişisel Verileri K" +
"oruma Kurulu tarafından şu aşamada ilgili haklarınızın kullanımına ilişkin herha" +
"ngi bir yöntem belirlemediği için, başvurunuzu Kanun gereğince, yazılı olarak Şi" +
"rket’e iletmeniz gerekmektedir. </p>\r\n                    <p><b>Çerezler</b></p>" +
"\r\n                    <p>İnternet sitemizde; IP adresi, kullanılan tarayıcı, bil" +
"gisayarınızdaki işletim sistemi, internet bağlantınız, site kullanımları hakkınd" +
"aki bilgiler gibi belirli verileri otomatik olarak elde etmemize yardımcı olan ç" +
"erezler (cookie) bulunmaktadır. Söz konusu çerezler bir internet sayfası sunucus" +
"u tarafından sabit sürücünüze iletilen küçük metin dosyalarıdır ve sitemizde bul" +
"unan çerezler, bilgisayarınız için zararlı sayılabilecek virüsler göndermek için" +
" kullanılmamaktadır. </p>\r\n                    <p>Çerezler genellikle bilgisayar" +
"ınızda saklanarak, internet sitemizde yapmış olduğunuz işlemler, gezintileriniz " +
"esnasındaki tıklamalarınızın kaydedilmesi yolu ile internet sitesini hangi zaman" +
" dilimi içerisinde, ne kadar süre ile kaç kişinin kullandığı, bir kişinin intern" +
"et sitesini hangi amaçlarla, kaç kez ziyaret ettiği ve site üzerinde ne kadar va" +
"kit harcadığı hakkında istatistiksel bilgileri elde etmek ve kullanıcı sayfaları" +
"ndan dinamik olarak reklam ve içerik üretilmesine yardımcı olmak amacı ile sağla" +
"nmaktadır. İnternet sitemizi kullanarak kullanılan çerezleri onaylamış olursunuz" +
". Şirket, söz konusu çerezler aracılığı ile verilerinizi işleyebilir ve elde edi" +
"len bilgileri analiz etme amacı ile bu kapsamda yurtiçinde ve yurtdışında üçüncü" +
" kişilere aktarabilir.</p>\r\n                    <p>Çerezler tarafından verilerin" +
"iz toplanmadan internet sitemizi görüntülemek istiyorsanız seçiminizi cihazınızı" +
"n/tarayıcınızın ayarlarından her zaman değiştirebilirsiniz. Çerezlerin kullanımı" +
"nı durdurduğunuzda internet sitemizde her türlü işlemi belirli özelliklerinin ça" +
"lışmayabileceğini lütfen unutmayınız.</p>\r\n                    <p><b>Açık Rıza</" +
"b></p>\r\n                    <p>Sizler, internet sitemize girerek tarafımıza sağl" +
"amış olduğunuz kişisel verilerinizin Kanun’a ve işbu 6698 Sayılı Kişisel Veriler" +
"in Korunması Kanunu’ne uygun bir şekilde ve belirtilen amaçlarla işlenebileceğin" +
"i bilmekte, kabul etmekte ve ayrıca işbu 6698 Sayılı Kişisel Verilerin Korunması" +
" Kanunu ile Kanun kapsamında yapılması gereken aydınlatma yükümlülüğü yerine get" +
"irildiğini, Sözleşme’yi okuduğunuzu, anladığınızı, haklarınızın ve yükümlülükler" +
"inin bilincinde olduğunuzu beyan etmektesiniz.</p>\r\n                </div>\r\n    " +
"            \r\n            </div>\r\n            \r\n            <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-textbox-form2\"");

WriteLiteral(">\r\n\r\n                ");

WriteLiteral("\r\n                <select required");

WriteLiteral(" id=\"subject\"");

WriteLiteral(" name=\"subject\"");

WriteLiteral(">\r\n                    <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">Seçiniz...</option>\r\n                    <option");

WriteLiteral(" value=\"1\"");

WriteLiteral(">Bilgi talep ediyorum</option>\r\n                    <option");

WriteLiteral(" value=\"2\"");

WriteLiteral(">Öneri / Şikayetim var</option>\r\n                    <option");

WriteLiteral(" value=\"3\"");

WriteLiteral(">Ürünlerle ilgili önerim var</option>\r\n                    <option");

WriteLiteral(" value=\"4\"");

WriteLiteral(">İş ortağınız olmak istiyorum</option>\r\n                    <option");

WriteLiteral(" value=\"5\"");

WriteLiteral(">Teşekkür etmek istiyorum</option>\r\n                </select>\r\n\r\n");

WriteLiteral("                ");

            
<<<<<<< HEAD
            #line 102 "..\..\MVC\Views\Form\ContactForm.cshtml"
=======
            #line 100 "..\..\MVC\Views\Form\ContactForm.cshtml"
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3
           Write(Html.TextAreaFor(m => m.Message, new { Name = "00N0Y00000QeRBp", id = "00N0Y00000QeRBp", placeholder = "Mesajınız" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"responsive-contract-text\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text flex homepage-contact-descriptio" +
"n-text\"");

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

WriteLiteral("></path></svg><!-- <i class=\"fas fa-caret-down\"></i> -->\r\n                    </d" +
"iv>\r\n                    <div");

WriteLiteral(" class=\"wizard-bottom-left-content-form-row-text__hide homepage-contact-descripti" +
"on-p\"");

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
"    ");

WriteLiteral("\r\n                </div>\r\n                <label");

WriteLiteral(" for=\"Contract-hp\"");

WriteLiteral(" class=\"hp-contract\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
<<<<<<< HEAD
            #line 134 "..\..\MVC\Views\Form\ContactForm.cshtml"
=======
            #line 132 "..\..\MVC\Views\Form\ContactForm.cshtml"
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3
               Write(Html.CheckBoxFor(m => m.Contract, new { required = "required", id = "Contract-hp" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    Kişisel Veriler Bilgilendirme Metni\'ni Kabul Ediyorum\r\n    " +
"            </label>\r\n                <div");

WriteLiteral(" class=\"page-section-contact-container-area-left-form-button\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n                    <input");

WriteLiteral(" class=\"hp_btn\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" name=\"SaveButton\"");

WriteLiteral(" value=\"Gönder\"");

WriteLiteral(" onclick=\"return contactFormSubmit(\'contactForm\');\"");

<<<<<<< HEAD
WriteLiteral(" />\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"errorMessage\"");

WriteLiteral("></div>\r\n\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n");
=======
WriteLiteral(" />\r\n                </div>\r\n\r\n\r\n            </div>\r\n            \r\n        </div>" +
"\r\n    </div>\r\n");
>>>>>>> 69f11600b7c9826f2aae025189d89e920138f1a3

            
            #line 147 "..\..\MVC\Views\Form\ContactForm.cshtml"



}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591

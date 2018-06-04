using SitefinityWebApp.Library;
using SitefinityWebApp.Library.Model;
using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "ProductSelectionWizard", Title = "Ürün Seçme Sihirbazı", SectionName = "FormModel")]
    public class ProductSelectionWizardController : Controller
    {
        // GET: ProductSelectionWizard
        public ActionResult Index()
        {
            SFProcess sf = new SFProcess();
            //sf.GetForm(Guid.Parse("57D3E456-2C5D-4636-9218-52310E744638"), "test");
            //sf.GetFormFieldValuesFromFormResponses("sf_mikroproduct", "test1");           

            ProductSelectionWizard m = new ProductSelectionWizard()
            {
                FormItems = sf.GetProductForm()
            };

            return View(Names.PagesView.ProductSelectionWizard, m);
        }

        [HttpPost]
        public JsonResult SendMail()
        {
            try
            {
                if (!String.IsNullOrEmpty(Request["first_name"]) && !String.IsNullOrEmpty(Request["last_name"]) && !String.IsNullOrEmpty(Request["_phone"]) && !String.IsNullOrEmpty(Request["email"]))
                {

                    string formId = Request["formId"];
                    string name = Request["first_name"];
                    string surname = Request["last_name"];
                    string phone = Request["_phone"];
                    string subject = Request["subject"];
                    string message = Request["00N0Y00000QeRBp"];
                    string email = Request["email"];
                    string product = Request["00N0Y00000QeNmD"];

                    string fileHtml, formTitle;


                    switch (formId)
                    {
                        case "demoForm":
                            fileHtml = "demo-request";
                            formTitle = "Demo Talep Formu";
                            break;
                        case "productForm":
                            fileHtml = "product";
                            formTitle = "Ürün Seçme Sihirbazı";
                            break;
                        default:
                            fileHtml = "contact";
                            formTitle = "İletişim Formu";
                            break;
                    }

                    MailHelper mail = new MailHelper();

                    mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "satis@mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
                    //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr","Mert.ALANKAYA@mikro.com.tr" };
                    //mail.Bcc = new List<string>() { "aykut.saridede@ph.com.tr" };
                    mail.From = "no-reply@e-mail.mikro.com.tr";
                    mail.FromDisplayName = "Mikro";

                    string body = String.Empty;
                    using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/" + fileHtml + ".html"), System.Text.Encoding.UTF8))
                        body = sr.ReadToEnd();

                    body = body.Replace("@@ad@@", name);
                    body = body.Replace("@@soyad@@", surname);
                    body = body.Replace("@@telefon@@", phone);
                    body = body.Replace("@@mesaj@@", message);
                    body = body.Replace("@@eposta@@", email);
                    body = body.Replace("@@urun@@", product);

                    if (formId == "productForm")
                    {
                        SFProcess sf = new SFProcess();
                        List<FormModel> fModel = new List<FormModel>();
                        fModel = sf.GetProductForm();
                        string pContent = "";
                        if (fModel != null && fModel.Count > 0)
                        {
                            foreach (var item in fModel)
                            {
                                pContent += item.LabelValue + " : " + Request.Form["" + item.InputName + ""] + "</br>";
                            }
                        }

                        body = body.Replace("@@urunler@@", pContent);


                    }

                    mail.Body = body;
                    mail.Subject = formTitle;
                    bool rtn = mail.SendMail();
                    if (rtn)
                    {
                        return Json(true);
                    }
                    else
                    {
                        return Json(false);
                    }
                }
                else
                {
                    return Json(false);
                }


            }
            catch (Exception ex)
            {
                return Json(false);
            }
        }

        [HttpPost]
        public JsonResult ContactSendMail()
        {
            try
            {
                if (!String.IsNullOrEmpty(Request["first_name"]) && !String.IsNullOrEmpty(Request["last_name"]) && !String.IsNullOrEmpty(Request["phone"]) && !String.IsNullOrEmpty(Request["subject"]) && !String.IsNullOrEmpty(Request["00N0Y00000QeRBp"]) && !String.IsNullOrEmpty(Request["email"]))
                {
                    string name = Request["first_name"];
                    string surname = Request["last_name"];
                    string phone = Request["phone"];
                    string subject = Request["subject"];
                    string message = Request["00N0Y00000QeRBp"];
                    string email = Request["email"];

                    MailHelper mail = new MailHelper();
                    mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
                    switch (subject)
                    {
                        case "1":
                            mail.CC = new List<string>() { "satissonrasi@mikro.com.tr" };
                            subject = "Bilgi talep ediyorum";
                            break;
                        case "2":
                            mail.CC = new List<string>() { "Serpil.EREN@mikro.com.tr"};
                            subject = "Öneri / Şikayetim var";
                            break;
                        case "3":
                            mail.CC = new List<string>() { "urungelistirme@mikro.com.tr" };
                            subject = "Ürünlerle ilgili önerim var";
                            break;
                        case "4":
                            mail.CC = new List<string>() { "satis@mikro.com.tr" };
                            subject = "İş ortağınız olmak istiyorum";
                            break;
                        case "5":
                            mail.CC = new List<string>() { "satis@mikro.com.tr" };
                            subject = "Teşekkür etmek istiyorum";
                            break;
                        default:
                            break;
                    }

                    //mail.Bcc = new List<string>() { "aykut.saridede@ph.com.tr", "Arzu.AydemirErgin@ph.com.tr" };
                    mail.From = "no-reply@e-mail.mikro.com.tr";
                    mail.FromDisplayName = "Mikro";

                    string body = String.Empty;
                    using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/contact.html"), System.Text.Encoding.UTF8))
                        body = sr.ReadToEnd();


                    body = body.Replace("@@ad@@", name);
                    body = body.Replace("@@soyad@@", surname);
                    body = body.Replace("@@telefon@@", phone);
                    body = body.Replace("@@mesaj@@", message);
                    body = body.Replace("@@eposta@@", email);
                    body = body.Replace("@@subject@@", subject);
                    

                    mail.Body = body;
                    mail.Subject = "İletişim Formu";
                    bool rtn = mail.SendMail();
                }




                return Json(true);
            }
            catch (Exception ex)
            {
                return null;
            }

            
        }
    }
}
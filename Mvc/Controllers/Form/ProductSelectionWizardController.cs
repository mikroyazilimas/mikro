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
        public ActionResult Index(ProductSelectionWizard m)
        {
            MailHelper mail = new MailHelper();
            LogProcess logProcess = new LogProcess();
            mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "satis@mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
            //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr","Mert.ALANKAYA@mikro.com.tr" };
            //mail.To = new List<string>() { "aykut.saridede@ph.com.tr" };
            mail.From = "no-reply@e-mail.mikro.com.tr";
            mail.FromDisplayName = "Mikro";
            try
            {
                RestApiService restApi = new RestApiService();

                //string formId = Request["formId"];
                //string name = Request["first_name"];
                //string surname = Request["last_name"];
                //string phone = Request["_phone"];
                //string subject = Request["subject"];
                //string message = Request["00N0Y00000QeRBp"];
                //string email = Request["email"];
                //string product = Request["00N0Y00000QeNmD"];
                //string refUrl = Request["refUrl"];
                //string city = Request["city"];

                string gclid = WebTools.GetQueryStringValueFromUrlReferrer("gclid") ?? WebTools.GetQueryStringValueFromRawUrl("gclid");
                string utm_campaign = WebTools.GetQueryStringValueFromUrlReferrer("utm_campaign") ?? WebTools.GetQueryStringValueFromRawUrl("utm_campaign");
                string utm_medium = WebTools.GetQueryStringValueFromUrlReferrer("utm_medium") ?? WebTools.GetQueryStringValueFromRawUrl("utm_medium");
                string utm_source = WebTools.GetQueryStringValueFromUrlReferrer("utm_source") ?? WebTools.GetQueryStringValueFromRawUrl("utm_source");

                if (String.IsNullOrEmpty(gclid))
                    gclid = WebTools.GetCookieValue(Names.Cookie.Gclid);

                if (String.IsNullOrEmpty(utm_campaign))
                    utm_campaign = WebTools.GetCookieValue(Names.Cookie.UtmCampaign);

                if (String.IsNullOrEmpty(utm_medium))
                    utm_medium = WebTools.GetCookieValue(Names.Cookie.UtmMedium);

                if (String.IsNullOrEmpty(utm_source))
                    utm_source = WebTools.GetCookieValue(Names.Cookie.UtmSource);

                Input_RequestForm inpt = new Input_RequestForm
                {
                    firstName = m.Name,
                    lastName = m.Surname,
                    email = m.Email,
                    phone = m._phone,
                    company = m.CompanyName,
                    status = "New",
                    foundationYear = Request.Form["00N0Y00000QeNYf"],
                    sector = !String.IsNullOrEmpty(Request.Form["00N0Y00000QeRAN"]) ? int.Parse(Request.Form["00N0Y00000QeRAN"]).ToString() : "",
                    numberOfEmployees = Request.Form["00N0Y00000QeNYu"],
                    currentSituation = Request.Form["00N0Y00000QeR9j"],
                    numberOfUser = Request.Form["00N0Y00000QeNjE"],
                    currentSoftware = Request.Form["00N0Y00000QeNlZ"],
                    gclid = gclid,
                    utmCampaign = utm_campaign,
                    utmMedium = utm_medium,
                    utmSource = utm_source,
                    leadSource = "USS",
                    izinDurumu = m.IsAllowData ? "Izinli" : "Izinsiz"
                };
                inpt.phone = "0" + inpt.phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace(" ", "").Replace(" ", "");

                //db --start
                SFProcess process = new SFProcess();
                process.SaveProductWizardForm(new ProductWizardFormModel
                {
                    City = inpt.city,
                    Company = inpt.company,
                    CurrentSituation = inpt.currentSituation,
                    CurrentSoftware = inpt.currentSoftware,
                    Email = inpt.email,
                    FirstName = inpt.firstName,
                    FoundationYear = inpt.foundationYear,
                    GClid = inpt.gclid,
                    IPAddress = WebTools.GetIpAddress,
                    LastName = inpt.lastName,
                    NumberOfEmployees = inpt.numberOfEmployees,
                    NumberOfUser = inpt.numberOfUser,
                    Phone = inpt.phone,
                    Sector = inpt.sector,
                    UtmCampaign = inpt.utmCampaign,
                    UtmMedium = inpt.utmMedium,
                    UtmSource = inpt.utmSource
                });
                //db --end

                string body = String.Empty;
                using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/product.html"), System.Text.Encoding.UTF8))
                    body = sr.ReadToEnd();

                body = body.Replace("@@ad@@", inpt.firstName);
                body = body.Replace("@@soyad@@", inpt.lastName);
                body = body.Replace("@@telefon@@", inpt.phone);
                body = body.Replace("@@eposta@@", inpt.email);
                body = body.Replace("@@city@@", inpt.city);

                Output_DemoRequest resp = restApi.DemoRequestForm(inpt);
                if (resp.isSuccess)
                {
                    if (true)
                    {
                        SFProcess sf = new SFProcess();
                        List<FormModel> fModel = new List<FormModel>();
                        fModel = sf.GetProductForm();
                        string pContent = "";
                        string nameVal = "";
                        if (fModel != null && fModel.Count > 0)
                        {
                            foreach (var item in fModel)
                            {
                                nameVal = Request.Form["" + item.InputName + ""];
                                if (item.InputType == Library.InputType.DropDown)
                                {
                                    try
                                    {
                                        nameVal = item.DropDownItem.Where(x => x.Value == Request.Form["" + item.InputName + ""]).FirstOrDefault().Text;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                                pContent += item.LabelValue + " : " + nameVal + "</br>";
                            }
                        }

                        body = body.Replace("@@urunler@@", pContent);


                    }
                    mail.Body = body;
                    mail.Subject = "Ürün Seçme Sihirbazı";
                    bool rtn = mail.SendMail();
                    if (rtn)
                    {
                        Response.Redirect(String.Format("{0}?{1}", Names.Pages.Thanks, Request.Form["retURL"]), false);
                        return View();
                    }
                    else
                    {
                        logProcess.WriteLog("Mail Gönderirken hata oluştu <br> " + body);
                        //hata yazılıcak
                    }
                }
                else
                {
                    mail.To = new List<string>() { "emre.gultekin@h.com.tr" };
                    logProcess.WriteLog(" SalesFoce yazarken hata oluştu <br> Hata : " + resp.message + " <br> " + body);
                    mail.Subject = "Ürün Seçme Sihirbazı - HATA";
                    mail.Body = resp.MessageCode + " - " + resp.message;
                    mail.SendMail();
                    //hata mail atılıcak ve yazılıcak
                }
            }
            catch (Exception ex)
            {
                mail.To = new List<string>() { "emre.gultekin@h.com.tr" };
                logProcess.Create(ex);
                mail.Subject = "Ürün Seçme Sihirbazı - HATA";
                mail.Body = ex.Message.ToString();
                mail.SendMail();
                //hata mail atılıcak ve yazılıcak
            }
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
                    string refUrl = Request["refUrl"];
                    string city = Request["city"];

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
                            formTitle = "Bize Ulaşın Formu";
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
                    body = body.Replace("@@subject@@", subject);
                    body = body.Replace("@@refUrl@@", refUrl);
                    body = body.Replace("@@city@@", city);


                    if (formId == "productForm")
                    {
                        SFProcess sf = new SFProcess();
                        List<FormModel> fModel = new List<FormModel>();
                        fModel = sf.GetProductForm();
                        string pContent = "";
                        string nameVal = "";
                        if (fModel != null && fModel.Count > 0)
                        {
                            foreach (var item in fModel)
                            {
                                nameVal = Request.Form["" + item.InputName + ""];
                                if (item.InputType == Library.InputType.DropDown)
                                {
                                    try
                                    {
                                        nameVal = item.DropDownItem.Where(x => x.Value == Request.Form["" + item.InputName + ""]).FirstOrDefault().Text;
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                                pContent += item.LabelValue + " : " + nameVal + "</br>";
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
                if (!String.IsNullOrEmpty(Request["Name"]) && !String.IsNullOrEmpty(Request["Surname"]) && !String.IsNullOrEmpty(Request["_phone"]) && !String.IsNullOrEmpty(Request["Subject"]) && !String.IsNullOrEmpty(Request["Email"]))
                {
                    string name = Request["Name"];
                    string surname = Request["Surname"];
                    string phone = Request["_phone"];
                    string subject = Request["Subject"];
                    string message = Request["Message"];
                    string email = Request["Email"];

                    MailHelper mail = new MailHelper();
                    mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
                    switch (subject)
                    {
                        case "1":
                            mail.CC = new List<string>() { "satissonrasi@mikro.com.tr" };
                            subject = "Bilgi talep ediyorum";
                            break;
                        case "2":
                            mail.CC = new List<string>() { "Serpil.EREN@mikro.com.tr" };
                            subject = "Öneri / Şikayetim var";
                            break;
                        case "3":
                            mail.CC = new List<string>() { "urunonerileri@mikro.com.tr" };
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

                    //db --start
                    Input_RequestForm inpt = new Input_RequestForm
                    {
                        firstName = name,
                        lastName = surname,
                        email = email,
                        phone = phone,
                        company = "company",
                        status = "New",
                        leadSource = "Contact Form",
                        gclid = WebTools.GetQueryStringValueFromRawUrl("gclid") ?? WebTools.GetCookieValue(Names.Cookie.Gclid),
                        utmCampaign = WebTools.GetQueryStringValueFromRawUrl("utm_campaign") ?? WebTools.GetCookieValue(Names.Cookie.UtmCampaign),
                        utmMedium = WebTools.GetQueryStringValueFromRawUrl("utm_medium") ?? WebTools.GetCookieValue(Names.Cookie.UtmMedium),
                        utmSource = WebTools.GetQueryStringValueFromRawUrl("utm_source") ?? WebTools.GetCookieValue(Names.Cookie.UtmSource),
                        formNotes = message
                    };

                    SFProcess process = new SFProcess();
                    process.SaveContactForm(new ContactFormModel
                    {
                        City = inpt.city,
                        Company = inpt.company,
                        Email = inpt.email,
                        FirstName = inpt.firstName,
                        GClid = inpt.gclid,
                        IPAddress = WebTools.GetIpAddress,
                        LastName = inpt.lastName,
                        Phone = inpt.phone,
                        UtmCampaign = inpt.utmCampaign,
                        UtmMedium = inpt.utmMedium,
                        UtmSource = inpt.utmSource,
                        Message = inpt.formNotes,
                        Subject = subject
                    });
                    //db --end

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

                    if (rtn)
                    {
                        RestApiService restApi = new RestApiService();
                        inpt.phone = "0" + inpt.phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace(" ", "").Replace(" ", "");
                        Output_DemoRequest resp = restApi.DemoRequestForm(inpt);
                    }
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
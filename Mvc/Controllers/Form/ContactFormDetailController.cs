using SitefinityWebApp.Library;
using SitefinityWebApp.Library.Model;
using SitefinityWebApp.Mvc.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SitefinityWebApp.Mvc.Controllers.Form
{
    [ControllerToolboxItem(Name = "ContactFormDetail", Title = "İletişim Detay Form", SectionName = "FormModel")]
    public class ContactFormDetailController : Controller
    {
        // GET: ContactFormDetail
        public ActionResult Index()
        {
            try
            {
                ContactForm m = new ContactForm() { };
                return View(Names.PagesView.ContactFormDetail, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactForm m)
        {
            LogProcess logProcess = new LogProcess();
            MailHelper mail = new MailHelper();
            mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr", "satis@mikro.com.tr" };
            mail.From = "no-reply@e-mail.mikro.com.tr";
            mail.FromDisplayName = "Mikro";
            try
            {
                RestApiService restApi = new RestApiService();
                Input_RequestForm inpt = new Input_RequestForm
                {
                    firstName = m.Name,
                    lastName = m.Surname,
                    email = m.Email,
                    phone = m._phone,
                    company = m.CompanyName ?? "company",
                    status = "New",
                    leadSource = "Contact Form",
                    gclid = WebTools.GetQueryStringValueFromRawUrl("gclid") ?? WebTools.GetCookieValue(Names.Cookie.Gclid),
                    utmCampaign = WebTools.GetQueryStringValueFromRawUrl("utm_campaign") ?? WebTools.GetCookieValue(Names.Cookie.UtmCampaign),  
                    utmMedium = WebTools.GetQueryStringValueFromRawUrl("utm_medium") ?? WebTools.GetCookieValue(Names.Cookie.UtmMedium),
                    utmSource = WebTools.GetQueryStringValueFromRawUrl("utm_source") ?? WebTools.GetCookieValue(Names.Cookie.UtmSource),
                    formNotes = m.Message
                };
                inpt.phone = "0" + inpt.phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace(" ", "").Replace(" ", "");

                //db --start
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
                    Subject = string.Empty
                });
                //db --end

                string body = String.Empty;
                using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/contact.html"), System.Text.Encoding.UTF8))
                    body = sr.ReadToEnd();

                body = body.Replace("@@ad@@", inpt.firstName);
                body = body.Replace("@@soyad@@", inpt.lastName);
                body = body.Replace("@@telefon@@", inpt.phone);
                body = body.Replace("@@mesaj@@", inpt.formNotes);
                body = body.Replace("@@eposta@@", inpt.email);
                body = body.Replace("@@subject@@", "-");

                Output_DemoRequest resp = restApi.DemoRequestForm(inpt);
                if (resp.isSuccess)
                {
                    mail.Body = body;
                    mail.Subject = "Bize Ulaşın Formu";
                    bool rtn = mail.SendMail();
                    if (true)
                    {
                        Response.Redirect(Names.Pages.Thanks, false);
                        return View();
                    }
                    //else
                    //{
                    //    logProcess.WriteLog("Mail Gönderirken hata oluştu <br> " + body);
                    //    //hata yazılıcak
                    //}
                }
                else
                {
                    //logProcess.WriteLog(" SalesFoce yazarken hata oluştu <br> Hata : " + resp.message + " <br> " + body);
                    //mail.Subject = "Demo Talep Formu - HATA";
                    //mail.Body = body;
                    //mail.SendMail();
                    //hata mail atılıcak ve yazılıcak
                }
            }
            catch (Exception ex)
            {
                logProcess.Create(ex);
                //mail.Subject = "Demo Talep Formu - HATA";
                //mail.Body = "Demo talep formunda hata oluştu.";
                //mail.SendMail();
                //hata mail atılıcak ve yazılıcak
            }

            if (Request.UrlReferrer != null)
                return Redirect(Request.UrlReferrer.ToString());
            else
                return View();
        }
    }
}
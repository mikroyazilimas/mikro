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
    [ControllerToolboxItem(Name = "DemoRequestDetailForm", Title = "Demo Talep Detay Formu", SectionName = "FormModel")]
    public class DemoRequestFormDetailController : Controller
    {
        // GET: DemoRequestFormDetail
        public ActionResult Index()
        {
            try
            {
                SFProcess sf = new SFProcess();
                //sf.GetForm(Guid.Parse("57D3E456-2C5D-4636-9218-52310E744638"), "test");
                //sf.GetFormFieldValuesFromFormResponses("sf_mikroproduct", "test1");

                sf.GetProductForm();

                DemoRequestForm m = new DemoRequestForm()
                {
                    refUrl = Request.UrlReferrer != null ? Request.UrlReferrer.ToString() : Request.Url.ToString().Split('?')[0],
                    Product = Request.QueryString["product"]
                };

                m.City = new DropDownListModel<Library.Model.City>
                {
                    Items = new List<City>() { new City() { Id = 34, Name = "İstanbul" } },
                    SelectedItem = new City() { Id = 34, Name = "İstanbul" },
                    Text = "Name",
                    Value = "Name"
                };

                m.County = new DropDownListModel<Library.Model.District>
                {
                    Items = new List<District>() { new District() { Id = 34, Name = "Ataköy" } },
                    SelectedItem = new District() { Id = 34, Name = "Ataköy" },
                    Text = "Name",
                    Value = "Name"
                };

                m.NumberOfEmployees = new DropDownListModel<KeyValue>
                {
                    Items = new List<KeyValue>() { new KeyValue() { Value = "1-5 kişi arası" }, new KeyValue() { Value = "6-10 kişi arası" }, new KeyValue() { Value = "11-20 kişi arası" }, new KeyValue() { Value = "21-50 kişi arası" }, new KeyValue() { Value = "50 kişi üzeri" } },
                    //SelectedItem = new City() { Id = 1, Name = "İstanbul" },
                    Text = "Value",
                    Value = "Value"
                };

                return View(Names.PagesView.DemoRequestDetailForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();

        }

        [HttpPost]
        public ActionResult Index(DemoRequestForm m)
        {
            MailHelper mail = new MailHelper();
            LogProcess logProcess = new LogProcess();
            mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "satis@mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
            //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr","Mert.ALANKAYA@mikro.com.tr" };
            //mail.To = new List<string>() { "aykut.saridede@ph.com.tr" };
            mail.From = "no-reply@e-mail.mikro.com.tr";
            mail.FromDisplayName = "Mikro";
            string body = String.Empty;
            try
            {
                RestApiService restApi = new RestApiService();
                string city = string.Empty;
                if (!String.IsNullOrEmpty(Request.Form["City"]))
                    city = Request.Form["City"].ToUpper(new CultureInfo("tr-TR"));

                Input_RequestForm inpt = new Input_RequestForm
                {
                    firstName = m.Name,
                    lastName = m.Surname,
                    email = m.Email,
                    phone = m._phone,
                    city = city,
                    company = "company",
                    status = "New",
                    productGroup = m.Product,
                    leadSource = "Demo Request",
                    gclid = WebTools.GetQueryStringValueFromRawUrl("gclid") ?? WebTools.GetCookieValue(Names.Cookie.Gclid),
                    utmCampaign = WebTools.GetQueryStringValueFromRawUrl("utm_campaign"),  
                    utmMedium = WebTools.GetQueryStringValueFromRawUrl("utm_medium"),
                    utmSource = WebTools.GetQueryStringValueFromRawUrl("utm_source"),
                    formNotes = m.Message
                };
                inpt.phone = "0" + inpt.phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace(" ", "").Replace(" ", "");

                //db --start
                SFProcess process = new SFProcess();
                process.SaveDemoRequestForm(new DemoRequestFormModel
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
                    ProductGroup = inpt.productGroup
                });
                //db --end

                body = String.Empty;
                using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/demo-request.html"), System.Text.Encoding.UTF8))
                    body = sr.ReadToEnd();

                body = body.Replace("@@ad@@", inpt.firstName);
                body = body.Replace("@@soyad@@", inpt.lastName);
                body = body.Replace("@@telefon@@", inpt.phone);
                body = body.Replace("@@mesaj@@", inpt.formNotes);
                body = body.Replace("@@eposta@@", inpt.email);
                body = body.Replace("@@urun@@", inpt.productGroup);
                body = body.Replace("@@refUrl@@", m.refUrl);
                body = body.Replace("@@city@@", inpt.city);

                Output_DemoRequest resp = restApi.DemoRequestForm(inpt);
                if (resp.isSuccess)
                {
                    mail.Body = body;
                    mail.Subject = "Demo Talep Formu";
                    bool rtn = mail.SendMail();
                    if (rtn)
                    {
                        Response.Redirect(Names.Pages.Thanks, false);
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
                    logProcess.WriteLog(" SalesFoce yazarken hata oluştu <br> Hata : " + resp.message + " <br> " + body);
                    mail.Subject = "Demo Talep Formu - HATA";
                    mail.Body = body;
                    mail.SendMail();
                    //hata mail atılıcak ve yazılıcak
                }
            }
            catch (Exception ex)
            {
                logProcess.Create(ex);
                mail.Subject = "Demo Talep Formu - HATA";
                mail.Body = body;
                mail.SendMail();
                //hata mail atılıcak ve yazılıcak
            }
            return View(Names.PagesView.DemoRequestDetailForm, m);
        }
    }
}
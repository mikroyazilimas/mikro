using SitefinityWebApp.Library;
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
    [ControllerToolboxItem(Name = "AuthorizedDealerForm", Title = "Yetkili Satıcı Formu", SectionName = "FormModel")]
    public class AuthorizedDealerFormController : Controller
    {
        // GET: AuthorizedDealerForm
        public ActionResult Index()
        {
            try
            {

                AuthorizedDealerForm m = new AuthorizedDealerForm() {
                    IsAlert = false
                };
                m.FieldsOfActivity = new List<FieldsOfActivityItem>
                {
                    new FieldsOfActivityItem { Text = "Bilgisayar Satışı" },
                    new FieldsOfActivityItem { Text = "Program Satışı" },
                    new FieldsOfActivityItem { Text = "OEM Satış" },
                    new FieldsOfActivityItem { Text = "Yazılım Geliştirme" },
                    new FieldsOfActivityItem { Text = "Eğitim" },
                    new FieldsOfActivityItem { Text = "Sistem Kurulumu" },
                    new FieldsOfActivityItem { Text = "Diğer" }
                };


                return View(Names.PagesView.AuthorizedDealerForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(AuthorizedDealerForm m)
        {
            try
            {


                MailHelper mail = new MailHelper();

                //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr", "satis@mikro.com.tr", "Mert.ALANKAYA@mikro.com.tr" };
                //mail.To = new List<string>() { "no-reply@e-mail.mikro.com.tr","Mert.ALANKAYA@mikro.com.tr" };
                mail.To = new List<string>() { "satis@mikro.com.tr" };
                mail.From = "no-reply@e-mail.mikro.com.tr";
                mail.FromDisplayName = "Mikro";

                string body = String.Empty;
                using (StreamReader sr = new StreamReader(Server.MapPath("~/Html/authorized-dealer.html"), System.Text.Encoding.UTF8))
                    body = sr.ReadToEnd();

                //Firma Bilgileri
                body = body.Replace("@@CompanyName@@", m.CompanyName);
                body = body.Replace("@@Authorized@@", m.Authorized);
                body = body.Replace("@@City@@", m.City);

                body = body.Replace("@@Town@@", m.Town);
                body = body.Replace("@@Task@@", m.Task);
                body = body.Replace("@@PostCode@@", m.PostCode);
                body = body.Replace("@@Fax@@", m.Fax);
                body = body.Replace("@@EMail@@", m.EMail);
                body = body.Replace("@@Adress@@", m.Adress);
                body = body.Replace("@@phone@@", m.phone);
                //Genel Bilgiler
                body = body.Replace("@@Gmanager@@", m.GManager);
                body = body.Replace("@@GAsstManager@@", m.GAsstManager);
                body = body.Replace("@@GMarketManager@@", m.GMarketManager);
                body = body.Replace("@@GTechManager@@", m.GTechManager);
                body = body.Replace("@@GSalesRepresentative@@", m.GSalesRepresentative);
                //Muhasebe Bilgileri
                body = body.Replace("@@MAccountant@@", m.MAccountant);
                body = body.Replace("@@MTaxAdmin@@", m.MTaxAdmin);
                body = body.Replace("@@MTaxNumber@@", m.MTaxNumber);
                body = body.Replace("@@MYearEstablishment@@", m.MYearEstablishment);
                body = body.Replace("@@MRecordCapital@@", m.MRecordCapital);
                //İşyeri Bilgileri

                //Çalıştığınız Bankalar
                body = body.Replace("@@BName@@", m.BName);
                body = body.Replace("@@BAccountNo@@", m.BAccountNo);
                body = body.Replace("@@BPhone@@", m.BPhone);
                body = body.Replace("@@BName2@@", m.BName2);
                body = body.Replace("@@BAccountNo2@@", m.BAccountNo2);
                body = body.Replace("@@BPhone2@@", m.BPhone2);
                body = body.Replace("@@BName3@@", m.BName3);
                body = body.Replace("@@BAccountNo3@@", m.BAccountNo3);
                body = body.Replace("@@BPhone3@@", m.BPhone3);
                //Referanslar
                body = body.Replace("@@RName@@", m.RName);
                body = body.Replace("@@RAuthorized@@", m.RAuthorized);
                body = body.Replace("@@RPhone@@", m.RPhone);
                body = body.Replace("@@RName2@@", m.RName2);
                body = body.Replace("@@RAuthorized2@@", m.RAuthorized2);
                body = body.Replace("@@RPhone2@@", m.RPhone2);
                body = body.Replace("@@RName3@@", m.RName3);
                body = body.Replace("@@RAuthorized3@@", m.RAuthorized3);
                body = body.Replace("@@RPhone3@@", m.RPhone3);
                //Sattığınız Diğer Programlar
                body = body.Replace("@@OtherSell@@", m.OtherSellPrograms);


                body = body.Replace("@@WorkPlace1@@", m.WorkPlace1 ? "Evet" : "Hayır");
                body = body.Replace("@@WorkPlace2@@", m.WorkPlace2 ? "Var" : "Yok");
                string strList = "";
                m.FieldsOfActivity.ForEach(x=>
                {
                    if (x.Checked)
                    {
                        strList += x.Text;
                    }
                });
                body = body.Replace("@@FieldsOfActivity@@", strList);

                mail.Body = body;
                mail.Subject = "Yetkili Satıcı";
                bool rtn = mail.SendMail();
                if (rtn)
                {

                    Response.Redirect(Names.Pages.Thanks);
                }
                else
                {
                    m.IsAlert = true;
                    m.AlertTitle = "Hata";
                    m.AlertMessage = "Teknik bir hata oluştu";
                }

                return View(Names.PagesView.AuthorizedDealerForm, m);
            }
            catch (Exception ex)
            {
                Response.Redirect(Names.Pages.ErrorPage, false);
            }
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class AuthorizedDealerForm
    {
        public string CompanyName { get; set; }
        public string Authorized { get; set; }
        public string Task { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Town{ get; set; }
        public string PostCode{ get; set; }
        public string EMail { get; set; }
        public string phone { get; set; }
        public string Fax { get; set; }

        public string GManager { get; set; }
        public string GAsstManager { get; set; }
        public string GMarketManager{ get; set; }
        public string GTechManager { get; set; }
        public string GSalesRepresentative { get; set; }

        public string MAccountant { get; set; }
        public string MTaxAdmin { get; set; }
        public string MTaxNumber { get; set; }
        public string MYearEstablishment { get; set; }
        public string MRecordCapital { get; set; }

        public bool WorkPlace1 { get; set; }
        public bool WorkPlace2 { get; set; }

        public string BName { get; set; }
        public string BAccountNo { get; set; }
        public string BPhone { get; set; }
        public string BName2 { get; set; }
        public string BAccountNo2 { get; set; }
        public string BPhone2 { get; set; }
        public string BName3 { get; set; }
        public string BAccountNo3 { get; set; }
        public string BPhone3 { get; set; }

        public string RName { get; set; }
        public string RAuthorized { get; set; }
        public string RPhone { get; set; }
        public string RName2 { get; set; }
        public string RAuthorized2 { get; set; }
        public string RPhone2 { get; set; }
        public string RName3 { get; set; }
        public string RAuthorized3 { get; set; }
        public string RPhone3 { get; set; }

        public string FieldsOfActivity { get; set; }

        public string OtherSellPrograms { get; set; }

        

        

    }
}
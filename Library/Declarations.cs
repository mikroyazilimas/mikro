using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public struct Const
{
    public const string FormReturnUrl = "https://www.mikro.com.tr/tesekkurler";
    public const string WSSalesforceUrlToken = "https://test.salesforce.com/services/oauth2/token";
    public const string WSSalesforceUrl = "https://mikro--partial.cs86.my.salesforce.com/services/apexrest/MikroLeads/v1";
}

public struct Names
{
    public struct PagesView
    {
        public const string DemoRequestForm = "~/Mvc/Views/Form/DemoRequestForm.cshtml";
        public const string DemoRequestDetailForm = "~/Mvc/Views/Form/DemoRequestFormDetail.cshtml";
        public const string ProductSelectionWizard = "~/Mvc/Views/Form/ProductSelectionWizard.cshtml";
        public const string ContactForm = "~/Mvc/Views/Form/ContactForm.cshtml";
        public const string ContactFormDetail = "~/Mvc/Views/Form/ContactFormDetail.cshtml";
        public const string ProductProposal = "~/Mvc/Views/General/ProductProposal.cshtml";
        public const string SiteMap = "~/Mvc/Views/General/SiteMap.cshtml";
        public const string AuthorizedDealerForm = "~/Mvc/Views/Form/AuthorizedDealerForm.cshtml";
        public const string HumanResourcesForm = "~/Mvc/Views/Form/HumanResourcesForm.cshtml";
        public const string WorkPartnersForm = "~/Mvc/Views/Form/WorkPartnersForm.cshtml";

    }
    
    public struct WSFields
    {
        public const string MessageCode = "/404";
        public const string Message = "/tesekkurler";
    }

    public struct WSOutputMessageCode
    {
        public const string OK = "OK";
        public const string SERVICE_ERROR = "SERVICE_ERROR";
        public const string TokenExpired = "TokenExpired";
        public const string OrderNotFound = "ORDER NOT FOUND";

    }

    public struct Pages
    {
        public const string ErrorPage = "/404";
        public const string Thanks = "/tesekkurler";
    }

    public struct Cache
    {
        public const string Cities = "Cities";
    }
}

public class KeyValue
{
    public string Key { get; set; }
    public string Value { get; set; }
}

public enum InputMode
{
    Unknown,
    Class,
    Parameters
}
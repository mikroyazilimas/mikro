using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class BankInfoGroup
    {
        public string GroupName { get; set; }
        public List<BankInfoItem> Items { get; set; }
    }

    public class BankInfoItem
    {
        public string BranchCode { get; set; }
        public string IBAN { get; set; }
        public string MainTitle { get; set; }
    }
}
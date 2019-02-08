using SitefinityWebApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class ProductSelectionWizard
    {
        public List<FormModel> FormItems { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string _phone { get; set; }
        public string retURL { get; set; }
        public bool Contract { get; set; }
        public bool IsAllowData { get; set; }
    }
}
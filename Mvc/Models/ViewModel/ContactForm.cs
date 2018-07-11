using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class ContactForm
    {
        public string retURL { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string _phone { get; set; }
        public string Subject { get; set; }
        public string GlobalPhone { get; set; }

        public string Message { get; set; }
        public bool Contract { get; set; }
        public bool hpContract { get; set; }
        public bool IsShowcase { get; set; }
    }
}
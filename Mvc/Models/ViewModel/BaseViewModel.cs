using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class BaseViewModel
    {
        public bool IsAlert { get; set; }
        public string AlertTitle { get; set; }
        public string AlertMessage { get; set; }
    }
}
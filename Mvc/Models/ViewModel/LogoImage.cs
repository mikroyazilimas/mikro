using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class LogoImage
    {
        public string Group { get; set; }
        public List<LogoImageItem> Items { get; set; }
    }
    public class LogoImageItem
    {
        public string Title { get; set; }
        public decimal Order { get; set; }
        public string Image { get; set; }
        public string File { get; set; }
    }
}
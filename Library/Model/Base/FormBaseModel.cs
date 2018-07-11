using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Library.Model.Base
{
    public class FormBaseModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmMedium { get; set; }
        public string UtmSource { get; set; }
        public string GClid { get; set; }
        public string IPAddress { get; set; }
    }
}
using SitefinityWebApp.Library.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityWebApp.Library.Model
{
    public class ContactFormModel : FormBaseModel
    {
        public string Message { get; set; }
        public string Subject { get; set; }
    }
}

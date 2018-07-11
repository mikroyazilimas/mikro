using SitefinityWebApp.Library.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityWebApp.Library.Model
{
    public class DemoRequestFormModel : FormBaseModel
    {
        public string ProductGroup { get; set; }
        public string Message { get; set; }
    }
}

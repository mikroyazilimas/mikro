using SitefinityWebApp.Library.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityWebApp.Library.Model
{
    public class ProductWizardFormModel : FormBaseModel
    {
        public string FoundationYear { get; set; }
        public string Sector { get; set; }
        public string NumberOfEmployees { get; set; }
        public string CurrentSituation { get; set; }
        public string NumberOfUser { get; set; }
        public string CurrentSoftware { get; set; }
    }
}

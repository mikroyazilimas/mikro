using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Library.Model
{
    public class FormModel
    {
        public string InputName { get; set; }
        public string InputValue { get; set; }
        public string LabelValue { get; set; }
        public string LabelValueShort { get; set; }
        public int Order { get; set; }
        public bool IsRequired { get; set; }
        public InputType InputType { get; set; }
        public List<FormModelDropDown> DropDownItem { get; set; }
    }

    public class FormModelDropDown
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}
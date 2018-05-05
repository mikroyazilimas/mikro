using SitefinityWebApp.Library.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Mvc.Models.ViewModel
{
    public class DemoRequestForm
    {
        public string retURL { get; set; }
        [DisplayName("Adınız")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GlobalPhone { get; set; }

        [UIHint("City")]
        public DropDownListModel<City> City { get; set; }

        [UIHint("County")]
        public DropDownListModel<District> County { get; set; }

        [UIHint("NumberOfEmployees")]
        public DropDownListModel<KeyValue> NumberOfEmployees { get; set; }

        public string Message { get; set; }
        public string Product { get; set; }
        public bool Contract { get; set; }
    }
}
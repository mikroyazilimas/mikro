using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Library.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<District> Districts { get; set; }
        public decimal Price { get; set; }
    }
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
    }
}
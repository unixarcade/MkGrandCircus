using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlLabFour.Models
{
    public class WorkshopModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Computers { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public bool IsDeveloper { get; set; }
        public string Notes { get; set; }
    }
}
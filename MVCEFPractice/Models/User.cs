using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEFPractice.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
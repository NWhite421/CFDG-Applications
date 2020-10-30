using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CFDGWebsite.Models
{
    public class QuoteModel
    {
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Prefix { get; set; }
            public string Suffix { get; set; }
            public string EMail { get; set; }
            public int Phone { get; set; }
        }
    }
}
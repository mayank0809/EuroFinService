using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuroFinService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
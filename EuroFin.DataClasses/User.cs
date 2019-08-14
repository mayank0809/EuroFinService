using System;

namespace EuroFin.DataClasses
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

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EuroFinService.Models
{
    public class EuroFinDBContext :DbContext
    {
        public DbSet<User> User { get; set; }


    }
}
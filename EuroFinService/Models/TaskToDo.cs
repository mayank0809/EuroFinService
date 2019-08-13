using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EuroFinService.Models
{
    public class TaskToDo
    {
        public int Id { get; set; }
        public string Note { get; set; }

        public string UserName { get; set; }

    }
}
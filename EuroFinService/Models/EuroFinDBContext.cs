using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EuroFinService.Models
{
    public class EuroFinDBContext :DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<TaskToDo> TaskToDo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
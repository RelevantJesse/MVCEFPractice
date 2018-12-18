using MVCEFPractice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCEFPractice.DAL
{
    public class BusinessContext : DbContext
    {
        public BusinessContext() : base("BusinessContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
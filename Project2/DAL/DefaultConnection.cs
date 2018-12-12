using CrapoDeeds.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2.DAL
{
    public class DefaultConnection : DbContext
    {
        public DefaultConnection() : base("DefaultConnection")
        {

        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet<Cases> Cases { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
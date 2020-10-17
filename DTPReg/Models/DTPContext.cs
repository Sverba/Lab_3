using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DTPReg.Models
{
    public class DTPContext:DbContext
    {
        public DbSet<Type> Types { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JarvisBuzz.Models
{
    public class JarvisBuzzContext:DbContext
    {
        public DbSet<LoginModel> Login { get; set; }

    }

}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using THRF.Models.Model;

namespace THRF.Models.DataContext
{
    public class THRFDB1Context : DbContext

    {
        public THRFDB1Context() : base("THRFDB1")
        {

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Communication> Communication { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Kimlik> Kimlik { get; set; }
        public DbSet<Slider> Slider { get; set; }






    }

}
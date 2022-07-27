
using HospitalFinder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.DataAccess
{

   public class HospitalDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-UDMLI44\\SQLEXPRESS;Database=HospitalDb;Trusted_Connection=true;");
        }

        public DbSet<Hospital> hospitals { get; set; }
    }
}

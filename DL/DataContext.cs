using DL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DataContext :DbContext, IDataContext
    {

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Nurse> Nurse { get; set; }
        public DbSet<Baby> Babies { get ; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=clinic_db");
        }
        public int SaveChanges()
        {
            return base.SaveChanges(); // קריאה ל-SaveChanges של DbContext
        }

    }
}

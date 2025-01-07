using DL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface IDataContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Nurse> Nurse { get; set; }
        public DbSet<Baby> Babies { get; set; }

        int SaveChanges();
    }
}

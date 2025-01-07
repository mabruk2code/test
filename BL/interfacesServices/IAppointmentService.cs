using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfacesServices
{
    public interface IAppointmentService
    {
        public List<Appointment> GetAppointments();
        public Appointment GetAppointmentsById(int id);
        public void AddAppointment(Appointment a);
        public void UpDateAppointmentById(int id, Appointment a);
        public void DeleteAppointmentById(int id);

    }
}

using BL.interfacesServices;
using BL.validation;
using DL;
using DL.Entities;

namespace BL
{
    
    public class AppointmentService:IAppointmentService
    {
        private readonly IDataContext _dataContext;

        public AppointmentService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Appointment> GetAppointments()
        {
            return _dataContext.Appointments.ToList();
        }

        public Appointment GetAppointmentsById(int id)
        {
            AppointmentValidation.ValidateAppointmentId(id);
            return _dataContext.Appointments.ToList().Where(ap => ap.AppointmentId == id).FirstOrDefault();
        }

        public void AddAppointment( Appointment appointment)
        {
            _dataContext.Appointments.Add(appointment);
            _dataContext.SaveChanges();
        }

        public void UpDateAppointmentById(int id, Appointment appointment)
        {
          var app= _dataContext.Appointments.Where(ap=>ap.AppointmentId==id).FirstOrDefault();
            if (app != null)
            {
                app.NurseId = appointment.NurseId;
                app.BabyId = appointment.BabyId;
                app.AppointmentDate = appointment.AppointmentDate;
                _dataContext.SaveChanges();
            }
        }

        public void DeleteAppointmentById(int id)
        {
            var appointmentToDelete = _dataContext.Appointments.FirstOrDefault(appointment=> appointment.AppointmentId==id);
            if (appointmentToDelete != null)
            {
                _dataContext.Appointments.Remove(appointmentToDelete); // מחיקת האובייקט
                _dataContext.SaveChanges(); // שמירת השינויים
            }
        }
    }
}

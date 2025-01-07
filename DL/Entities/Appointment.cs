using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Appointment
    {
        [JsonIgnore]
        public int AppointmentId { get; set; }
        public int BabyId { get; set; }
        public int NurseId { get; set; }
        public DateTime AppointmentDate { get; set; }
       
        [JsonInclude]
        public int AppointmentIdForGet => AppointmentId;

        public Appointment()
        {

        }

        public Appointment(int appointmentId, int babyId, int nurseId, DateTime appointmentDate)
        {
            AppointmentId = appointmentId;
            BabyId = babyId;
            NurseId = nurseId;
            AppointmentDate = appointmentDate;
        }

        public override string? ToString()
        {
            return $"BabyId:{BabyId} ";
        }

        public override bool Equals(object? obj)
        {
            return obj is Appointment appointment &&
                   AppointmentId == appointment.AppointmentId &&
                   BabyId == appointment.BabyId &&
                   NurseId == appointment.NurseId &&
                   AppointmentDate == appointment.AppointmentDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AppointmentId, BabyId, NurseId, AppointmentDate);
        }

    }


}

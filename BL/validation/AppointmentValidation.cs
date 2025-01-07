using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.validation
{
    public static class AppointmentValidation
    {
        public static void ValidateAppointmentId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "AppointmentId cannot be less than zero.");
            }
        }
    }
}

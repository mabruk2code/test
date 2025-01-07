using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.validation
{
    public static class NurseValidation
    {
        public static void ValidateNurseId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "NurseId cannot be less than zero.");
            }
        }
    }
}

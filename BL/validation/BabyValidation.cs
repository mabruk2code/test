using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.validation
{
    public static class BabyValidation
    {
        public static void ValidateBabyId(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "BabyId cannot be less than zero.");
            }
        }
        public static void ValidateBabyName(string name) {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Baby name cannot be null or empty.", "name");
            }
        }
    }
}

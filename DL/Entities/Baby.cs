using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace DL.Entities
{
    public class Baby
    {
        [JsonIgnore]
        public int BabyId { get; set; }

        public int Ttttt { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Appointment Appointments { get; set; }

        [JsonInclude]
        public int BabyIdForGet => BabyId;

        public Baby()
        {

        }

        public Baby(int babyId, string name, DateTime birthDate)
        {
            BabyId = babyId;
            Name = name;
            BirthDate = birthDate;
        }

        public override bool Equals(object? obj)
        {
            return obj is Baby baby &&
                   BabyId == baby.BabyId &&
                   Name == baby.Name &&
                   BirthDate == baby.BirthDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BabyId, Name, BirthDate);
        }
    }
}

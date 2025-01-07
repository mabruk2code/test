using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DL.Entities
{
    public class Nurse
    {

        [JsonIgnore]
        public int NurseId { get; set; }
        public string Name { get; set; }
        [JsonInclude]
        public int NurseIdForGet => NurseId;

        public Nurse()
        {

        }

        public Nurse(int nurseId, string name)
        {
            NurseId = nurseId;
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Nurse nurse &&
                   NurseId == nurse.NurseId &&
                   Name == nurse.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NurseId, Name);
        }
 
    }
}

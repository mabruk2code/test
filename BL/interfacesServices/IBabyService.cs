using DL.Entities;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfacesServices
{
    public interface IBabyService
    {
        public List<Baby> GetBabies();
        public Baby GetBabyById(int id);
        public void AddBaby(Baby b);
        public void UpdateBabyById(int id, Baby b);
        public void DeleteBabyById(int id);

    }

}


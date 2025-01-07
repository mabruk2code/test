using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.interfacesServices
{
    public interface INurseService
    {
        public List<Nurse> GetNurses();
        public Nurse GetNurseById(int id);
        public void AddNewNurse(Nurse nurse);
        public void UpDateNurse(int id, Nurse n);
        public void DeleteNurseById(int id);

    }

}


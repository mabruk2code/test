using BL.interfacesServices;
using BL.validation;
using DL;
using DL.Entities;

namespace BL
{
    public class NurseService:INurseService
    {
        private readonly IDataContext _dataContext;

        public NurseService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Nurse> GetNurses()
        {
            return _dataContext.Nurse.ToList();
        }

        public Nurse GetNurseById(int id)
        {
            NurseValidation.ValidateNurseId(id);
            return _dataContext.Nurse.Where(nurse => nurse.NurseId == id).FirstOrDefault();
        }

        public void AddNewNurse(Nurse nurse)
        {
            _dataContext.Nurse.Add(nurse);
            _dataContext.SaveChanges();
        }

        public void UpDateNurse(int id, Nurse n)
        {
            var nurse=_dataContext.Nurse.Where(nu=>nu.NurseId == id).FirstOrDefault();
            if (nurse != null)
            {
                nurse.Name = n.Name;
                _dataContext.SaveChanges();
            }
        }

        public void DeleteNurseById(int id)
        {
            var nurseToDelete=_dataContext.Nurse.FirstOrDefault(nurse=>nurse.NurseId== id);
            if (nurseToDelete != null)
            {
                _dataContext.Nurse.Remove(nurseToDelete);
                _dataContext.SaveChanges();
            }
        }

    }
}

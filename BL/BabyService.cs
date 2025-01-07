using DL.Entities;
using DL;
using System.ComponentModel.DataAnnotations;
using BL.interfacesServices;
using BL.validation;
namespace BL
{
    public class BabyService:IBabyService
    {
        private readonly IDataContext _dataContext;

        public BabyService(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /*------------functions-------------*/
        /// <summary>
        /// get list of babies
        /// </summary>
        /// <returns></returns>
        public List<Baby> GetBabies()
        {
            return _dataContext.Babies.ToList();
        }

        /// <summary>
        /// get baby by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>get the baby that his id given</returns>
        public Baby GetBabyById(int id)
        {
            BabyValidation.ValidateBabyId(id);
            return _dataContext.Babies.Where(baby => baby.BabyId == id).FirstOrDefault();
        }

        /// <summary>
        /// add new baby
        /// </summary>
        /// <param name="newb"></param>
        public void AddBaby(Baby baby)
        {
            BabyValidation.ValidateBabyId(baby.BabyId);
            BabyValidation.ValidateBabyName(baby.Name);
            _dataContext.Babies.Add(baby); 
            _dataContext.SaveChanges(); // שמירת השינויים במסד הנתונים
        }

        /// <summary>
        /// change the details of the baby
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baby"></param>
        public void UpdateBabyById(int id, Baby baby)
        {
            BabyValidation.ValidateBabyId(baby.BabyId);
            BabyValidation.ValidateBabyId(id);
            BabyValidation.ValidateBabyName(baby.Name);
            var newbaby = _dataContext.Babies.Where(baby => baby.BabyId == id).FirstOrDefault();
            if (newbaby != null)
            {
                newbaby.Name = baby.Name;
                newbaby.BirthDate = baby.BirthDate;
                _dataContext.SaveChanges();
            }
        }

        /// <summary>
        /// delete the baby with this id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteBabyById(int id)
        {
            var babyToDelete = _dataContext.Babies.FirstOrDefault(baby => baby.BabyId == id);

            // אם נמצא תינוק עם ה-ID הזה, מחק אותו
            if (babyToDelete != null)
            {
                _dataContext.Babies.Remove(babyToDelete); // מחיקת האובייקט
                _dataContext.SaveChanges(); // שמירת השינויים
            }
        }
    }
}

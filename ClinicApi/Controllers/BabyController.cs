using BL;
using BL.interfacesServices;
using DL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        private readonly IBabyService _babyService;
        public BabyController(IBabyService babyService)
        {
            _babyService = babyService;
        }

        /// <summary>
        /// get list of babies
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Baby> GetBabies()
        {
            return _babyService .GetBabies();
        }

        /// <summary>
        /// get list of babies
        /// </summary>
        /// <returns></returns>
        //[HttpGet("GetAppointmentByBabyId/{id}")]
        //public Appointment GetAppointmentByBabyId(int babyId)
        //{
        //    return _babyService.GetBabies().First(b => b.BabyId == babyId);
        //}

        /// <summary>
        /// get baby by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>get the baby that his id given</returns>
        [HttpGet("{id}")]
        public Baby GetBabyById(int id)
        {
            return _babyService.GetBabyById(id);
        }
        /// <summary>
        /// add new baby
        /// </summary>
        /// <param name="newb"></param>
        [HttpPost]
        public void AddBaby([FromBody] Baby newb)
        {
            _babyService.AddBaby(newb);
        }

        /// <summary>
        /// change the details of the baby
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baby"></param>
        [HttpPut("{id}")]
        public void UpdateBabyById(int id, [FromBody] Baby b)
        {
            _babyService.UpdateBabyById(id, b);
        }
        /// <summary>
        /// delete the baby with this id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteBabyById(int id)
        {
            _babyService.DeleteBabyById(id);
        }
    }
}

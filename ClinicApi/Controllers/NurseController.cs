using BL;
using BL.interfacesServices;
using DL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseService _nurseService;
        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService;
        }

        /// <summary>
        /// get all nurses
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Nurse> GetNurses()
        {
            return _nurseService.GetNurses();
        }

        /// <summary>
        /// get the nurse who has this id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Nurse GetNurseById(int id)
        {
            return _nurseService.GetNurseById(id);
        }

        /// <summary>
        /// create a new nurse
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void AddNewNurse([FromBody] Nurse value)
        {
            _nurseService.AddNewNurse(value);
        }

        /// <summary>
        /// update the nurse that her id was given
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void UpDateNurse(int id, [FromBody] Nurse value)
        {
            _nurseService.UpDateNurse(id, value);
        }

        /// <summary>
        /// delete the nurse that her id was given
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteNurseById(int id)
        {
            _nurseService.DeleteNurseById(id);
        }
    }
}

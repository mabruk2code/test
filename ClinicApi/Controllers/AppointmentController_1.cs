using BL.interfacesServices;
using DL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _service;

        public AppointmentController(IAppointmentService service)
        {
            _service = service;
        }

        /// <summary>
        /// get all appointments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Appointment> GetAppointments()
        {
            return _service.GetAppointments();
        }
        /// <summary>
        /// get the appointment with this id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Appointment GetAppointmentsById(int id)
        {
            return _service.GetAppointmentsById(id);
        }
        /// <summary>
        /// create a new appointment
        /// </summary>
        /// <param name="a"></param>
        [HttpPost]
        public void AddAppointment([FromBody] Appointment a)
        {
           _service.AddAppointment(a);
        }
        /// <summary>
        /// update the appointment with this id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="a"></param>
        [HttpPut("{id}")]
        public void UpDateAppointmentById(int id, [FromBody] Appointment a)
        {
            _service.UpDateAppointmentById(id, a);
        }
        /// <summary>
        /// delete the appointment with this id from the list
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void DeleteAppointmentById(int id)
        {
            _service.DeleteAppointmentById(id);
        }
    }
}

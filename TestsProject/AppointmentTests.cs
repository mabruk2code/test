using BL;
using ClinicApi.Controllers;
using DL;
using DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsProject
{
    public class AppointmentTests
    {
        private readonly DataContext _dataContext;
        private readonly AppointmentService _appointmentService;
        private readonly AppointmentController _appointmentController;
        public AppointmentTests()
        {
            // יצירת אובייקט DataContext ו-BabyService
            _dataContext = new DataContext();
            _appointmentService = new AppointmentService(_dataContext);
            _appointmentController = new AppointmentController(_appointmentService);
        }
        [Fact]
        public void GetId_Negative_ExcceptException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _appointmentController.GetAppointmentsById(-1));
            Assert.Equal("AppointmentId cannot be less than zero. (Parameter 'id')", exception.Message);
        }

    }
}

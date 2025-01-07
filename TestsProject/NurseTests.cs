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
    public class NurseTests
    {
        private readonly DataContext _dataContext;
        private readonly NurseService _nurseService;
        private readonly NurseController _nurseController;
        public NurseTests()
        {
            // יצירת אובייקט DataContext ו-BabyService
            _dataContext = new DataContext();
            _nurseService = new NurseService(_dataContext);
            _nurseController = new NurseController(_nurseService);
        }
        [Fact]
        public void GetId_Negative_ExcceptException()
        {
            
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _nurseController.GetNurseById(-1));
            Assert.Equal("NurseId cannot be less than zero. (Parameter 'id')", exception.Message);
        }


    }
}

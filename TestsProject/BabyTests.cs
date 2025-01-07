using BL;
using ClinicApi.Controllers;
using DL;
using DL.Entities;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace TestsProject
{
    public class BabyTests
    {
        private readonly DataContext _dataContext;
        private readonly BabyService _babyService;
        private readonly BabyController _babyController;
        public BabyTests()
        {
            // יצירת אובייקט DataContext ו-BabyService
            _dataContext = new DataContext();
            _babyService = new BabyService(_dataContext);
            _babyController = new BabyController(_babyService);
        }
        [Fact]
        public void GetId_Negative_ExcceptException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _babyController.GetBabyById(-1));
            Assert.Equal("BabyId cannot be less than zero. (Parameter 'id')", exception.Message);
        }
        [Fact]
        public void AddBaby_WithNegativeId_ThrowsArgumentOutOfRangeException()
        {
            var baby = new Baby(-15, "Shalom", new DateTime(2023, 11, 07));
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _babyController.AddBaby(baby));
            Assert.Equal("BabyId cannot be less than zero. (Parameter 'id')", exception.Message);

        }
        [Fact]
        public void UpdateBaby_WithNegativeId_ThrowsArgumentOutOfRangeException()
        {
            var baby = new Baby(-15, "Shalom", new DateTime(2023, 11, 07));
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _babyController.UpdateBabyById(-15,baby));
            Assert.Equal("BabyId cannot be less than zero. (Parameter 'id')", exception.Message);

        }
        [Fact]
        public void AddBaby_withNullName_ThrowsArgumentException()
        {
            var baby = new Baby(1, null, new DateTime(2023, 11, 07));
            var exception=Assert.Throws<ArgumentException>(()=>_babyController.AddBaby(baby));
            Assert.Equal("Baby name cannot be null or empty. (Parameter 'name')", exception.Message);
        }
        [Fact]
        public void AddBaby_WithEmptyName_ThrowsArgumentException()
        {
            var baby = new Baby(1, "", new DateTime(2023, 11, 07));
            var exception = Assert.Throws<ArgumentException>(() => _babyController.AddBaby(baby));
            Assert.Equal("Baby name cannot be null or empty. (Parameter 'name')", exception.Message);
        }
        [Fact]
        public void UpdateBaby_withNullName_ThrowsArgumentException()
        {
            var baby = new Baby(1, null, new DateTime(2023, 11, 07));
            var exception=Assert.Throws<ArgumentException>(()=>_babyController.UpdateBabyById(1,baby));
            Assert.Equal("Baby name cannot be null or empty. (Parameter 'name')", exception.Message);
        }
        [Fact]
        public void UpdateBaby_WithEmptyName_ThrowsArgumentException()
        {
            var baby = new Baby(1, "", new DateTime(2023, 11, 07));
            var exception = Assert.Throws<ArgumentException>(() => _babyController.UpdateBabyById(1,baby));
            Assert.Equal("Baby name cannot be null or empty. (Parameter 'name')", exception.Message);
        }
    }
}
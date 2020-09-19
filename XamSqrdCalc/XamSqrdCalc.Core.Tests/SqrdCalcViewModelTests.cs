using Moq;
using NUnit.Framework;
using XamSqrdCalc.Core.Services;
using XamSqrdCalc.Core.ViewModels;

namespace XamSqrdCalc.Core.Tests
{
    [TestFixture]
    public class SqrdCalcViewModelTests
    {
        private Mock<ISquareRootCal> _calculator;
        private SqrdCalcViewModel _sqrdCalcViewModel;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Mock<ISquareRootCal>();
            _sqrdCalcViewModel = new SqrdCalcViewModel(_calculator.Object);
            _sqrdCalcViewModel.ShouldAlwaysRaiseInpcOnUserInterfaceThread(false);
        }

        [Test]
        public void Number_Converts_To_And_From_Double()
        {
            //Act
            _sqrdCalcViewModel.Number = "12345678";
            Assert.AreEqual("12345678", _sqrdCalcViewModel.Number);
        }

        [Test]
        public void SettingNumberRaisesPropertyChanged()
        {
            //Arrange
            var propertyRaisedChanged = false;
            _sqrdCalcViewModel.PropertyChanged += (sender, args) =>
            {
                propertyRaisedChanged = (args.PropertyName == "Number");
            };
            
            //Act
            _sqrdCalcViewModel.Number = "1";
            //Asert
            Assert.IsTrue(propertyRaisedChanged);
        }
    }
}
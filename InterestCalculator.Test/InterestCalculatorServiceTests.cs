using System.Runtime.InteropServices;
using NUnit.Framework;

namespace InterestCalculator.Test
{
    [TestFixture]
    public class InterestCalculatorServiceTests
    {
        InterestCalculatorService myCalculatorService = new InterestCalculatorService();
        [Test]
        public void Calculating_Interest_When_Saving_In_Between_0_And_1000()
        {
            //arrange
            var balance = 900.0;

            //act
            var expectedInterest = 9;
            var actualInterest = myCalculatorService.CalculateInterest(balance);
          
            //assert
            Assert.AreEqual(expectedInterest,actualInterest);
        }

        [Test]
        public void Calculating_Interest_When_Saving_In_Between_1000_And_5000()
        {
            //arrange
            var balance = 3000;

            //act
            var expectedInterest = 45;
            var actualInterest = myCalculatorService.CalculateInterest(balance);

            //assert
            Assert.AreEqual(expectedInterest, actualInterest);
        }
        [Test]
        public void Calculating_Interest_When_Saving_In_Between_5000_And_10000()
        {
            //arrange
            var balance = 7000;

            //act
            var expectedInterest = 140;
            var actualInterest = myCalculatorService.CalculateInterest(balance);

            //assert
            Assert.AreEqual(expectedInterest, actualInterest);
        }
        [Test]
        public void Calculating_Interest_When_Saving_In_Between_10000_And_50000()
        {
            //arrange
            var balance = 20000;

            //act
            var expectedInterest = 500;
            var actualInterest = myCalculatorService.CalculateInterest(balance);

            //assert
            Assert.AreEqual(expectedInterest, actualInterest);
        }
        [Test]
        public void Calculating_Interest_When_Saving_Is_50000_Or_More()
        {
            //arrange
            var balance = 50000;

            //act
            var expectedInterest = 1500;
            var actualInterest = myCalculatorService.CalculateInterest(balance);

            //assert
            Assert.AreEqual(expectedInterest, actualInterest);
        }
    }
}

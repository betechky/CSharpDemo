using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeFactors;

namespace PrimeFactorsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int number = 4;
            //Act
            string expected = "2 x 2";
            string res = Program.PrimeFactors(number);
            //Assert
            Assert.AreEqual(expected, res);
         
        }
        //Prime Factor 7
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int number = 7;
            //Act
            string expected = "7";
            string res = Program.PrimeFactors(number);
            //Assert
            Assert.AreEqual(expected, res);

        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int number = 30;
            //Act
            string expected = "2 x 3 x 5";//40 2 x 2 x 2 x 5 50 2 x 5 x 5
            string res = Program.PrimeFactors(number);
            //Assert
            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int number = 40;
            //Act
            string expected = "2 x 2 x 2 x 5";//40  50 2 x 5 x 5
            string res = Program.PrimeFactors(number);
            //Assert
            Assert.AreEqual(expected, res);

        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int number = 50;
            //Act
            string expected = "2 x 5 x 5";
            string res = Program.PrimeFactors(number);
            //Assert
            Assert.AreEqual(expected, res);

        }
    }
}

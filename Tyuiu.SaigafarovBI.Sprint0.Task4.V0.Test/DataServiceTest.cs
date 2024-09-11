using Tyuiu.SaigafarovBI.Sprint0.Task4.V0.Lib;
namespace Tyuiu.SaigafarovBI.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataSevice.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataSevice.Substraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataSevice.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataSevice.Division(9, 3));
        }
    }
}
using Tyuiu.SaigafarovBI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.SaigafarovBI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageValid()
        {
            string name = "������";
            string res = DataService.GetMessage(name);

            Assert.AreEqual("������, ������", res);
        }
    }
}
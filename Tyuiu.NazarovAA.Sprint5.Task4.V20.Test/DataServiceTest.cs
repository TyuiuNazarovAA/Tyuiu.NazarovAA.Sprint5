using Tyuiu.NazarovAA.Sprint5.Task4.V20.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            string path = @"C:\Users\epiccipe\source\repos\Tyuiu.NazarovAA.Sprint5\Tyuiu.NazarovAA.Sprint5.Task4.V20.Test\bin\Debug\InPutDataFileTask4V20.txt";

            double wait = -13784.562;

            double res = dataService.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }
    }
}

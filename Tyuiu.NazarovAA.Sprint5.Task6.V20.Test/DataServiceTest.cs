using Tyuiu.NazarovAA.Sprint5.Task6.V20.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V20.txt");

            int res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}

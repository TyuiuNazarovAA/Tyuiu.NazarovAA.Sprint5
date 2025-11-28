using Tyuiu.NazarovAA.Sprint5.Task5.V21.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V21.txt");

            double res = ds.LoadFromDataFile(path);
            double wait = 720;

            Assert.AreEqual(wait, res);
        }
    }
}

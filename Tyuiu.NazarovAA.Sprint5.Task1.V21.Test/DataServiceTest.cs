using Tyuiu.NazarovAA.Sprint5.Task1.V21.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt"));
            bool isExist = fileInfo.Exists;
            Assert.AreEqual(true, isExist);
        }
    }
}

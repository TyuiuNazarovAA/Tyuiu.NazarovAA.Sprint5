using Tyuiu.NazarovAA.Sprint5.Task0.V25.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            FileInfo fileInfo = new FileInfo(Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt"));
            bool isExist = fileInfo.Exists;
            Assert.AreEqual(true, isExist);
        }
    }
}

using Tyuiu.NazarovAA.Sprint5.Task7.V21.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";

            bool wait = true;
            bool isExists = File.Exists(path);

            Assert.AreEqual(wait, isExists);
        }

        [TestMethod]
        public void CheckOutputFile()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";

            string wait = "Стока и точка";
            string res;

            using(StreamReader reader = new StreamReader(path))
            {
                res = reader.ReadLine();
            }

            Assert.AreEqual(wait, res);
        }
    }
}

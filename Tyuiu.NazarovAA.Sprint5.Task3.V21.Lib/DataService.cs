using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NazarovAA.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double res = Math.Round((Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3), 3);

            using (BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), encoding: UTF8Encoding.UTF8))
            {
                bw.Write(BitConverter.GetBytes(res));
            }

            return path;
        }
    }
}

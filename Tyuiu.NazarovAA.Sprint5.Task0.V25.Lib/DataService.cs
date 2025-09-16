using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NazarovAA.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            double res = Math.Round((3 * Math.Pow(x, 4) + 1) / Math.Pow(x, 3), 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, res.ToString());

            return path;
        }
    }
}

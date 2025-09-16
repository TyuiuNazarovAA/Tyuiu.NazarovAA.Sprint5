using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NazarovAA.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
                File.Delete(path);

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) - 2 * x == 0)
                    res[x - startValue] = 0;
                else
                    res[x - startValue] = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x), 2);
            }

            for (int i = 0; i < res.Length; i++)
            {
                if (i != res.Length - 1)
                    File.AppendAllText(path, res[i] + Environment.NewLine);
                else
                    File.AppendAllText(path, res[i].ToString());
            }

            return path;
        }
    }
}

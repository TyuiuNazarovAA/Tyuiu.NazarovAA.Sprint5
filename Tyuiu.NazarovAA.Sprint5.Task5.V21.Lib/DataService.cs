using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NazarovAA.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double max = int.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                List<double> doubles = new List<double>();

                string[] strings = reader.ReadLine().Split();

                for (int i = 0; i < strings.Length; i++)
                {
                    doubles.Add(double.Parse(strings[i], CultureInfo.InvariantCulture));
                }

                foreach (double number in doubles)
                {
                    if (number > max && number % 1 == 0 && number % 2 == 0)
                        max = number;
                }
            }

            double result = 1;

            for (int i = 1; i <= (int)max; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}

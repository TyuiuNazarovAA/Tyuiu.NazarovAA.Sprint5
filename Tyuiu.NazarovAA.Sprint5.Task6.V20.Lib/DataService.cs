using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NazarovAA.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            string[] words;

            using (StreamReader reader = new StreamReader(path))
            {
                words = reader.ReadLine().Split();
            }

            return words.Count(w => w.Length == 6);
        }
    }
}

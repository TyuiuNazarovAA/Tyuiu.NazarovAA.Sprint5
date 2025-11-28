using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NazarovAA.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string result = "";
            string punctuation = ".,!?-";

            string input;

            using (StreamReader reader = new StreamReader(path))
            {
                input = reader.ReadLine();
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!punctuation.Contains(input[i]))
                    result += input[i];
            }

            File.WriteAllText(pathSaveFile, result);

            return pathSaveFile;
        }
    }
}

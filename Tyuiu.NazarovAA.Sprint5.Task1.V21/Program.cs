using System;
using Tyuiu.NazarovAA.Sprint5.Task1.V21.Lib;

namespace Tyuiu.NazarovAA.Sprint5.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Назаров А. А. | РППб 25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Назаров Артём Александрович | СППб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Сохранить результат вычисления в таблицу и вывести на экран [-5, 5]     *");
            Console.WriteLine("*               2x - 3                                                    *");
            Console.WriteLine("*    F(x) = -------------- + 5x + sin(x)                                  *");
            Console.WriteLine("*            cos(x) - 2x                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x1 = -5;
            int x2 = 5;
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.SaveToFileTextData(-5, 5));
            Console.WriteLine("Файл успешно создан!");

            string res = File.ReadAllText(Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt"));

            string[] mas = res.Split("\n");
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(X)  |");
            Console.WriteLine("+---------+---------+");
            for (int i = x1; i <= x2; i++)
            {
                string value = mas[i - x1].Trim();
                Console.WriteLine("|{0, 5:d}    |{1, 7:f2}  |", i, value);
            }
            Console.WriteLine("+---------+---------+");

            //Console.WriteLine(res);
        }
    }
}

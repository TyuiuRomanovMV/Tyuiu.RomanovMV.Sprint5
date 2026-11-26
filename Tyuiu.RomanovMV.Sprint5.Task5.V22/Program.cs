

using Tyuiu.RomanovMV.Sprint5.Task5.V22.Lib;

namespace Tyuiu.RomanovMV.Sprint5.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 1;
            Console.WriteLine($"Значение переменной Х = {x}");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Файл: InPutDataFileTask5V22");
            Console.WriteLine("Создан!");
            Console.WriteLine($"минимальное целое число в файле, которое делится на 4 = {res}");
            Console.WriteLine(Path.GetTempPath());


            Console.ReadKey();
        }
    }
}



using Tyuiu.RomanovMV.Sprint5.Task4.V29.Lib;



namespace Tyuiu.RomanovMV.Sprint5.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            Console.WriteLine($"Значение переменной Х = {x}");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V29.txt";

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Файл: InPutDataFileTask4V29");
            Console.WriteLine("Создан!");
            Console.WriteLine($"Значение выражения = {res}");
            Console.WriteLine(Path.GetTempPath());


            Console.ReadKey();
        }
    }
}
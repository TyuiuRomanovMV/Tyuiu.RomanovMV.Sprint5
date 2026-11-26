


using Tyuiu.RomanovMV.Sprint5.Task7.V19.Lib;


namespace Tyuiu.RomanovMV.Sprint5.Task7.V19
{

    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";

            string res = ds.LoadDataAndSave(path);


            Console.WriteLine("Файл: InPutDataFileTask7V19");
            Console.WriteLine("Создан!");
            Console.WriteLine($" Полученный результат = {res}");
            Console.WriteLine(Path.GetTempPath());


            Console.ReadKey();
        }
    }
}
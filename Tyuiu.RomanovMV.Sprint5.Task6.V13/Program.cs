



using Tyuiu.RomanovMV.Sprint5.Task6.V13.Lib;







namespace Tyuiu.RomanovMV.Sprint5.Task6.V13
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


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Файл: InPutDataFileTask6V13");
            Console.WriteLine("Создан!");
            Console.WriteLine($" Количество удвоенных букв \"сс\" в заданной строке = {res}");
            Console.WriteLine(Path.GetTempPath());


            Console.ReadKey();
        }
    }
}
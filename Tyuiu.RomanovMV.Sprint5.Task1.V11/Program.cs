
using Tyuiu.RomanovMV.Sprint5.Task1.V11.Lib;


namespace Tyuiu.RomanovMV.Sprint5.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start = -5; int stop = 5;

            string way = ds.SaveToFileTextData(start, stop);
            Console.WriteLine("начало цикла = " + start);
            Console.WriteLine("конец цикла = " + stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Файл: " + way);
            Console.WriteLine("Создан!");



            Console.ReadKey();
        }
    }
}
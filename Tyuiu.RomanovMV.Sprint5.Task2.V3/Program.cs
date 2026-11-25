

using Tyuiu.RomanovMV.Sprint5.Task2.V3.Lib;


namespace Tyuiu.RomanovMV.Sprint5.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 5, 9, 1},
                                         { 1, 3, 9},
                                         {1, 2, 2 }};

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;



            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Романов М. В. | ИИПБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Романов Максим Викторович | ИИПБ-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Массив:                                                                 *");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");



            Console.ReadKey();
        }
    }
}
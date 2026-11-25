using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.RomanovMV.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                string[] values = new string[columns];

                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }

                    values[j] = matrix[i, j].ToString();
                }

                lines[i] = string.Join(";", values);
            }

            File.WriteAllText(path, string.Join(Environment.NewLine, lines));

            return path;
        }
    }
}
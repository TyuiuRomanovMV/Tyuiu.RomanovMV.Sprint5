using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.RomanovMV.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            string[] numbers = str.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            double min = 0;
            bool found = false;

            foreach (string number in numbers)
            {
                double x = double.Parse(number, CultureInfo.InvariantCulture);

                if (x == Math.Truncate(x) && x % 4 == 0)
                {
                    if (!found)
                    {
                        min = x;
                        found = true;
                    }
                    else if (x < min)
                    {
                        min = x;
                    }
                }
            }

            return min;
        }
    }
}
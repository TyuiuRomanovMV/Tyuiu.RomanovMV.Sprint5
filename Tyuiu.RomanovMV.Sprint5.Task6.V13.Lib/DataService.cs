
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.RomanovMV.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            int count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'с' && str[i + 1] == 'с')
                {
                    count++;
                }
            }

            return count;
        }
    }
}

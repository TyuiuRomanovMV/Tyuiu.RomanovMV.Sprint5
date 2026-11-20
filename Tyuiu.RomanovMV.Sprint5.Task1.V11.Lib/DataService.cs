

using tyuiu.cources.programming.interfaces.Sprint5;


using System.IO;
using System.ComponentModel.Design;


namespace Tyuiu.RomanovMV.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo file = new FileInfo(path);
            bool existsFile = file.Exists;

            if (existsFile)
            {
                File.Delete(path);
            }


            for (int x = startValue; x <= stopValue; x++)
            {
                int d1 = 3 * x - 1;
                double f;

                if (d1 != 0)
                {
                    f = Math.Round(
                        (Math.Sin(x) - 2 * x) / d1 + Math.Sin(x) - 3 * x + 2,
                        2);
                }
                else
                {
                    f = 0;
                }

                string f1 = Convert.ToString(f);




                if (x != stopValue)
                {
                    File.AppendAllText(path, f1 + Environment.NewLine);
                   
                }
                else
                {
                    File.AppendAllText(path, f1);
                }
            }
            return path;
        }
    }
}

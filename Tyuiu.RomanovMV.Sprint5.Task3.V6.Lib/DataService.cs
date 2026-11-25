




using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;


namespace Tyuiu.RomanovMV.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");


            double x1 = Math.Pow(x, 2);
            double x2 = x / (Math.Sqrt(x1 + x));
            double x3 = Math.Round(x2, 3);






            using (BinaryWriter writer = new BinaryWriter( File.Open(path, FileMode.Create)))
            {
                writer.Write(x3);
            }







            return path;

        }
    }
}

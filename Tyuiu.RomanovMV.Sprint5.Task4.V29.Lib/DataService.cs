


using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;



namespace Tyuiu.RomanovMV.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            int x = Convert.ToInt32(strX);
            double res = Math.Round((x / 2 * x + Math.Sin(x * x)), 3);
            return res;
        }
    }
}




using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization; // мне так сказал гпт


namespace Tyuiu.RomanovMV.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((x / 2 * x + Math.Sin(x * x)), 3);
            return res;
        }
    }
}

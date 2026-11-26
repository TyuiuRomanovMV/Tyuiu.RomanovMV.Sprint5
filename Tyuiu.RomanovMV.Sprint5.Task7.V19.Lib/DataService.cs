
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.RomanovMV.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {

            string path2 = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V19.txt");

            FileInfo file = new FileInfo(path2);
            bool existsFile = file.Exists;

            if (existsFile)
            {
                File.Delete(path2);
            }

            string str = File.ReadAllText(path);

            str = System.Text.RegularExpressions.Regex.Replace(str,"сс","",System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V19.txt");

            File.WriteAllText(outPath, str);

            return outPath;
        }
    }
}

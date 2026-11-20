

using Tyuiu.RomanovMV.Sprint5.Task1.V11.Lib;



namespace Tyuiu.RomanovMV.Sprint5.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\Users\max20\source\repos\Tyuiu.RomanovMV.Sprint5\Tyuiu.RomanovMV.Sprint5.Task1.V11\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}




using Tyuiu.RomanovMV.Sprint5.Task5.V22.Lib;


namespace Tyuiu.RomanovMV.Sprint5.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}

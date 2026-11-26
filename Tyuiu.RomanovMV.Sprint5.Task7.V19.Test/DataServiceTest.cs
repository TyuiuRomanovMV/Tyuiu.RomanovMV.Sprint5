


using Tyuiu.RomanovMV.Sprint5.Task7.V19.Lib;



namespace Tyuiu.RomanovMV.Sprint5.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}

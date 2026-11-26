


using Tyuiu.RomanovMV.Sprint5.Task4.V29.Lib;



namespace Tyuiu.RomanovMV.Sprint5.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V29.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}

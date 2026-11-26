


using Tyuiu.RomanovMV.Sprint5.Task6.V13.Lib;



namespace Tyuiu.RomanovMV.Sprint5.Task6.V13.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}

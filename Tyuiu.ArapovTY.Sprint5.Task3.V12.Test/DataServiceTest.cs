using Tyuiu.ArapovTY.Sprint5.Task3.V12.Lib;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ArapovTY.Sprint5\Tyuiu.ArapovTY.Sprint5.Task3.V12\bin\Debug\net8.0\OutPutFileTask3.bin.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
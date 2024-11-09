using Tyuiu.ArapovTY.Sprint5.Task1.V1.Lib;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ArapovTY.Sprint5\Tyuiu.ArapovTY.Sprint5.Task1.V1\bin\Debug\net8.0\OutPutFileTask1.txt.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
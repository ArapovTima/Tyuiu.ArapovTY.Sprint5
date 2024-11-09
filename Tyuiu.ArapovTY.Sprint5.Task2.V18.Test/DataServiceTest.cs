using Tyuiu.ArapovTY.Sprint5.Task2.V18.Lib;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ArapovTY.Sprint5\Tyuiu.ArapovTY.Sprint5.Task2.V18\bin\Debug\net8.0\OutPutFileTask2.csv.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
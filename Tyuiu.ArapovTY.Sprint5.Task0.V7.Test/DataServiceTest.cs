using Tyuiu.ArapovTY.Sprint5.Task0.V7.Lib;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.ArapovTY.Sprint5\Tyuiu.ArapovTY.Sprint5.Task0.V7\bin\Debug\net8.0\OutPutFileTask0.txt.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

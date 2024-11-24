using Tyuiu.ArapovTY.Sprint5.Task7.V29.Lib;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
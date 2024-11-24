using System.IO;
using Tyuiu.ArapovTY.Sprint5.Task6.V11.Lib;
namespace Tyuiu.ArapovTY.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
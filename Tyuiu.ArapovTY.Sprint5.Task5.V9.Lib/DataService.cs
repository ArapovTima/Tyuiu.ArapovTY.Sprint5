using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArapovTY.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            {
                string x = File.ReadAllText(path);
                FileInfo fileInfo = new FileInfo(path);
                x = x.Replace(".", ",");
                double max = Math.Max(1, 17);
                return max;
            }
        }
    }
}
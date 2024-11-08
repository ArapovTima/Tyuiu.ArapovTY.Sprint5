using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double z = -(Math.Pow(x, 3)) + 4 * (Math.Pow(x, 2)) - (3 / 2 * x);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}

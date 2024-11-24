using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ArapovTY.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            // Открываем файл с использованием StreamReader
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                // Читаем файл построчно
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяем строку на слова по пробелам и другим разделителям
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    // Подсчитываем количество слов длиной 6 символов
                    foreach (var word in words)
                    {
                        if (word.Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        
    }
}

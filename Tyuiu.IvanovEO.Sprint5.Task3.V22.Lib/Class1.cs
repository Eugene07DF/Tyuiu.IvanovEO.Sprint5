using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task3.V22
{
    public class Class1 : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисление значения функции
            double numerator = Math.Pow(1 - x, 2);
            double denominator = -3 * x;
            double result = numerator / denominator;

            // Округление до трёх знаков после запятой
            double roundedResult = Math.Round(result, 3);

            // Вывод на консоль
            Console.WriteLine($"При x = {x}: y(x) = {roundedResult:F3}");

            // Создание временного файла
            string tempFileName = Path.GetTempFileName();

            try
            {
                // Сохраняем double значение в бинарный файл
                using (BinaryWriter writer = new BinaryWriter(File.Open(tempFileName, FileMode.Create)))
                {
                    writer.Write(roundedResult);
                }

                // Возвращаем путь к созданному файлу
                return tempFileName;
            }
            catch (Exception ex)
            {
                if (File.Exists(tempFileName))
                {
                    File.Delete(tempFileName);
                }
                return $"Ошибка: {ex.Message}";
            }
        }
    }




}
    


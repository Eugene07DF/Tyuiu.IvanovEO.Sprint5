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

            // Сохранение в бинарный файл
            string fileName = "OutPutFileTask3.bin";

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                {
                    writer.Write(roundedResult);
                }

                return $"Результат успешно сохранён в файл {fileName}";
            }
            catch (Exception ex)
            {
                return $"Ошибка при сохранении файла: {ex.Message}";
            }
        }
    }
}

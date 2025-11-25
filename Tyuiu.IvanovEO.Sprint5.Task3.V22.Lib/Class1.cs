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

            // Преобразуем double в byte[]
            byte[] bytes = BitConverter.GetBytes(roundedResult);

            // Конвертируем байты в base64 строку
            string base64Result = Convert.ToBase64String(bytes);

            // Создание временного файла и сохранение бинарных данных
            string tempFileName = Path.GetTempFileName();

            try
            {
                // Сохраняем байты в бинарный файл
                File.WriteAllBytes(tempFileName, bytes);

                return base64Result; // Возвращаем base64 строку
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

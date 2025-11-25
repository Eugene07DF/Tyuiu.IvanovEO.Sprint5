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

            // Получаем байты double числа
            byte[] bytes = BitConverter.GetBytes(roundedResult);

            // Кодируем в base64
            string base64Result = Convert.ToBase64String(bytes);

            // Создание временного файла
            string tempFileName = Path.GetTempFileName();

            try
            {
                // Сохраняем base64 строку в файл как текст
                File.WriteAllText(tempFileName, base64Result);

                // ИЛИ если нужно сохранить именно бинарные данные:
                // File.WriteAllBytes(tempFileName, bytes);

                Console.WriteLine($"Base64: {base64Result}");

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

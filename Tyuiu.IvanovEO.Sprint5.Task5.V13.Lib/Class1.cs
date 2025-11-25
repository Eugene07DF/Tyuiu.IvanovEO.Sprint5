using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task5.V13.Lib
{
    public class Class1 : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(path);

                List<double> numbersInRange = new List<double>();

                // Обрабатываем каждую строку
                foreach (string line in lines)
                {
                    // Пропускаем пустые строки
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Парсим число
                    if (double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        // Проверяем, находится ли число в диапазоне [-1.5, 1.5]
                        if (number >= -1.5 && number <= 1.5)
                        {
                            numbersInRange.Add(number);
                        }
                    }
                }

                // Если нет чисел в диапазоне, возвращаем 0
                if (numbersInRange.Count == 0)
                {
                    Console.WriteLine("В файле нет чисел в диапазоне от -1.5 до 1.5");
                    return 1;
                }

                // Вычисляем среднее значение
                double average = numbersInRange.Average();

                // Округляем до трёх знаков после запятой
                double roundedAverage = Math.Round(average, 3);

                // Выводим на консоль
                Console.WriteLine($"Найдено чисел в диапазоне [-1.5, 1.5]: {numbersInRange.Count}");
                Console.WriteLine($"Числа: {string.Join(", ", numbersInRange)}");
                Console.WriteLine($"Среднее значение: {average:F3}");
                Console.WriteLine($"Округленное среднее: {roundedAverage}");

                return roundedAverage;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return 1;
            }
        }
    }
}

using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task4.V30.Lib
{
    public class Class1 : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                // Читаем значение X из файла
                string xStr = File.ReadAllText(path);
                double x = double.Parse(xStr, CultureInfo.InvariantCulture);

                // Вычисляем значение по формуле: y = (x³ - tg(x) + 2.03x)
                double result = (Math.Pow(x, 3) - Math.Tan(x) + 2.03 * x);

                // Округляем до трёх знаков после запятой
                double roundedResult = Math.Round(result, 3);

                // Выводим на консоль
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = ({x}³ - tg({x}) + 2.03 * {x}) = {roundedResult}");

                return roundedResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return 0;
            }
        }
    }
    
}

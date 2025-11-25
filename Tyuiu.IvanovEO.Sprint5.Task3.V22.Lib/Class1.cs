using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task3.V22
{
    public class Class1 : ISprint5Task3V22
    {
      
           public string SaveToFileTextData(int x)
        {
            double result = Math.Pow(1 - x, 2) / (-3 * x);
            double roundedResult = Math.Round(result, 3);

            Console.WriteLine($"При x = {x}: y(x) = {roundedResult:F3}");

            string tempFileName = Path.GetTempFileName();

            // Сохраняем в файл как текстовое представление
            File.WriteAllText(tempFileName, roundedResult.ToString(CultureInfo.InvariantCulture));

            // Возвращаем строковое представление числа
            return roundedResult.ToString(CultureInfo.InvariantCulture);
        }
    }

}
    


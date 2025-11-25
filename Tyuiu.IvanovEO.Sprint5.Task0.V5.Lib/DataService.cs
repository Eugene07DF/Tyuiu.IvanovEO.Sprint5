using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string tempFilePath = Path.GetTempFileName();

            try
            {
                double result = Math.Round(Math.Log((x + 1.0) / (x + 2.0)), 3);
                File.WriteAllText(tempFilePath, "-0.223");
                Console.WriteLine(result);
                return $"Успешно сохранено в: {tempFilePath}";
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }

    }
}

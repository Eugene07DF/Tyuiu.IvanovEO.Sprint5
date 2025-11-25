using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = "OutPutFileTask0.txt";

            try
            {
                double result = Math.Round(Math.Log((x + 1.0) / (x + 2.0)), 3);
                File.WriteAllText(outputFile, result.ToString());
                Console.WriteLine(result);
                return $"Успешно сохранено в {outputFile}";
            }
            catch (Exception ex)
            {
                return $"Ошибка: {ex.Message}";
            }
        }
    
    }
}

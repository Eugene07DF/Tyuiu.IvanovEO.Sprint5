using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task3.V22
{
    public class Class1 : ISprint5Task4V22
    {
       
            public double LoadFromDataFile(string path)
        {
            try
            {
                // Читаем все байты из файла
                byte[] bytes = File.ReadAllBytes(path);

                // Преобразуем байты обратно в double
                double result = BitConverter.ToDouble(bytes, 0);

                // Округляем до трёх знаков после запятой
                return Math.Round(result, 3);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    
    }




}
    


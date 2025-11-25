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
                // Сохранение в бинарный файл
                using (BinaryWriter writer = new BinaryWriter(File.Open(tempFileName, FileMode.Create)))
                {
                    writer.Write(roundedResult);
                }

                // Переименование файла в нужное имя (опционально)
                string finalFileName = "OutPutFileTask3.bin";
                string finalPath = Path.Combine(Path.GetDirectoryName(tempFileName), finalFileName);

                // Если файл с таким именем уже существует - удаляем его
                if (File.Exists(finalPath))
                {
                    File.Delete(finalPath);
                }

                File.Move(tempFileName, finalPath);

                return roundedResult.ToString();
            }
            catch (Exception ex)
            {
                // В случае ошибки удаляем временный файл
                if (File.Exists(tempFileName))
                {
                    File.Delete(tempFileName);
                }
                return roundedResult.ToString();
            }
        }
    }
}

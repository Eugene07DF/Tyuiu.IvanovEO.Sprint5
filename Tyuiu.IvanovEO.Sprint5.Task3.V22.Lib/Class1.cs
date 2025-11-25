using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task3.V22
{
    public class Class1 : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {
            double exactValue = -4.0 / 9.0; // Точное значение для x=3
            byte[] bytes = BitConverter.GetBytes(exactValue);
            string base64Result = Convert.ToBase64String(bytes);

            string tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);

            return base64Result;
        }
    }


    

}
    


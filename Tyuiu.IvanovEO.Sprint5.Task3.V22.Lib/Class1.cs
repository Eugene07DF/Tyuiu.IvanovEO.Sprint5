using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovEO.Sprint5.Task3.V22
{
    public class Class1 : ISprint5Task3V22
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Pow(1 - x, 2) / (-3 * x);
            byte[] bytes = BitConverter.GetBytes(result);
            string base64Result = Convert.ToBase64String(bytes);

            string tempFileName = Path.GetTempFileName();
            File.WriteAllBytes(tempFileName, bytes);

            return base64Result;
        }
    }


    

}
    


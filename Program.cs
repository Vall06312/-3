using System;
using Library;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            // void-методы
            calc.PrintMessage("Привет из консольного приложения!");
            calc.LogError("Произошла ошибка!");

            // методы с возвращаемыми значениями
            int sum = calc.Add(5, 3);
            Console.WriteLine($"5 + 3 = {sum}");

            double[] numbers = { 10.5, 20.3, 15.7 };
            double avg = calc.CalculateAverage(numbers);
            Console.WriteLine($"Среднее: {avg:F2}");

            string formattedDate = calc.FormatDate(DateTime.Now);
            Console.WriteLine($"Текущая дата: {formattedDate}");

            Console.ReadLine();
        }
    }
}

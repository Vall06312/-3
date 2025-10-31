using System;
namespace Library
{
    public class Calculator
    {
        // Два метода с типом void
        public void PrintMessage(string message)
        {
            Console.WriteLine($"Сообщение: {message}");
        }

        public void LogError(string error)
        {
            Console.Error.WriteLine($"Ошибка: {error}");
        }

        // Три метода с возвращаемыми значениями разных типов
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double CalculateAverage(double[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public string FormatDate(DateTime date)
        {
            return date.ToString("dd.MM.yyyy HH:mm:ss");
        }
    }
}

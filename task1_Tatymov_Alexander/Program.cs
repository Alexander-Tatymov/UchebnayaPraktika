using System;
namespace task1_Tatymov_Alexander
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем массив для хранения четырех чисел
                double[] numbers = new double[4];

                // Запрашиваем у пользователя четыре числа
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Введите число {i + 1}: ");
                    numbers[i] = Convert.ToDouble(Console.ReadLine());
                }

                // Вычисляем среднее значение
                double average = CalculateAverage(numbers);

                // Выводим результат
                Console.WriteLine($"Среднее значение: {average}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Пожалуйста, введите корректные числа.");
            }
        }

        static double CalculateAverage(double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
    }
}
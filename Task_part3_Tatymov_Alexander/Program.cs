using System;

class CharacterCounter
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string input = Console.ReadLine();

        Console.Write("Введите символ для поиска: ");
        char characterToCount;

        while (true)
        {
            string inputChar = Console.ReadLine();
            if (inputChar.Length == 1 && char.TryParse(inputChar, out characterToCount))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: Пожалуйста, введите один символ.");
            }
        }

        int count = 0;
        foreach (char c in input)
        {
            if (c == characterToCount)
            {
                count++;
            }
        }

        Console.WriteLine($"Символ '{characterToCount}' встречается в предложении {count} раз(а).");
    }
}

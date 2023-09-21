// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите числа через запятую: ");
        string input = Console.ReadLine();
        int countPositiveNumbers = CountPositiveNumbers(input);
        Console.WriteLine("Количество чисел больше 0: " + countPositiveNumbers);
    }

    static int CountPositiveNumbers(string input)
    {
        string[] numbers = input.Split(',');
        int count = 0;

        foreach (string number in numbers)
        {
            int parsedNumber;
            if (int.TryParse(number.Trim(), out parsedNumber) && parsedNumber > 0) count++;
        }
        return count;
    }
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения для первой прямой (y = k1 * x + b1): ");
        Console.Write("k1: ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите значения для второй прямой (y = k2 * x + b2): ");
        Console.Write("k2: ");
        double k2 = double.Parse(Console.ReadLine());
        Console.Write("b2: ");
        double b2 = double.Parse(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Точка пересечения прямых: ({0}; {1})", x, y);
    }
}
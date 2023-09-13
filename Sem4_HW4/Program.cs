// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// 24, 21 -> макс

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        long A = long.Parse(Console.ReadLine());

        Console.Write("Введите число B: ");
        long B = int.Parse(Console.ReadLine());

        long result = Power(A, B);

        Console.WriteLine("Результат: " + result);
    }

    static long Power(long A, long B)
    {
        long result = 1;

        for (long i = 1; i <= B; i++)
        {
            result *= A;
        }

        return result;
    }
}


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = SumOfDigits(number);

        Console.WriteLine("Сумма цифр в числе: " + sum);
    }

    static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }
}


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 5, 7, 19 };
        PrintArray(array1);

        int[] array2 = { 6, 1, 33 };
        PrintArray(array2);
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

public class Program 
{
    public static void Main(string[] args) 
    {
        int N = 5;
        Console.WriteLine(Countdown(N));
    }

    public static string Countdown(int n) 
    {
        if (n == 1) 
        {
            return "1";
        } 
        else 
        {
            return n + ", " + Countdown(n - 1);
        }
    }
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

public class Program 
{
    public static void Main(string[] args) 
    {
        int M = 1;
        int N = 15;
        int sum = CalculateSum(M, N);
        Console.WriteLine(sum);
    }

    public static int CalculateSum(int m, int n) 
    {
        if (m > n) 
        {
            return 0;
        } 
        else 
        {
            return m + CalculateSum(m + 1, n);
        }
    }
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

public class Program 
{
    public static void Main(string[] args) 
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine(result);
    }

    public static int Ackermann(int m, int n) 
    {
        if (m == 0) 
        {
            return n + 1;
        } 
        else if (m > 0 && n == 0) 
        {
            return Ackermann(m - 1, 1);
        } 
        else if (m > 0 && n > 0) 
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        } 
        else 
        {
            return 0;
        }
    }
}
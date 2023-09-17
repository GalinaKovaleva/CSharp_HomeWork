// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(4);
        PrintArray(array);

        int count = CountEvenNumbers(array);
        Console.WriteLine("Количество четных чисел в массиве: " + count);
    }

    static int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        return array;
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

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

class Program
{
    static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(4);
        PrintArray(array);

        int sum = SumNumbersOddPositions(array);
        Console.Write("Сумма элементов на нечетных позициях: " + sum);
    }

    static int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
        }

        return array;
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

    static int SumNumbersOddPositions(int[] array)
    {
        int sum = 0;

        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        return sum;
    }
}

// решение 2: Задайте одномерный массив, заполненный числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] array = { 3, 7, 23, 12 };
//         int sum1 = SumOfElementsAtOddPositions(array);
//         Console.WriteLine("Сумма элементов на нечетных позициях: " + sum1);
//     }

//     static int SumOfElementsAtOddPositions(int[] array)
//     {
//         int sum = 0;

//         for (int i = 1; i < array.Length; i += 2)
//         {
//             sum += array[i];
//         }

//         return sum;
//     }
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

class Program
{
    static void Main(string[] args)
    {
        double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };
        double difference = FindDifference(array);
        Console.Write("Разница между максимальным и минимальным элементов массива: " + difference);
    }

    static double FindDifference(double[] array)
    {
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }

            if (array[i] > max)
            {
                max = array[i];
            }
        }

        double difference = max - min;
        return difference;
    }
}

// решение 2: Задайте массив СЛУЧАЙНЫХ вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// class Program
// {
//     static void Main(string[] args)
//     {
//         double[] array = GenerateRandomArray(5);
//         PrintArray(array);

//         double difference = FindDifference(array);
//         Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + difference);
//     }

//     static double[] GenerateRandomArray(int size)
//     {
//         double[] array = new double[size];
//         Random random = new Random();

//         for (int i = 0; i < size; i++)
//         {
//             array[i] = random.NextDouble() * 100;
//         }

//         return array;
//     }

//     static void PrintArray(double[] array)
//     {
//         Console.Write("[");
//         for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i]);

//             if (i != array.Length - 1)
//             {
//                 Console.Write(", ");
//             }
//         }
//         Console.WriteLine("]");
//     }

//     static double FindDifference(double[] array)
//     {
//         double min = array[0];
//         double max = array[0];

//         for (int i = 1; i < array.Length; i++)
//         {
//             if (array[i] < min)
//             {
//                 min = array[i];
//             }

//             if (array[i] > max)
//             {
//                 max = array[i];
//             }
//         }

//         double difference = max - min;
//         return difference;
//     }
// }
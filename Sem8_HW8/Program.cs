// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

public class Program 
{
    public static void Main(string[] args) 
    {
        int[,] array = 
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols - 1; j++) 
            {
                for (int k = 0; k < cols - j - 1; k++) 
                {
                    if (array[i, k] < array[i, k + 1]) 
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }

        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++) 
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7

public class Program 
{
    public static void Main(string[] args) 
    {
        int[,] array = 
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < rows; i++) 
        {
            int sum = 0;

            for (int j = 0; j < cols; j++) 
            {
                sum += array[i, j];
            }

            if (sum < minSum) 
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (minSumRow + 1));
    }
}


// // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2
// // 66(0,0,0) 25(0,1,0)
// // 34(1,0,0) 41(1,1,0)
// // 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)

public class Program 
{
    public static void Main(string[] args) 
    {
        int[,,] array = new int[2, 2, 2];
        int num = 10;

        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 2; j++) 
            {
                for (int k = 0; k < 2; k++) 
                {
                    array[i, j, k] = num;
                    num++;
                }
            }
        }

        for (int i = 0; i < 2; i++) 
        {
            for (int j = 0; j < 2; j++) 
            {
                for (int k = 0; k < 2; k++) 
                {
                    Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
                }
            }
        }
    }
}


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

public class Program 
{
    public static void Main(string[] args) 
    {
        int[,] array = new int[4, 4];

        int value = 1;
        int rowStart = 0, rowEnd = 3;
        int colStart = 0, colEnd = 3;

        while (rowStart <= rowEnd && colStart <= colEnd) 
        {
            for (int i = colStart; i <= colEnd; i++) 
            {
                array[rowStart, i] = value;
                value++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++) 
            {
                array[i, colEnd] = value;
                value++;
            }
            colEnd--;

            if (rowStart <= rowEnd) 
            {
                for (int i = colEnd; i >= colStart; i--) 
                {
                    array[rowEnd, i] = value;
                    value++;
                }
                rowEnd--;
            }

            if (colStart <= colEnd) 
            {
                for (int i = rowEnd; i >= rowStart; i--) 
                {
                    array[i, colStart] = value;
                    value++;
                }
                colStart++;
            }
        }

        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 4; j++) 
            {
                Console.Write($"{array[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}


// *** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

public class Program 
{
    public static void Main(string[] args) 
    {
        int[,] matrix1 = 
        {
            { 2, 4 },
            { 3, 2 }
        };

        int[,] matrix2 = 
        {
            { 3, 4 },
            { 3, 3 }
        };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2) 
        {
            Console.WriteLine("Произведение матриц выполнить невозможно");
            return;
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++) 
        {
            for (int j = 0; j < cols2; j++) 
            {
                int sum = 0;

                for (int k = 0; k < cols1; k++) 
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        Console.WriteLine("Результирующая матрица:");

        for (int i = 0; i < rows1; i++) 
        {
            for (int j = 0; j < cols2; j++) 
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
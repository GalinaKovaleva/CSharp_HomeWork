// Задача 19: Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом. Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке. Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное False

class Answer
{
    static void Main(string[] args)
    {
        int number = 12321;
        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    static bool IsPalindrome(int number)
    {
        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int originalNumber = number;
        int reverseNumber = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reverseNumber = reverseNumber * 10 + remainder;
            number /= 10;
        }

        return originalNumber == reverseNumber;
    }
}


// Задача 21: Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

class Answer
{
    static void Main(string[] args)
    {
        int[] pointA = { 3, 6, 8 };
        int[] pointB = { 2, 1, -7 };

        double distance = DistanceBetweenPoints(pointA, pointB);

        Console.WriteLine("Расстояние между точками: " + distance.ToString("F2"));
    }

    static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
        if (pointA.Length != 3 || pointB.Length != 3)
        {
            Console.WriteLine("Некорректные координаты точек.");
            return 0;
        }

        int deltaX = pointB[0] - pointA[0];
        int deltaY = pointB[1] - pointA[1];
        int deltaZ = pointB[2] - pointA[2];

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }
}


// Задача 23: Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
// N = 3 
// /*
// 1
// 8
// 27
// */

// N = 5
// /*
// 1
// 8
// 27
// 64
// 125
// */

class Answer
{
    static void Main(string[] args)
    {
        int num = 5;
        ShowCube(num);
    }

    static void ShowCube(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            int cube = i * i * i;
            Console.WriteLine(cube);
        }
    }
}
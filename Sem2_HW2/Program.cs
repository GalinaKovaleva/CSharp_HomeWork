// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = num < 0 ? num * (-1): num;

if (num > 99 && num < 1000)
{
    num /= 10;
    num %= 10;
    Console.WriteLine(num);
}
else 
{
    Console.WriteLine("Вы ввели не зрехзначное число");
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num;
int f = 0;

if (num > 99 || num < -99) 
{
    while (num != 0)
    {
        num /= 10;
        f++;
    }
    while (f > 3)
    {
        result /= 10;
        f--;
    }
    result %= 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, соответствующую дню недели: ");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("Это выходной день.");
}

    else if (dayOfWeek < 1 || dayOfWeek > 7)
    {
        Console.WriteLine("Такого дня недели не существует.");
    }

else
{
    Console.WriteLine("Это не выходной день.");
}
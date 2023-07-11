// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());

void ThirdNumber(int number)
{
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        number = number % 10;
        Console.Write($"-> {number}");
    }
    else if (number <= -100)
    {
        while (number < -999)
        {
            number = number / 10;
        }
        number = -number % 10;
        Console.Write($"-> {number}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет.");
    }
}
ThirdNumber(number);
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine(((num / 10) % 10));*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    System.Console.WriteLine(num % 10);
}
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("воскресенье");
        break;
   default:
        Console.WriteLine("введите число от 1 до 7");
        break;
}
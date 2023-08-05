// день недели исходя из его номера

int num1 = int.Parse(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("понедельник");
}

if (num1 == 2)
{
    Console.WriteLine("вторник");
}

if (num1 == 3)
{
    Console.WriteLine("среда");
}

if (num1 == 4)
{
    Console.WriteLine("четверг");
}

if (num1 == 5)
{
    Console.WriteLine("пятница");
}

if (num1 == 6)
{
    Console.WriteLine("суббота");
}

if (num1 == 7)
{
    Console.WriteLine("воскресенье");
}

else 
{
    Console.WriteLine("нет такого дня недели"); 
}
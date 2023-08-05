// день недели исходя из его номера

int num1 = int.Parse(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("понедельник");
    return;
}

if (num1 == 2)
{
    Console.WriteLine("вторник");
    return;
}

if (num1 == 3)
{
    Console.WriteLine("среда");
    return;
}

if (num1 == 4)
{
    Console.WriteLine("четверг");
    return;
}

if (num1 == 5)
{
    Console.WriteLine("пятница");
    return;
}

if (num1 == 6)
{
    Console.WriteLine("суббота");
    return;
}

if (num1 == 7)
{
    Console.WriteLine("воскресенье");
    return;
}

else 
{
    Console.WriteLine("нет такого дня недели"); 
}
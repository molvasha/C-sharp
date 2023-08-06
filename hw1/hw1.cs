// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine(num1 > num2 ? "первое число максимальное" : "второе число максимальное");


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 && num2 > num3)
{
    Console.WriteLine($"max = {num1}");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"max = {num3}");
}
else
{
    Console.WriteLine($"max = {num2}");
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num = int.Parse(Console.ReadLine());
Console.WriteLine(num % 2 == 0 ? "четное" : "нечетное");

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int count = 1;
if (num > 0)
{
    while (count <= num)
    {
         if (count % 2 == 0)
         {
             Console.WriteLine($"{count}");
         }
        count++;
    }
}

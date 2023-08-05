int num1 = int.Parse(Console.ReadLine()); 
int num2 = int.Parse(Console.ReadLine());

/* if (num1 * num1 == num2)
{
   Console.WriteLine("число 2 является квадратом 1 числа");
}
else
{
    Console.WriteLine("число 2 не является квадратом 1 числа");
} */

Console.WriteLine(num1 / num2 == num2 ? "число 2 является квадратом 1 числа" : "число 2 не является квадратом 1 числа");// тернарный оператор
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
System.Console.Write("Введите количество чисел ");
int amountOfNumbers = int.Parse(Console.ReadLine());
int[] newArray = GenerateArray(amountOfNumbers);
PrintArray(newArray);
CountPositiveNumbers(newArray);

void CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество положительных чисел: {result}");
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.WriteLine($"Введите число {i+1}: ");
        result[i] = int.Parse(System.Console.ReadLine());
    }
    return result;
}
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
IntersectionPoint();

void IntersectionPoint()
{
    System.Console.WriteLine("Введите значение b1");
    double b1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите значение k1");
    double k1 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите значение b2");
    double b2 = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите значение k2");
    double k2 = double.Parse(Console.ReadLine());
    if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямые совпадают");
    else if (k1 == k2 && b1 != b2) System.Console.WriteLine("Прямые параллельны");
    else if (k1 != k2 && b1 == b2) System.Console.WriteLine("Прямые пересекаются в нуле");
    else
    {
        double resultX = (b2 - b1) / (k1 - k2);
        double resultY = k1 * resultX + b1;
        System.Console.WriteLine($"Прямые пересекутся в X: {resultX}, Y: {resultY}");
    }
}
*/
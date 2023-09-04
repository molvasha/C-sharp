// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

/*
var array = GenerateArray(10);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(IsEven(array));

int IsEven (int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 999);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) // перебирает непосредственно значение элементов массива
    {
        Console.Write($"{i} ");
    }
}
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*var array = GenerateArray(10);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(SumNotEvenPos(array));

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) // перебирает непосредственно значение элементов массива
    {
        Console.Write($"{i} ");
    }
}

int SumNotEvenPos (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {   
        count += array[i];           
    }
    return count;
}
*/

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] array = GenerateArray(10); 
PrintArray(array);
Console.WriteLine("");
Console.WriteLine(DiffMaxMin(array));


double[] GenerateArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 10);
    }
    return result;
}

void PrintArray(double[] array)
{
    foreach (double i in array) // перебирает непосредственно значение элементов массива
    {
        Console.Write($"{i} ");
    }
}

double DiffMaxMin(double[] arr)
{
    double minElem = arr[0];
    double maxElem = arr[0];
    double result;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem) maxElem = arr[i];
        if (arr[i] < minElem) minElem = arr[i];
    }
    result = maxElem - minElem;
    return result;
}
*/


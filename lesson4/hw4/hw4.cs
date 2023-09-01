// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*int GetPower(int num, int n)
{
	int res = num;
	for (int i = 1; i < n; i++)
	{
		res *= num;
	}
	return res;
}

int res = GetPower(2, 5);
Console.WriteLine(res);*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int GetNumSum(int num);
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}

int res = GetNumSum(123);
Console.WriteLine(res);*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

PrintArray(GenerateArray(10));

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 9);
        
    }
    return result;
}
void PrintArray(int[] array)
{
    foreach(int i in array)//перебирает значения эл-тов массива
    Console.Write($"[{i}] ");
}
// Задача 64. Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
/*
System.Console.WriteLine(PrintNumbers(5, 1));

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start - 1, end);
}
*/
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
System.Console.WriteLine(GetSum(3, 7));

int GetSum(int start, int end)
{
    if (start == end) return end;
    return start + GetSum(start + 1, end);
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

System.Console.WriteLine(AkkermanFunction(3, 2));

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m-1, 1); 
    }
    return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
}

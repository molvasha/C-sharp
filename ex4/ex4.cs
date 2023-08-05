// вывести последний символ трехзначного числа

/*string num = Console.ReadLine();
System.Console.WriteLine(num[2]);*/ //неправильное решение

int num = int.Parse(Console.ReadLine());
int lastSymb = num % 10;
Console.WriteLine(lastSymb);

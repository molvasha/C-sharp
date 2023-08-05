// вывести числа в промежутке от n до -n
int num = int.Parse(Console.ReadLine());
int otrNum = -num;
while (otrNum <= num)
{
    System.Console.WriteLine(otrNum);
    otrNum++;
}
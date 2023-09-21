// Задача 54:
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* 
int[,] userArray = GenerateMatrix(6, 6);
PrintArray(userArray);
int[,] sortedUserArray = SortMatrix(userArray);
Console.WriteLine();
PrintArray(sortedUserArray);

int[,] GenerateMatrix(int n, int m)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    int[] resultStr = new int[array.GetLength(1)];

    int[] GetRows(int[,] array, int rows) 
    {
        int[] arrayRow = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayRow[j] = array[rows, j];
        }
        return arrayRow;
    }       

    void SortStr (int[] str)
{
    Array.Sort(str);
    Array.Reverse(str);
}    
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        resultStr = GetRows(array, i);
        SortStr(resultStr);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[i, j] = resultStr[j];
        }
    }
    return resultArray;

}
*/

// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] arrayUser = GenerateMatrix(4, 5);
PrintArray(arrayUser);
int min = SumElem(arrayUser);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {min}");

int[,] GenerateMatrix(int n, int m)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

int SumElem(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        } 
        sumRows[i] = sum;
        
    }
    int minSum = sumRows[0];
    int result = default;
    for (int k = 0; k < sumRows.GetLength(0); k++)
    {
        if (sumRows[k] < minSum) 
        {
            minSum = sumRows[k];
            result = k;
        }
    }
    return result + 1;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 58: 
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
/*
int[,] userArray1 = GenerateMatrix(3, 2);
int[,] userArray2 = GenerateMatrix(2, 3);
PrintArray(userArray1);
System.Console.WriteLine();
PrintArray(userArray2);
int[,] multiplyResult = MultiplyMatrix(userArray1, userArray2);
System.Console.WriteLine();
PrintArray(multiplyResult);

int[,] GenerateMatrix(int n, int m)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

int[] GetCols(int[,] array, int col)
{
    int[] arrayCol = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        arrayCol[i] = array[i, col];
    }
    return arrayCol;
}

int[] GetRows(int[,] array, int rows)
{
    int[] arrayRow = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arrayRow[j] = array[rows, j];
    }
    return arrayRow;
}   

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int[] arrayRows1 = new int[array1.GetLength(1)];
    int[] arrayCols2 = new int[array1.GetLength(0)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int n = 0; n < array2.GetLength(1); n++)
            {
                arrayRows1 = GetRows(array1, i);
                arrayCols2 = GetCols(array2, n);
                int sum = 0;
                for (int j = 0; j < arrayRows1.Length; j++)
                {
                    sum = sum + arrayRows1[j] * arrayCols2[j];
                }
                result[i, n] = sum;
            }
        }
    }
    else System.Console.WriteLine("Невозможно произвести умножение матриц. Необходимо проверить размерность.");
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
*/

//Задача 60. 
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

/*
int[,,] userArray = GenerateTripleMatrix();
PrintArray(userArray);

int[,,] GenerateTripleMatrix(int n = 2, int m = 2, int k = 2)
{
    Random random = new Random();
    int[,,] array = new int[n, m, k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = random.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        int k;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.WriteLine($"{array[i, j, k = 0]}({i}, {j}, {0})  {array[i, j, k = 1]}({i},{j},{1})");
            System.Console.WriteLine();
        }
    }
}
*/

//Задача 62.
//Напишите программу, которая заполнит спирально массив 4 на 4.

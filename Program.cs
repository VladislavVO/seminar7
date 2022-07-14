/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] CreateRandom2dArray (int m, int n, int min, int max)
{
    double[,] newArray = new double [m,n];

    for ( int i = 0; i < m; i++)    
        for ( int j = 0; j < n; j++)    
            newArray[i,j] = new Random().Next(min,max+1) + Math.Round((new Random().NextDouble()), 1);

    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();    
    }
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] MyArray = CreateRandom2dArray(m,n,min,max);
ShowArray(MyArray);

*/


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/


/*ПРИМЕЧАНИЕ: Нумерация рядов и столбцов в ShowNumber начинается с 0 */

/*
int[,] CreateRandom2dArray ()
{
    int[,] newArray = new int [4,4];

    for ( int i = 0; i < 4; i++)    
        for ( int j = 0; j < 4; j++)    
            newArray[i,j] = new Random().Next(1,10);

    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();    
    }
}

void ShowNumber(int[,] array, int row, int column)  
{
    
    if (4 <= row || 4 <= column) 
    {
    Console.WriteLine("такого числа в массиве нет");
    }

    else
    Console.Write(array[row, column]);
}

Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandom2dArray();
ShowArray(MyArray);
ShowNumber(MyArray, row, column);

*/


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] CreateRandom2dArray ()
{
    int[,] newArray = new int [4,4];

    for ( int i = 0; i < 4; i++)    
        for ( int j = 0; j < 4; j++)    
            newArray[i,j] = new Random().Next(1,10);

    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();    
    }
}

void ShowSredneeArifmeticheskoe(int[,] array)
{
    double sum;
    Console.Write("Среднее арифметическое каждого столбца: ");
    double[] SredneeArifmeticheskoeArray = new double [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        sum = array[i,j] + sum;
          
        SredneeArifmeticheskoeArray[i] = sum / array.GetLength(0);

        Console.Write(SredneeArifmeticheskoeArray[i] + "; ");
    }
}

int[,] MyArray = CreateRandom2dArray();
ShowArray(MyArray);
ShowSredneeArifmeticheskoe(MyArray);
*/
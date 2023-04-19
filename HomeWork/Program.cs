/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

*/
/*
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

double[,] Generate2DArray(int m, int n)
{
    double[,] array = new double[m,n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(-100, 100)/10.0;
        }
    }
    return array;

}

double[,] array = Generate2DArray(3,4);

PrintArray(array);


Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
*/
/*
int m = 6;
int n = 3;

int[,] array = Generate2DArray(m,n);

PrintArray(array);

Console.WriteLine("Введите координаты числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

GetGivenNumber(a, b, array);
*/
/*
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void GetGivenNumber(int a, int b, int[,] array)
{
    if(a >= m || b >= n)
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine($"{array[a, b]}");
    }
}

*/
/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int m = 3;

int n = 4;

int[,] array = Generate2DArray(m, n);

PrintArray(array);

GetAverageOfColumn(m, n, array);

void GetAverageOfColumn(int m, int n, int[,] array)
{
    for (int j = 0; j < n; j++)
    {
        double average = 0;
        for (int i = 0; i < m; i++)
        {
            average = average + array[i, j];
        }
        Console.WriteLine(average / m);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
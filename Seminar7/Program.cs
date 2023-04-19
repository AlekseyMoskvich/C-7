

//int[,] array = Generate2DArray(3,4);

//PrintArray(array);

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
    int[,] array = new int[m,n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;

}

/*Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5


int[,] GetNumberFromSumOfIndex(int m, int n)
{
    int[,] array = new int[m,n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

//int[,] array = GetNumberFromSumOfIndex(5,5);

//PrintArray(array);

Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2
5 92 3
8 42 4
Новый массив будет выглядеть вот так:
1 47 2
5 81 9
8 42 4




int[,] array = Generate2DArray(5,5);

PrintArray(array);

GetSquareOfOddIndex(3,4);

Console.WriteLine();

PrintArray(array);

int[,] GetSquareOfOddIndex(int m, int n)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if(j % 2 == 0 && i % 2 == 0)
            {
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}

Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив: 
1 47 2
5 92 3
8 42 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] array = Generate2DArray(5,5);

PrintArray(array);

int Sumnnumbers = GetSumOfEqualIndex(5,5);

Console.WriteLine(Sumnnumbers);

int GetSumOfEqualIndex(int m, int n)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == i)
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
}



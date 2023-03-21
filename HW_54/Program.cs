// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateArray(int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(1, 100);
        }
    }
    return resultArray;
}

void PrintArray(int[,] array)
{
    int rowsLen = array.GetLength(0);
    int columnsLen = array.GetLength(1);
    
    for (int i = 0; i < rowsLen; i++)
    {
        Console.Write("[\t");
        for (int j = 0; j < columnsLen; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine("]");
    }
}

int[,] SortRowsInArray(int[,] array)
{
    int rowsLen = array.GetLength(0);
    int columnsLen = array.GetLength(1);
    
    for (int i = 0; i < rowsLen; i++)
    {
        for (int j = 0; j < columnsLen; j++)
        {
            for (int k = j + 1; k < columnsLen; k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        (array[i, k], array[i, j]) = (array[i, j], array[i, k]);
                    }
                }
        }
    }
    return array;
}

int rows = 6;
int columns = 4;
int[,] matrix = CreateArray(rows, columns);

PrintArray(matrix);
Console.WriteLine();
int[,] sortedRowsInMatrix = SortRowsInArray(matrix);
PrintArray(sortedRowsInMatrix);
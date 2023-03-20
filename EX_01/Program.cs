// Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

int[,] CreateArray(int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
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

int[,] MoveFirstLastRows(int[,] array)
{
    int firstRow = 0;
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        (array[firstRow, i], array[lastRow, i]) = (array[lastRow, i], array[firstRow, i]);
    }
    return array;
}

int rows = 6;
int columns = 4;
int[,] matrix = CreateArray(rows, columns);

PrintArray(matrix);
Console.WriteLine();
PrintArray(MoveFirstLastRows(matrix));

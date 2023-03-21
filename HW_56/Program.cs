// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

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

void OneDimensionalPrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}

int[] MinimalSumElementsInRow(int[,] array)
{
    int rowsLen = array.GetLength(0);
    int columnsLen = array.GetLength(1);
    int[]newArray = new int[rowsLen];
    
    for (int i = 0; i < rowsLen; i++)
    {
        int sum = 0;
        for (int j = 0; j < columnsLen; j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum;
    }
    return newArray;
}

int FindMinimalInArray(int[] array)
{
    int min = array[0];
    int numberOfRow = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            numberOfRow = i;
        }
    }
    return numberOfRow;
}

int rows = 6;
int columns = 4;
int[,] matrix = CreateArray(rows, columns);

PrintArray(matrix);
Console.WriteLine();
int[] sortedRowsInMatrix = MinimalSumElementsInRow(matrix);
OneDimensionalPrintArray(sortedRowsInMatrix);
Console.WriteLine($"Сумма элементов в строке => {FindMinimalInArray(sortedRowsInMatrix)} минимальна");
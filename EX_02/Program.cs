// Задайте двумерный массив. Напишите программу, которая заменяет строки на
// столбцы. В случае, если это невозможно, программа должна вывести сообщение
// для пользователя.

int[,] CreateArray(int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(-10, 10);
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

bool ValidateMatrix(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1)) return true;
    return false;
}

int[,] TransparentMatrix(int[,] array)
{
    if (ValidateMatrix(array))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
        return array;
    }
    else
    {
        throw new Exception("Невозможно транспонировать таблицу");
    }
}

int rows = 4;
int columns = 6;
int[,] matrix = CreateArray(rows, columns);

PrintArray(matrix);
Console.WriteLine();

try
{
    TransparentMatrix(matrix);
    PrintArray(matrix);
}
catch (System.Exception)
{
    Console.WriteLine("Невозможно транспонировать данную таблицу");
    Console.WriteLine();
}
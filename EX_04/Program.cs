// Задайте двумерный массив из целых чисел. Напишите программу, которая
// удалит строку и столбец, на пересечении которых расположен наименьший
// элемент массива.

void PrintArray(int[,] matrix)
{
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 100);
        }
    }
}

(int row, int column) GetIndexesOfMin(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;

    int rowsLen = array.GetLength(0);
    int columnsLen = array.GetLength(1);

    for (int i = 0; i < rowsLen; i++)
    {
        for (int j = 0; j < columnsLen; j++)
        {
            if (array[i, j] < array[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            } 
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteByIndexes(int[,] array, int row, int column)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    int newI = 0;
    int newJ = 0;

    int rowsLen = array.GetLength(0);
    int columnsLen = array.GetLength(1);

    for (int i = 0; i < rowsLen; i++)
    {
        if (i == row) continue;
        for (int j = 0; j < columnsLen; j++)
        {
            if (j == column) continue;
            newArray[newI, newJ] = array[i, j];
            newJ++;            
        }
        newI++;
        newJ = 0;
    }
    return newArray;
}

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

int[,] matrix = new int[countRows, countColumns];
// PrintArray(matrix);
FillArray(matrix);
// Console.WriteLine();
PrintArray(matrix);

(int row, int column) = GetIndexesOfMin(matrix);
Console.WriteLine();
Console.WriteLine($"{row}, {column}");
Console.WriteLine();
PrintArray(DeleteByIndexes(matrix, row, column));
// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArrayOne(int countRows, int countColumns)
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

int[,] CreateArrayTwo(int countRows, int countColumns)
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

bool PossibilityOfMatrixMultiplication(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) == array2.GetLength(0)) return true;
    return false;
}

int[,] MultiplicationOfMatrixes(int[,] array1, int[,] array2)
{
    if (PossibilityOfMatrixMultiplication(array1, array2))
    {
        int rowsLen = array1.GetLength(0);
        int columnsLen = array2.GetLength(1);
        int forRowsAndColumnsMultiply = array1.GetLength(1);
        
        int[,] CreateMultiplicationMatrix = new int[rowsLen, columnsLen];
        for (int i = 0; i < rowsLen; i++)
        {
            for (int j = 0; j < columnsLen; j++)
            {
                int cellInMatrixResult = 0;
                for (int k = 0; k < forRowsAndColumnsMultiply; k++)
                {
                    cellInMatrixResult = cellInMatrixResult + array1[i, k] * array2[k, j];
                }
                CreateMultiplicationMatrix[i, j] = cellInMatrixResult;
                cellInMatrixResult = 0;
            }
        }
        return CreateMultiplicationMatrix;
    }
    else
    {
        throw new Exception("Невозможно перемножить данные матрицы");
    }
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

int[,] array1 = CreateArrayOne(5, 3);
int[,] array2 = CreateArrayTwo(3, 4);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
// Console.WriteLine();
// int rowsLen = array1.GetLength(0);
// Console.WriteLine(rowsLen);
// int columnsLen = array2.GetLength(1);
// Console.WriteLine(columnsLen);
Console.WriteLine();
try
{
    int[,] newArray = MultiplicationOfMatrixes(array1, array2);
    PrintArray(newArray);
}
catch (System.Exception)
{
    Console.WriteLine("Невозможно перемножить данные матрицы");
    Console.WriteLine();
}
// int[,] newArray = MultiplicationOfMatrixes(array1, array2);
// PrintArray(newArray);

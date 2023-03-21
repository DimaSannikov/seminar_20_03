// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateArray(int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    int iMin = 0;
    int jMin = 0;
    int iMax = countRows - 1;
    int jMax = countColumns - 1;
    int count = 1;
    int sizeArray = countRows * countColumns;

    

    while (count <= sizeArray)
    {
        
        for (int j = jMin; j <= jMax; j++)
        {
            resultArray[iMin, j] = count;
            count++;
        }
        if (count > sizeArray)break;
        iMin++;
        
        for (int i = iMin; i <= iMax; i++)
        {
            resultArray[i, jMax] = count;
            count++;
        }
        if (count > sizeArray)break;
        jMax--;

        for (int j = jMax; j >= jMin; j--)
        {
            resultArray[iMax, j] = count;
            count++;
        }
        if (count > sizeArray)break;
        iMax--;

        for (int i = iMax; i >= iMin; i--)
        {
            resultArray[i, jMin] = count;
            count++;
        }
        if (count > sizeArray)break;
        jMin++;
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

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

PrintArray(CreateArray(countRows, countColumns));

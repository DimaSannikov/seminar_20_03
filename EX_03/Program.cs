// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных. Значения элементов
// массива 0..9

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

int[] GetFrequencyArray(int[,] array)
{
    int[] resultArray = new int[10];
    foreach (int item in array)
    {
        resultArray[item]++;
    }
    return resultArray;
}

void PrintArr(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}

Console.Write("Количество строк массива ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int columns = int.Parse(Console.ReadLine());

int[,] array = CreateArray(rows, columns);

PrintArray(array);
Console.WriteLine();
// PrintArray(MoveFirstLastRows(matrix));

int[] arrayFrequency = GetFrequencyArray(array);
PrintArr(arrayFrequency);


// Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int firstDimension, int secondDimension, int thirdDimension)
{
    int[,,] resultArray = new int[firstDimension, secondDimension, thirdDimension];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < resultArray.GetLength(2); k++)
            {
                resultArray[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return resultArray;
}

void PrintThreeDimensionArray(int[,,] array)
{
    int firstDimension = array.GetLength(0);
    int secondDimension = array.GetLength(1);
    int thirdDimension = array.GetLength(2);
        
    for (int k = 0; k < thirdDimension; k++)
    {
        for (int i = 0; i < firstDimension; i++)
        {
            for (int j = 0; j < secondDimension; j++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            
        Console.WriteLine();
        }
    }
}

int a = 2;
int[,,] threeDimensionArray = CreateArray(a, a, a);
PrintThreeDimensionArray(threeDimensionArray);
// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 2, 8);

PrintArray(array);

Console.WriteLine();

int[,] array2 = SquareEvenIndex(array);

PrintArray(array2);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return result;
}

int[,] SquareEvenIndex(int[,] result)
{
     for (int i = 0; i < result.GetLength(0); i=i+2)
    {
        for (int j = 0; j < result.GetLength(1); j=j+2) {
            result[i,j] = result[i,j]*result[i,j];
        }
}
    return result; 
    }



void PrintArray(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

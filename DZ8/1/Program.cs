// Задачи оформляем в методы!
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Main();

void Main () {
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

PrintArray(SortArray(array));

}

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

int[,] SortArray (int[,] result) {

for (int k = 0; k < result.GetLength(0); k++)
{
    for (int i = 0; i < result.GetLength(1) - 1; i++)
        {
        int min = result[k,i];
        int imin = i;
        int temp;
            for (int j = 1 + i; j < result.GetLength(1); j++)
                {
                if (result[k,j] > min) {
                min = result[k,j];
                imin = j; }
                }      
        temp = result[k,imin];
        result[k,imin] = result[k,i];
        result[k,i] = temp;
        }
    }
return result;    
}
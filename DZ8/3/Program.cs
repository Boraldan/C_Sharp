// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Main();

void Main () {
Console.Clear();
Console.Write("Введите размер квадратных матриц: ");
int rows = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(rows, rows, 0, 5);
int[,] array2 = GetArray(rows, rows, 0, 5);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Итоговоая матрица: ");
PrintArray(SumMatrArray(array1, array2));

int [,] SumMatrArray(int [,] inArray1, int [,] inArray2) 
    {   
        int size = inArray1.GetLength(0);
        int [,] result = new int [size, size];
        
        for (int i = 0; i < size; i++)
        {   
            for (int j = 0; j < size; j++)
            { 
                for (int k = 0; k < size; k++)
                {
                    result[i,j] += inArray1[i,k] * inArray2[k,j];  
                }                    
            } 
        }
        
    return result;
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
}
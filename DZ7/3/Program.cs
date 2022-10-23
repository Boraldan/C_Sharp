// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Main();

void Main () {
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 0, 3);

PrintArray(array);

MiddleColumns(array);

}

void MiddleColumns (int [,] inArray)
 {  Console.Write("Среднее арифметическое каждого столбца: ");
    int m  = inArray.GetLength(0);
    int n = inArray.GetLength(1); 
    
    for (int i = 0; i < n; i++) { 
        double sum = 0;
        for (int j = 0; j < m; j++)    {
             sum += inArray[j,i];
        }
        
        if (i < n-1 )
        Console.Write(Math.Round(sum/m, 1) + "; ");
        else
        Console.Write(Math.Round(sum/m, 1) + "."); 
    }
    
}

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}     ");
        }
        Console.WriteLine();
    }
}

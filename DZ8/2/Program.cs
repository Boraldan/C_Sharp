// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
Console.WriteLine("Сумма элементов по строком: ");
PrintArr(SumLineArray(array));
Console.WriteLine();

MinLine(SumLineArray(array));

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

int[] SumLineArray (int[,] result) 
    {
    int[] sumLine = new int[result.GetLength(0)];

    for (int i = 0; i < result.GetLength(0); i++)
        {
        int sum = 0;
            for (int j = 0; j < result.GetLength(1); j++) {
                sum += result[i,j];
            }
        sumLine[i] = sum;
        }
    return sumLine;    
    }

void MinLine (int [] inArray) {

    int min = inArray[0];
    int imin = 0;
    for (int i = 1; i < inArray.Length-1; i++)
        {
            if (min > inArray[i]) {
                min = inArray[i];
                imin = i;
            }
        }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {imin + 1} строка");
    }

void PrintArr(int[] a)     {                                
    
    for (int i = 0; i < a.Length; i++) {
        if (i < a.Length-1)   {
        Console.WriteLine ($"{a[i]}");    }
        else  {
            Console.Write (a[i]);       } 
        }
        Console.WriteLine("  "); 
    }
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)


Main();

void Main () {
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите номер элемента в строке: ");
int rowIndex = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер элемента в столбце: ");
int columnIndex = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 0, 10);

CheckIndex(array, rowIndex, columnIndex);

}

void CheckIndex (int [,] inArray, int i, int j)
 {
    if (i >= 0 && i<= inArray.GetLength(0) && j >= 0 && j<= inArray.GetLength(1)) {
    PrintArray(inArray, i, j);
    Console.Write($"Значение элемента = {inArray[i-1, j-1]}  в ячейке [{i}, {j}]"); }
    else {
    PrintArray(inArray, i, j);
    Console.Write($"Такого числа в массиве нет ([{i}, {j}] это позиция элемента)"); }
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

void PrintArray(int [,] inArray, int iR, int jC)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {if (i == iR-1 && j == jC-1)
        Console.Write($"[ {inArray[i,j]} ]   ");
        else
        Console.Write($"{inArray[i,j]}    ");
        }
        Console.WriteLine();
    }
}

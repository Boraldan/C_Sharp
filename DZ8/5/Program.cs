// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.Write("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

PrintArray(SpiralArray(array));

int[,] SpiralArray(int [,] arrya4)
{
int temp = 1;
int i = 0;
int j = 0;

while (temp <= arrya4.GetLength(0) * arrya4.GetLength(1))
    {
    arrya4[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < arrya4.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= arrya4.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > arrya4.GetLength(1) - 1)
        j--;
    else
        i--;
    }
return arrya4;

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

                // Вариант еще одного решения со спиралью в другую сторону
                // int N = 4, M = 4;
                // int[,] A = new int[N, M];
     
                // int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;
     
                // for (int i = 0; i < A.Length; i++)
                // {
                //     A[col, row] = i + 1;
                //     if (--gran == 0)
                //     {
                //         gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                //         int temp = dx;
                //         dx = -dy;
                //         dy = temp;
                //         dirChanges++;
                //     }
                //     col += dx;
                //     row += dy;
                // }
     
                // for (int i = 0; i < N; i++)
                // {
                //     for (int j = 0; j < M; j++)
                //     {
                //         Console.Write(A[i, j] + " ");
                //     }
                //     Console.WriteLine();
                // }
     
                // Console.ReadKey();

﻿// Convert.ToSingle   конвертация из стринг в int , надо разбираться

 

Console.Clear();

// Console.Write("Введите имя: ");
// string? name = Console.ReadLine();
 
// int age = Convert.ToInt32($"{name[0]}");


// Console.WriteLine(age+ 2);

 // Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза



Main();

void Main () {
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0,10);
PrintArray(array);
Console.WriteLine();

PrintArray(array); 

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

int[,] CountArray(int[,] inArray)
{   
    int[,] result = new int[2, 2];
    int iL = inArray.GetLength(0);
    int jL = inArray.GetLength(1);
    int num = 0;
    int newSize = 0;
    int count;
    for (int i = 0; i < iL; i++){
        for (int j = 0; j < jL; j++)
        {   num = inArray[i,j];
            result[0,newSize] = num;
            count = 0;
            // for (int c = 0; c < iL; с++)
            // {
            //     for (int b = 0; b < jL; b++)
            //     {
            //         // if (inArray[c,b] == num) count++;
            //         Console.Write($"Здесь {inArray[c,b]}");
            //     }
            // } 
            foreach (int el in inArray)
            {
                Console.Write($" Здесь {el}");
            }

        
        result[1, newSize] = count;
        newSize++;

        ResizeArray(ref result, 2, newSize);


        }
     }

    return result;
}


void ResizeArray <T> (ref T[,] array, int size1, int size2)
{
T[,] new_array = new T[size1, size2];
size1 = Math.Min(array.GetLength(0), size1);
size2 = Math.Min(array.GetLength(1), size2);
for (int i = 0; i < size1; i++) {
for (int j = 0; j < size2; j++) new_array[i, j] = array[i, j];
}
array = new_array;
}
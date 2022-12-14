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
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine();

PrintArray(CountArray(array)); 
Console.WriteLine();

RedizArray(CountArray(array)); 
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
    int[,] result = new int[2, 1];
    int iL = inArray.GetLength(0);
    int jL = inArray.GetLength(1);
    int num = 0;
    int newSize = 0;
    for (int i = 0; i < iL; i++){
        for (int j = 0; j < jL; j++)
        {   num = inArray[i,j];
            result[0,newSize] = num;
            int count = 0;
            foreach (int el in inArray)
            {
            if (el == num) count++;
            }
                
        result[1, newSize] = count;
        newSize++;
        ResizeArray(ref result, 2, newSize + 1);
        }
    }
    ResizeArray(ref result, 2, newSize);
    return result;
}

void ResizeArray <T> (ref T[,] array, int size1, int size2)
{
T[,] new_array = new T[size1, size2];
size1 = Math.Min(array.GetLength(0), size1);
size2 = Math.Min(array.GetLength(1), size2);
for (int i = 0; i < size1; i++) 
{   
    for (int j = 0; j < size2; j++) 
    new_array[i, j] = array[i, j];
}
array = new_array;
}

void RedizArray(int[,] inArray)
{   
    int[,] result = new int[2, 1];
    int iL = inArray.GetLength(0);
    int jL = inArray.GetLength(1);
    int newSize = 0;
    result[0,0] = inArray[0,0];
    result[1,0] = inArray[1,0];
    for (int i = 1; i < jL; i++){
        bool find = false;
        for (int j = 0; j < result.GetLength(1); j++)
        {
        if (inArray[0,i] == result[0,j]) {
        find = true; 
        break;
        }
        }
    if (find == false) {
    newSize++;
    ResizeArray(ref result, 2, newSize + 1);
    result[0,newSize] = inArray[0,i];
    result[1,newSize] = inArray[1,i];
    }
    }

    for (int i = 0; i < result.GetLength(1) - 1; i++)
        {
        // int min = result[0,i];    Можно обойтись без минимума, просто сохраняя индекс ячейки с минимальным значением. 
        int imin = i;
        int temp;
            for (int j = 1 + i; j < result.GetLength(1); j++)
                {
                // if (result[0,j] < min) { Можно обойтись без минимума, просто сохраняя индекс ячейки с минимальным значением.
                // min = result[0,j]; 
                if (result[0,j] < result[0,imin]) {
                

                imin = j; }
                }      
        temp = result[0,imin];
        result[0,imin] = result[0,i];
        result[0,i] = temp;
                
        temp = result[1,imin];
        result[1,imin] = result[1,i];
        result[1,i] = temp;
        }
    
    for (int i = 0; i < result.GetLength(1); i++)
    {
       Console.Write($"Элемент {result[0,i]} встречается в массиве {result[1,i]} раз");
       Console.WriteLine();
    }
    }




//  Вариант с непорятной ошибкой: Если 0 стоит не на первом месте в ячейке [0,0] то далее программа его не считает. 

//  Main();

// void Main () {
// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 3);
// PrintArray(array);
// Console.WriteLine();
 
// CountArray(array); 
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i,j] = new Random().Next(minValue,maxValue+1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//      for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void CountArray(int[,] inArray)
// {   
//     int[,] result = new int[2, 1];
//     int iL = inArray.GetLength(0);
//     int jL = inArray.GetLength(1);
//     int num;
//     int newSize = 0;
//     for (int i = 0; i < iL; i++){
//         for (int j = 0; j < jL; j++)
//         {   num = inArray[i,j];
//             int count = 0;
//             if (i+j != 0) { 
//                 bool find = false;
//                     for (int k = 0; k < result.GetLength(1); k++) 
//                         { 
//                         if (num == result[0,k]) {
//                         find = true; 
//                         break;}
//                         }

//                         if (find == false) 
//                         {
//                             result[0,newSize] = num;
//                             foreach (int el in inArray) { 
//                                 if (el == num) { count++;} }
//                                 result[1, newSize] = count;
//                                 newSize++;
//                                 ResizeArray(ref result, 2, newSize + 1);         
//                         }
//                         }
//             else
//             { result[0,newSize] = num;
//             foreach (int el in inArray) {
//              if (el == num) {count++;} }                 
//             result[1, newSize] = count;
//             newSize++;
//             ResizeArray(ref result, 2, newSize + 1);
//         }
//     }
//     }
//     ResizeArray(ref result, 2, newSize);
    
//     for (int i = 0; i < result.GetLength(1); i++)
//     {
//        Console.Write($"Элемент {result[0,i]} встречается в массиве {result[1,i]} раз");
//        Console.WriteLine();
//     }
// }

// void ResizeArray <T> (ref T[,] array, int size1, int size2)
// {
// T[,] new_array = new T[size1, size2];
// size1 = Math.Min(array.GetLength(0), size1);
// size2 = Math.Min(array.GetLength(1), size2);
// for (int i = 0; i < size1; i++) 
// {   
//     for (int j = 0; j < size2; j++) 
//     new_array[i, j] = array[i, j];
// }
// array = new_array;
// }

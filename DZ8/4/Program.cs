// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Main();

void Main () {
Console.Clear();
Console.Write("Введите количество строк массива: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите количество горизонталей массива: ");
int c = int.Parse(Console.ReadLine());

int[,,] array = GetArray(a, b, c, 0, 10);
Console.WriteLine();
 
PrintArray(array);


}

int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)  
    {
    int[,,] result = new int[m, n, l];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j <result.GetLength(1); j++)
          {  
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i,j,k] = minValue - 1;
            }
          } 
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            for (int k = 0; k < l; k++)
            {                 
                result[i,j,k] = FindNum(result);  
            }
           
        }
    }
    return result;
    

    int FindNum(int [,,] d3Aray)              // рекунсия по подбору числа
    {
    int N = new Random().Next(minValue,maxValue+1);
    bool x = true;
    foreach (int el in d3Aray)
        {
        if(el == N) x = false;    
        }     
            if (x==true) return N;
            return FindNum (d3Aray);
    }
    }

void PrintArray(int[,,] inArray)
    {
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i,j,k]} ({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }
    }

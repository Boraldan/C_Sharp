// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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
MixArray(array);

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

int[,] MixArray(int[,] inArray)
{
    int iL = inArray.GetLength(0);
    int jL = inArray.GetLength(1);
    int[,] result1 = new int[iL, jL];
    if (iL == jL) {
        int temp = 0;
    for (int i = 0; i < iL; i++){
        for (int j = 0; j < jL; j++)
        {
         result1[j,i] =  inArray[i,j]; 
        
        }
        }

     PrintArray(result1); 
    }  
    else
    {
      Console.WriteLine("В данном массиве невозможно сделать замены");  
    }
    return result1;
}
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int [] arr1 = GetArray (123, 1, 200);

PrintArr(arr1);

Console.WriteLine(" ");

Console.Write($" Количество искомых элементов: {CountArray(arr1)}");


int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
       //  Console.Write($"{res[i]} ");
    }
    return res;
}

int CountArray(int [] arr)
{  
    int count = 0;

        for (int i = 0; i < arr.Length; i++)
    { if (arr[i] > 9 &&  arr[i] < 100) 
    count ++;
      }
    return count;
}

void PrintArr(int[] a) 
{
    Console.Write ("[");
    for (int i = 0; i < a.Length; i++) {
        if (i < a.Length-1)   {
        Console.Write ($"{a[i]}, ");    }
        else  {
            Console.Write (a[i]);       } 
  }
    Console.Write ("]");
}


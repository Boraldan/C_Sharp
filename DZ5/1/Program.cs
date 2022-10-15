// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();

Console.Write("Enter size Array: ");
int S = int.Parse(Console.ReadLine()!);

int [] array = GetArray (S, 100, 1000);

PrintArr(array);

Console.WriteLine(" ");

Console.Write ($"The number of even elements in the array: {CountPositivArray(array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    
    }
    return res;
}
 
void PrintArr(int[] a) 
{
    Console.Write ("[ ");
    for (int i = 0; i < a.Length; i++) {
        if (i < a.Length-1)   {
        Console.Write ($"{a[i]}, ");    }
        else  {
            Console.Write (a[i]);       } 
  }
    Console.Write (" ]");
}


int CountPositivArray(int [] ray) {

int count = 0;

foreach (int el in ray)
{
   if (el % 2 == 0)
   count++;    
}
return count;
}

 
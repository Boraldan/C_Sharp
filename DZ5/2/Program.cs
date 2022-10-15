// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.Clear();

Console.Write("Enter size Array: ");
int S = int.Parse(Console.ReadLine()!);

int [] array = GetArray (S, -10, 10);

PrintArr(array);

Console.WriteLine(" ");

Console.Write ($"The sum uneven array: {SumUnevenIndexArray(array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    
    }
    return res;
}
 
void PrintArr(int[] prA) 
{
    Console.Write ("[ ");
    for (int i = 0; i < prA.Length; i++) {
        if (i < prA.Length-1)   {
        Console.Write ($"{prA[i]}, ");    }
        else  {
            Console.Write (prA[i]);       } 
  }
    Console.Write (" ]");
}


int SumUnevenIndexArray(int [] ray) {
int sum = 0;
for (int i = 0; i < ray.Length; i=i+2)
{    sum = sum + ray[i];    }
return sum;  }

 
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();

int S = NewInt();
int [] array = GetArray (S, 1, 100);
PrintArr(array);
 
Console.Write ($"Differ: {DifferMaxMinArr(array)}");

int NewInt () {
    Console.Write("Enter size Array: ");
    int num = int.Parse(Console.ReadLine()!);
    return num; }

int[] GetArray(int size, int minValue, int maxValue) {
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    { res[i] = new Random().Next(minValue, maxValue);   }
    return res; }
 
void PrintArr(int[] prA)  {
    Console.Write ("[ ");
    for (int i = 0; i < prA.Length; i++) {
        if (i < prA.Length-1)   { Console.Write ($"{prA[i]}, ");    }
        else    {  Console.Write (prA[i]);   } }
    Console.Write (" ]");
    Console.WriteLine(" ");  }

int DifferMaxMinArr(int [] tempArr) {
    int diff = 0;
    int max = tempArr[0];
    int min = tempArr[0];
    foreach (int el in tempArr)
    { if (el > max) {max = el;}
      if (el < min) {min = el;}
    }
    diff = max - min;
    Console.WriteLine($"max {max} "); 
    Console.WriteLine($"min {min} "); 
    return diff;
}
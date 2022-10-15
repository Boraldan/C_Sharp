// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

Console.Write("Enter size Array: ");
int S = int.Parse(Console.ReadLine()!);

int [] arr1 = GetArray (S, 2, 5);

PrintArr(arr1);

Console.WriteLine(" ");

PrintArr(NewArray(arr1));

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


int [] NewArray(int [] arr)
{   
    int size = 0;

    if (arr.Length%2 == 0) {
    size = arr.Length/2;}
    else {
    size = arr.Length/2 + 1;}

    int [] new1 = new int [size];  
    
    if (arr.Length%2 == 0) {
    for (int i = 0; i < arr.Length/2; i++) {
    new1[i] = arr[i] * arr [(arr.Length - 1) - i]; }
    }

    else {
    for (int i = 0; i <= arr.Length/2; i++) {
    new1[i] = arr[i] * arr [(arr.Length - 1) - i]; 
    if (i == arr.Length/2){
        new1[i] = arr[i];
    }
    }
    }
    return new1;

} 
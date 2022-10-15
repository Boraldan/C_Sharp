// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        // Console.Write($"{res[i]} ");
    }
    return res;
}

int[] FlipArray(int [] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
        // Console.Write($"{arr[i]} ");
    }
    return arr;
}


int[] array = GetArray(10, -10, 10);


void PrintArr(int[] a) {

    Console.Write ("[");

    for (int i = 0; i < a.Length; i++)
    {
        if (i < a.Length-1)  
        {
        Console.Write ($"{a[i]}, ");
        }
        else
        {
            Console.Write (a[i]);
        }
    }
    Console.Write ("]");
}

PrintArr(array);
Console.WriteLine();
PrintArr(FlipArray(array));
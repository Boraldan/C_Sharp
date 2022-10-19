// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();

int [] arr = DecimalToBinary(EnterNum ());
PrintArr(ReverseArray2(arr));

int EnterNum () {
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine()!);
    return a;
    }


int [] DecimalToBinary(int d) {

    int [] arrBin = new int [1];

    int i = 0;
    while (d > 0) {
    if (d%2 == 0) {
    d = d/2;
    arrBin[i] = 0;
    i++; }
    else {
    d = (d-1)/2;
    arrBin[i] = 1;
    i++; 
    }
    Array.Resize(ref arrBin, i+1);
    if (d == 0) Array.Resize(ref arrBin, i);
    }
    return arrBin;
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
    Console.WriteLine("  ");
    }


int[] ReverseArray2(int[] inArray) {       //// переворот массива
    int N = inArray.Length;
    int[] result = new int[N];
    for(int i=0; i <N; i++)
    {
        result[i] = inArray[N -1 -i];
    }
    return result;
    }


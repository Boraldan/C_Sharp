Методы

Console.Clear();                                            /// очистка консоли

int EnterNum () {                                           /// ввод числа
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine()!);
    return a;     }

Array.Resize(ref inArray, N)                                /// изменение размера массива  

int[] GetArray(int size, int minValue,int maxValue) {       /// создание произвольного массива

    int[] res =new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res; }


int[] ReverseArray1(int[] result) {                         /// переворот массива 1
 
    int N = result.Length; 
    for(int i=0; i < N/2; i++)
    {   int temp = result[i];
        result[i] = result[N -1 -i];
        result[N -1 -i] = temp;
    }
    return result; }


 int[] ReverseArray2(int[] inArray) {       /// переворот массива 2
    int N = inArray.Length;
    int[] result = new int[N];
    for(int i=0; i <N; i++)
    {
        result[i] = inArray[N -1 -i];
    }
    return result; }


void PrintArr(int[] a)     {                                ///  печать массива
    Console.Write ("[ ");
    for (int i = 0; i < a.Length; i++) {
        if (i < a.Length-1)   {
        Console.Write ($"{a[i]}, ");    }
        else  {
            Console.Write (a[i]);       } 
  }
    Console.Write (" ]");
    Console.WriteLine("  "); }


int Sun(int n) {                                            /// рекурси факториала N!
    if (n == 1) return 1;
    else  return n * Sun (n-1); }
    Console.WriteLine(Sun(5));


int [] HandArray(int N){                                    /// ручной ввод массива
    int[] handArray = new int [N];
    for (int i = 0; i < N; i++)
    {   Console.Write($"Введите {i+1} число: ");
        handArray[i] = EnterArrNum();
    }
    return handArray; }

 
 
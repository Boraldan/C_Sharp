Методы

Console.Clear();                                            /// очистка консоли

Console.Write("Введите имя: ");
string? name = Console.ReadLine();
 
Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());
 
Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());


int EnterNum () {                                           /// ввод числа
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine()!);
    return a;     }

Array.Resize(ref inArray, N)                                /// изменение размера массива  

void ResizeArray <T> (ref T[,] array, int size1, int size2)    /// изменение размера двумерного [ , ] массива 
    {
    T[,] new_array = new T[size1, size2];
    size1 = Math.Min(array.GetLength(0), size1);
    size2 = Math.Min(array.GetLength(1), size2);
    for (int i = 0; i < size1; i++) {
    for (int j = 0; j < size2; j++) new_array[i, j] = array[i, j];
    }
    array = new_array;
    }

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

void PrintArray(int[,,] inArray)                            // печать 3D массива
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


int Sun(int n) {                                            /// рекурсия факториала N!
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

 
bool IsEven (int value) {                                   /// проверка числа на четность через bool
    return value % 2 == 0;
    }


int  RandomIntNumber(int minValue, int maxValue)      // Random Double Number
    {
    int rnd  = new Random().Next(minValue, maxValue + 1);
    return rnd;
    }

 

double  RandomDoubleNumber(int minValue, int maxValue, int round)      // Random Double Number

    {
    double rnd = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), round);
    return rnd;
    }

Символьные литералы                                         // Символьные литералы
    '\n' - перевод строки
    '\t' - табуляция
    '\\' - слеш
    \"   - ковычки    

int FindNum(int [,,] d3Aray)                            // рекунсия по подбору неповторяющегося числа в массив
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
    
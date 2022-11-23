// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами. 


string [] strArr = {"Hello", "Hi", "Tomorro", "GB", "Forever"};

int N = 1;
int j = 0;
string [] rezalt = new string [N];
for (int i = 0; i < strArr.Length; i++)
{
    if (3 >= strArr[i].Length) 
    {
      rezalt[j] = strArr[i];
      j++;  
      Array.Resize(ref rezalt, ++N);  
    }
}

Array.Resize(ref rezalt, --N);

PrintArr(rezalt);
 
 void PrintArr(string [] a)                                     
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
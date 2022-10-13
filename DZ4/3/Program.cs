// Задача 29: Напишите программу, которая задаёт массив до 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

Console.Clear();

int N = new Random().Next(0, 9); 

int [] array = new int [N];

PrintArr(ArrCreate(array), N);

int [] ArrCreate(int [] arr) {
    
    for (int i = 0; i < arr.Length; i++) {
    arr[i] = new Random().Next(0, 1000); 
    }

    return arr;
 }


void PrintArr(int[] a, int n) {
    Console.Write ($"Array of {n} numbers: [");

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

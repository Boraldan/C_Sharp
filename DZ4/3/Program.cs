// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]


int [] arrya = new int [8];

PrintArr(ArrCreat(arrya));

int [] ArrCreat(int [] arr) {
    
    for (int i = 0; i < arr.Length; i++) {
    arr[i] = new Random().Next(0, 1000); 
    }

    return arr;
 }


void PrintArr(int[] a) {
    Console.Write ("Array on 8 numbres: [");

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
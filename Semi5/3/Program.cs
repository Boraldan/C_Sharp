// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



Console.Clear();

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

int [] array = new [] {1, 2, 3, 4, 2, 5, 6, 7};

void  ArraySech(int [] arr)
{
    bool a = false;
        for (int i = 0; i < arr.Length; i++)
    {         
        if  (arr[i] == number) {
            a = true;
            Console.WriteLine("Да ");
            break;
            }
    }

    if (a == false)
    Console.WriteLine("Нет ");
}

ArraySech(array);
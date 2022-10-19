// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write($"Количество цифр больше нуля = {CountPositivArray(HandArray(EnterNum()))}");

int EnterNum () {                                       /// ввод числа
    Console.Write("Введите количество чисел: ");
    int a = int.Parse(Console.ReadLine()!);
    return a;     }

int EnterArrNum () {                                       /// ввод числа массива
    int a = int.Parse(Console.ReadLine()!);
    return a;     }


int [] HandArray(int N){                                    /// метод ввода числа массива
    int[] handArray = new int [N];
    for (int i = 0; i < N; i++)
    {   Console.Write($"Введите {i+1} число: ");
        handArray[i] = EnterArrNum();
    }
    return handArray;
}

int CountPositivArray(int [] ray) {                         /// счетчик положительных чисел
    int count = 0;
    foreach (int el in ray)
    {
    if (el > 0)
    count++;    
    }
    return count;
    }

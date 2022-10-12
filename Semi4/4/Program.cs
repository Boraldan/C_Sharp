// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]

Console.Clear();

int[] arr = new int [8];

void ArrRandom(int[] aT) {

for (int i = 0; i < aT.Length; i++)
{
    int num = new Random().Next(0, 2);
    aT[i] = num;
    Console.Write(aT[i] + " ");
}
}

ArrRandom(arr);


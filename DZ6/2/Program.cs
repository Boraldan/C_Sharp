// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

//   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();     

Console.Write ("Введите значение b1: ");
double b1 = EnterNum (); 
 
Console.Write ("Введите значение b2: ");
double b2 =  EnterNum (); 

Console.Write ("Введите значение k1: ");
double k1 = EnterNum (); 
 
Console.Write ("Введите значение k2: ");
double k2 =  EnterNum (); 

Console.Write ("Точка пересечения  ");
PrintArr(CrossLines(b1, b2, k1, k2));


double EnterNum () {                                           /// ввод числа
    double a = double.Parse(Console.ReadLine()!);
    return a;     }


double [] CrossLines (double b1, double b2, double k1, double k2) {
    double [] crossLines = new double[2];
    double Xa = (b2-b1) / (k1-k2);
    double Ya = k1*Xa + b1;
    crossLines[0] = Xa;
    crossLines[1] = Ya;
    return crossLines;
    }

void PrintArr(double [] a)     {                                ///  печать массива
    Console.Write ("[ ");
    for (int i = 0; i < a.Length; i++) {
        if (i < a.Length-1)   {
        Console.Write ($"{a[i]}; ");    }
        else  {
            Console.Write (a[i]);       } 
  }
    Console.Write (" ]");
    Console.WriteLine("  "); }

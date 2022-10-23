// Convert.ToSingle   конвертация из стринг в int , надо разбираться


int EnterNum () {                                           /// ввод числа
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine()!);
    return a;     }


 

// double d = Math.Round(-10 + new Random().NextDouble() * (20 + 10), 2);
// Console.Write(d);

Console.Write(RandomDoubleNumber(9, 10, 3));


double  RandomDoubleNumber(int minValue, int maxValue, int round)      // Random Double Number
    {
    double rnd = Math.Round(minValue + new Random().NextDouble() * (maxValue - minValue), round);
    return rnd;
    }
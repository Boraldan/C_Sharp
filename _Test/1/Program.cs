// Convert.ToSingle   конвертация из стринг в int , надо разбираться


int EnterNum () {                                           /// ввод числа
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine()!);
    return a;     }


 

// double d = Math.Round(-10 + new Random().NextDouble() * (20 + 10), 2);
// Console.Write(d);

Console.Write(RandomIntNumber(9, 10));


int  RandomIntNumber(int minValue, int maxValue)      // Random Double Number
    {
    int rnd  = new Random().Next(minValue, maxValue+1);
    return rnd;
    }
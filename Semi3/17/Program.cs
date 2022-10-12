// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write ("Введите число X: ");
 int x = int.Parse(Console.ReadLine()!);

 Console.Write ("Введите число Y: ");
 int y = int.Parse(Console.ReadLine()!);

 if (x > 0 && y > 0)

 Console.Write( "Первая");

 
 if (x > 0 && y < 0)

 Console.Write( "Вторая");

 
 if (x < 0 && y < 0)

 Console.Write( "Третья");

 
 if (x < 0 && y > 0)

 Console.Write( "4");


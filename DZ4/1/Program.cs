// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter degree of number: ");
int degreeNumber = int.Parse(Console.ReadLine()!);
 
// double Degree(int a, int b) {
//     double result = Math.Pow(a,b);
//     return result;
// }
int Degree(int n, int dn) {
int product = 1;
if (n != 0) 
while (dn > 0) {
    product =product * n;
    dn--;
}

else 
product = 0;

return product;
}

Console. WriteLine($"Degree {degreeNumber} of number {number} = {Degree(number, degreeNumber)}");
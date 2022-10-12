Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i = 2;

if (N > 1) {
    while (i <= N) {    
     if (i == N || i +1 == N) {
           Console.Write(i);}     
     else {
          Console.Write(i + ", ");}
     i = i +2;
     }
}

else
{
     Console.Write("Введите верное число");
}
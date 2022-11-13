 

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());


EvNum(a);

int EvNum(int n)
{
    if(n==2) {
        Console.Write($"{n}, ");
        return n;}

    if(n%2 != 0) 
    {  
        Console.Write($"{--n}, ");
        return EvNum(n-2);
    }
    
    Console.Write($"{n}, ");
    return EvNum(n-2);
}
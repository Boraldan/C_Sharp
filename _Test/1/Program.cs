Person tom = new Person { name = "Tom", age = 22 };
 
tom.Print();    // Имя: Tom  Возраст: 22
 
struct Person
{
    public string name;
    public int age;
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}
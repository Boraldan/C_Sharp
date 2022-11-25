// Собрать строку с числами от a до b, a ≤ b  (2 варианта)

string NumbersFor(int a, int b)
{
string result = String.Empty;
for (int i = a; i <= b; i++)
{
result += $"{i} ";
}
return result;
}


string NumbersRec(int a, int b)
{
if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// ________________________________________________________________

// Собрать строку с числами от a до b, a ≥ b  (2 варианта)

string NumbersFor(int a, int b)
{
string result = String.Empty;
for (int i = a; i >= b; i--)
{
result += $"{i} ";
}
return result;
}

string NumbersRec(int a, int b)
{
if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

// ____________________________________________________________________

// Вычислить а в степени n  (3 варианта)

int PowerFor(int a, int n)
{ int result = 1;
for (int i = 1; i <= n; i++) result *= a;
return result;
}
int PowerRec(int a, int n)
{ return n == 0 ? 1 : PowerRec(a, n - 1) * a;
if (n == 0) return 1;
else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024

// ________________________________________________________________

// Перебор слов через циклы и рекурсию (2 варианта)

char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
for (int j = 0; j < count; j++)
{
for (int k = 0; k < count; k++)
{
for (int l = 0; l < count; l++)
{
for (int m = 0; m < count; m++)
{
Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
}
}
}
}
}

// это через рекурсию
void FindWords(string alphabet, char[] word, int length = 0)
{
if (length == word.Length)
{
Console.WriteLine($"{n++} {new String(word)}"); return;
}
for (int i = 0; i < alphabet.Length; i++)
{
word[length] = alphabet[i];
FindWords(alphabet, word, length + 1);
}
}

FindWords(“аисв”, new char[5]);


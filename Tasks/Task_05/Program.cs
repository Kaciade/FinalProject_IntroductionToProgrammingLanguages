// Написать программу возведения числа А в целую стень B

Console.Write("\nВведите число A: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int result = a;

for (int i = 1; i < b; i++)
{
    result = result * a;
}

Console.WriteLine($"\nA^B = {result}\n");
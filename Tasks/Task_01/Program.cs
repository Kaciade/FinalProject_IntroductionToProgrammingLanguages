// Показать натуральные числа от M до N, N и M заданы.

Console.Write("\nВведите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"\nПоследовательность натуральных чисел от {m} до {n}:");
while (m <= n)
{
    Console.Write($"{m}\t");
    m++;
}
Console.WriteLine("\n");
// Показать натуральные числа от M до N, N и M заданы.

Console.Write("\nВведите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
int m1 = m;

while (m1 <= n)
{
    count++;
    m1++;
}

m1 = m;
int [] matrix = new int [count];
for (int i = 0; i < matrix.Length; i++)
{
    if (m1 <= n)
    {
        matrix[i] = m1;
    }
    m1++;
}

Console.Write($"\nПоследовательность натуральных чисел от {m} до {n}:");
for (int i = 0; i < matrix.Length; i++)
{
    if (i % 13 == 0) Console.WriteLine();
    Console.Write($"{matrix[i]}\t");
}
Console.WriteLine("\n");
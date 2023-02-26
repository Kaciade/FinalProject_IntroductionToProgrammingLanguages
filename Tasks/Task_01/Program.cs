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

if (count % 10 != 0)
{
    while (count % 10 > 0) count++;
}

int m2 = m;
int [,] matrix = new int [count/10, 10];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (m2 <= n) matrix[i, j] = m2;
        else matrix[i, j] = 0;
        m2++;
    }
}

Console.WriteLine($"\nПоследовательность натуральных чисел от {m} до {n}:");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == 0 && i != 0 && j != 0) break;
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
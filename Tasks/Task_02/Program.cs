// Найти сумму элементов от M до N, N и M заданы

Console.Write("\nВведите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int result = 0;

for (int i = m; i <= n; i++)
{
    result += i;
}
Console.WriteLine($"\nСумма элементов от {m} до {n} = {result}\n");
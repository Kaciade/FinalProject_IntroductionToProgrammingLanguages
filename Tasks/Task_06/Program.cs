// Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

Console.Write("\nВведите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество чисел, которые нужно вывести: ");
int times = int.Parse(Console.ReadLine() ?? "0");

int k = 2;
int [] matrix = new int [times];
matrix[0] = m;
matrix[1] = n;
for (int i = 2; i < matrix.Length; i++)
{
    if (k < times)
    {
        matrix[i] = matrix[i-1] + matrix[i-2];
    }
    else matrix[i] = 0;
}

Console.WriteLine($"\nПолучившаяся последовательность:");

for (int i = 0; i < matrix.Length; i++)
{
    if (matrix[i] == 0 && i != 0) break;
    if (i % 13 == 0) Console.WriteLine();
    Console.Write($"{matrix[i]}\t");
}
Console.WriteLine();
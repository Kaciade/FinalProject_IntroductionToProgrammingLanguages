// Написать программу вычисления функции Аккермана

Console.Write("\nВведите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.WriteLine($"\nA({m},{n}) = {Akkerman(m, n)}\n");
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
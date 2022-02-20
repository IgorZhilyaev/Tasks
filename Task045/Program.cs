// Показать числа Фибоначчи.

double Fibonacci(int n)
{
    double temp;
    double a = 0;
    double b = 1;

    for (int i = 0; i < n; i++)
    {
        temp = a;
        a = b;
        b = temp + b;
    }
    return b;
}
double FibonacciRecursion(int n)
{
    if (n == 0 || n == 1)
        return 1;
    return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

Console.WriteLine($"Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Через цикл: {Fibonacci(n)}");
Console.WriteLine($"Через рекурсию: {FibonacciRecursion(n)}");

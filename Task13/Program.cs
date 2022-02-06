// Выяснить, кратно ли число заданному, если нет, вывести остаток

Console.WriteLine("Проверка кратности двух чисел");
Console.Write("Введите первое число: ");
string? aStr = Console.ReadLine();
int a = int.Parse(aStr);
Console.Write("Введите второе число число: ");
string? bStr = Console.ReadLine();
int b = int.Parse(bStr);

if (a < b)
{
    Console.Write("Первое число должно быть больше второго");
    return;
}

int p = a % b;

if (p == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток равен: " + p);
}
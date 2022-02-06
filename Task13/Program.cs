// Выяснить, кратно ли число заданному, если нет, вывести остаток

/*Console.WriteLine("Проверка кратности двух чисел");
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
}*/

int GetNumber()
{
    int randomNumber = new Random().Next(0, 100);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Первое случйное число {number}");

int secondNumber = GetNumber();
Console.WriteLine($"Второе случйное число {secondNumber}");

void IsMultiple(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        int result = firstNumber % secondNumber;
        if (result == 0)
            Console.WriteLine("Первое число кратно второму");
        else
            Console.WriteLine($"Числа не кратны, остаток равен {result}");
    }
    else
    {
        int result = secondNumber % firstNumber;
        if (result == 0)
            Console.WriteLine("Второе число кратно первому");
        else
            Console.WriteLine($"Числа не кратны, остаток равен {result}");
    }
}
IsMultiple(number, secondNumber);

// Определить сколько чисел больше 0 введено с клавиатуры.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

void PositivNumbersFromTheKeyboard(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x > 0)
            count++;
    }
    Console.WriteLine($"Положительных чисел: {count}");

}

int n = InPut("Введите количество чисел: ");
PositivNumbersFromTheKeyboard(n);
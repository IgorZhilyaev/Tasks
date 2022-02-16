// Подсчитать сумму цифр в числе.

int GetNumber()
{
    int randomNumber = new Random().Next(100, 1000000);
    return randomNumber;
}

int SumOfDigit(int num)
{
    int sum = 0;
    while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
        Console.Write($"Сумма цифр в числе: {sum}");
        return sum;
}

int num = GetNumber();
Console.WriteLine($"Сгенерированное число: {num}");
SumOfDigit(num);
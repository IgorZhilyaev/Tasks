// Написать программу вычисления произведения чисел от 1 до N.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

int Multiple(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    Console.WriteLine($"Произведения всех чисел до требуемой = {result}");
    return result;
}

int number = InPut("Введите число до которого хотите посчитать произведения чисел: ");
Multiple(number);
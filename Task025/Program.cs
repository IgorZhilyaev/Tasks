// Найти сумму чисел от 1 до А.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

int number = InPut("Введите число до которого хотите посчитать сумму: ");
int sum = 0;

for(int i = 1; i <= number; i++)
{
    sum +=i;
}
Console.WriteLine($"Сумма всех чисел до требуемой = {sum}");

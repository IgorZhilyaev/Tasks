// Написать программу преобразования десятичного числа в двоичное.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}
int k = 1;
int result = 0;
int numOst = 0;
int number = InPut("Введите число: ");
while (number != 0)
{
    
    numOst = number % 2;
    number = number / 2;
    result = result + numOst * k;
    k *=10;
}
Console.WriteLine($"В десятичном виде = {result}");
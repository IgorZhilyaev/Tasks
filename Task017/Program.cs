// По двум заданным числам проверять является ли одно квадратом другого

int InPut(string mess)
{
    Console.Write(mess);
    string? num = Console.ReadLine();
    int a = int.Parse(num);
    return a;
}

int numOne = InPut("Введите первое число: ");
int numTwo = InPut("Введите второе число: ");

if (numOne == numTwo * numTwo)
{
    Console.WriteLine($"{numOne} является квадратом {numTwo}");
}
else if (numTwo == numOne * numOne)
{
    Console.WriteLine($"{numTwo} является квадратом {numOne}");
}
else
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}

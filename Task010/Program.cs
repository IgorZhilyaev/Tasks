// Показать вторую цифру трёхзначного числа

int GetNumber()
{
    int randomNumber = new Random().Next(100, 999);
    return randomNumber;
}

int number = GetNumber();
Console.WriteLine($"Случайное трёхзначное число: {number}");

string numberStr = number.ToString();
Console.WriteLine($"Вторая цифра этого числа: {numberStr[1]}");



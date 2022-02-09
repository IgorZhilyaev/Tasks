// Удалить вторую цифру трёхзначного числа

int GetNumber()
{
    int randomNumber = new Random().Next(100, 999);
    return randomNumber;
}

int number = GetNumber();

Console.Write($"Случайое трёхзначное число: {number}");

string numberStr = number.ToString();

string numberRemove = numberStr.Remove(numberStr.Length - 2, 1);

Console.WriteLine();

Console.Write($"Число после удаления второй цифры: {numberRemove}");
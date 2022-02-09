// Показать последнюю цифру трёхзначного числа

int GetLastDigit(int number)
{
    return number % 10;
}

int GetIntFromConsole(int min, int max)
{
    int result = 0;
    bool isError = true;
    while(isError)
    {
        Console.Write($"Введите целое число в пределах от {min} до {max}: ");
        string input = Console.ReadLine();
        if(int.TryParse(input, out result)) 
        isError = result < min || result > max;
    }
    return result;
}

int number = GetIntFromConsole(100, 999);
int lastDigit = GetLastDigit(number);
Console.WriteLine(lastDigit);
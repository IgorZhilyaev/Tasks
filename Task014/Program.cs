// Найти третью цифру числа или сообщить, что её нет


Console.Write("Введите число:");

string valueStr = Console.ReadLine();

if (int.TryParse(valueStr, out int valueInt))
{
    string resultValue = valueInt.ToString();
    if (resultValue.Length >= 3)
        Console.WriteLine($"Третья цифра числа: {resultValue[2]}");
    else
        Console.WriteLine($"Число не трёхзначное");
}
else
    Console.WriteLine($"Ввели не число");

    // решение из семинара
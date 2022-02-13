// Программа проверяет пятизначное число на палиндромом.

int InPut(string mess)
{
    Console.Write(mess);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

int number = InPut("Введите пятизначное число: ");

bool valueOne = number % 10 == number / 10000;
bool valueTwo = (number % 100) / 10 == (number / 1000) % 10;

if (valueOne && valueTwo)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
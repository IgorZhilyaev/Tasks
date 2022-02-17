// Показать кубы чисел, заканчивающихся на четную цифру.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

void CubeOfLastEvenDigit(int num)
{ 
int lastDigit =  num % 10;

if(lastDigit % 2 == 0)
    {
        var cube = Math.Pow(num,3);
        Console.Write($"Куб числа = {cube}");
    }
    else
    {
        Console.Write("Число заканчивается не на чётную цифру.");
    }
}       

int num = InPut("Введите число: ");
CubeOfLastEvenDigit(num);


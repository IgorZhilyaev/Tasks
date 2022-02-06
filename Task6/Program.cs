// Выяснить, явлется ли число чётным

Random radomizer = new Random();
int number = radomizer.Next(1, 100);
Console.WriteLine("Сгенерированное число: " + number);

int ostatok = number % 2;

if (ostatok == 1) 
{
    Console.WriteLine("Это не чётное число");
}
else
{
    Console.WriteLine("Это чётное число");
}

// Задать номер четверти, показать диапазоны для возможных координат.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

void Execute(int x)
{
    if (x == 1)
        Console.WriteLine("Диапазон врзможных координат от [0.0] до [X.Y]");
    else if (x == 2)
        Console.WriteLine("Диапазон врзможных координат от [0.0] до [-X.Y]");
    else if (x == 3)
        Console.WriteLine("Диапазон врзможных координат от [0.0] до [-X.-Y]");
    else if (x == 4)
        Console.WriteLine("Диапазон врзможных координат от [0.0] до [X.-Y]");
    else 
        Console.WriteLine("Введено число больше 4 или 0");
    
}

int x = InPut("Введите номер четверти: ");


Execute(x); 

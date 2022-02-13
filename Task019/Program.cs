// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

int InPut(string mess)
{
    Console.Write(mess);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

void Execute(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Точка в I четверти");
    else if (x < 0 && y > 0)
        Console.WriteLine("Точка в II четверти");
    else if (x < 0 && y < 0)
        Console.WriteLine("Точка в III четверти");
    else if (x > 0 && y < 0)
        Console.WriteLine("Точка в IV четверти");
    else if (x== 0 || y == 0)
        Console.WriteLine("Одна из точек находится на оси координат");
    else
        Console.WriteLine("Точка начала координат");
}

int x = InPut("Введите координаты точки X: ");
int y = InPut("Введите координаты точки Y: ");

Execute(x, y);
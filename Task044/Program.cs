// Найти точку пересечения двух прямых заданных уравнением 
//y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}
int b1 = InPut("Введите точку b1: ");
int k1 = InPut("Введите точку k1: ");
int b2 = InPut("Введите точку b2: ");
int k2 = InPut("Введите точку b2: ");

void CrossLine(int a, int b, int c, int d)
{
var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых ({x},{y})");
}

CrossLine (b1, k1, b2, k2);






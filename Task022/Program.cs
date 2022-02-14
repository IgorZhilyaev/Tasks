// Найти расстояние между точками в пространстве 2D/3D.

int InPut(string mess)
{
    Console.Write(mess);
    string? num = Console.ReadLine();
    int a = int.Parse(num);
    return a;
}

void DistanceBetweenPoints2D(int x1, int y1, int x2, int y2)
{
    var a = (Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2));
    var b = Math.Sqrt(a);
    Console.WriteLine($"Расстояние между точками A({x1},{y1}) и B({x2},{y2}) = {b}");
}

void DistanceBetweenPoints3D(int x1, int y1, int z1, int x2, int y2,  int z2)
{
    var a = (Math.Pow((x2-x1),2))+(Math.Pow((y2-y1),2)+(Math.Pow((z2-z1),2)));
    var b = Math.Sqrt(a);
    Console.WriteLine($"Расстояние между точками A({x1},{y1},{z1}) и B({x2},{y2},{z2}) = {b}");
}

int x1 = InPut("Введите точку x1: ");
int y1 = InPut("Введите точку y1: ");
int z1 = InPut("Введите точку z1: ");
int x2 = InPut("Введите точку x2: ");
int y2 = InPut("Введите точку y2: ");
int z2 = InPut("Введите точку z2: ");

DistanceBetweenPoints2D(x1, y1, x2, y2);
DistanceBetweenPoints3D(x1, y1, z1, x2, y2,  z2);
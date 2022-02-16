// Возведите число А в натуральную степень B используя цикл.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

int APowB(int a, int b)
{
    int pow = 1;
    
    for(int i = 1; i <= b; i++)
    {
        pow *= a;
    }
    Console.WriteLine($"A в степени В = {pow}");
    return pow;
}

int a = InPut("A = ");
int b = InPut("B = ");
APowB(a,b);



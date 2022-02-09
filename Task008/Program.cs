// Показать четные числа от 1 до N


int n = 23;
int count = 1;

while (count <= n)
{
    if (count % 2 == 0)
        Console.WriteLine(count);
    count++;
}
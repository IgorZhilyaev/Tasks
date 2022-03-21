/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/


int m = 3;
int n = 6;

int sum = 0;

for (int i = m; i <= n; i++)
{
    sum = sum + i;
}

Console.WriteLine(sum);

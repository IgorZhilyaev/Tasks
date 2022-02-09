// Найти максимальное из трех чисел

/* 
int a = 34;
int b = 23;
int c = 46;
int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine("Максимальное число: " + max);*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 14, 114, 78 };

int max = Max(array[0], array[1], array[2]);

Console.WriteLine("Максимальное число: " + max);

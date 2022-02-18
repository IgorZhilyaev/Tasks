// Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива.

int[] array = new int[12];
int sumPol = 0;
int sumOtr = 0;

for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write($"{array[i]} ");

    if (array[i] > 0)
        sumPol += array[i];
    else
        sumOtr += array[i];
}

Console.WriteLine($"\nСумма положительных чисел равна = {sumPol}");
Console.WriteLine($"Сумма отрицатеоьных чисел равна = {sumOtr}");
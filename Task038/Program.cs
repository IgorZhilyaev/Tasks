// Найти сумму чисел одномерного массива стоящих на нечетной позиции.

int[] arr = new int[10];

void FillArray()
{
    Random number = new Random();
    Console.WriteLine("Массив заполненный случайными числами: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(0, 10);
        Console.Write($"{arr[i]} ");
    }

}

FillArray();

int sumNeChet = 0;
for (int i = 0; i < arr.Length; i=i+2)
{
    sumNeChet += arr[i];
}
Console.WriteLine($"\nСумма чисел стоящих на нечётной позиции = {sumNeChet}.");
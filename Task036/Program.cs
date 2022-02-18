// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел.

int[] arr = new int[10];

void FillArray()
{
    Random number = new Random();
    Console.WriteLine("Массив заполненный случайными трёхзначными числами: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }

}

FillArray();

int chet = 0;
int neChet = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
        chet++;
    else
        neChet++;
}
Console.WriteLine($"\nВ этом массиве {chet} чётных, и {neChet} нечётных чисел.");

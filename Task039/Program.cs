// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] arr = new int[10];

void FillArray()
{
    Random number = new Random();
    Console.WriteLine("Массив заполненный случайными числами: ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 10);
        Console.Write($"{arr[i]} ");
    }
    
}

FillArray();

int mult = 0;
for (int i = 0; i <= (arr.Length-1) / 2; i++)
{
    mult += arr[i] * arr[arr.Length - 1 - i];
}
Console.WriteLine($"\nПроизведение пар чисел массива = {mult}");
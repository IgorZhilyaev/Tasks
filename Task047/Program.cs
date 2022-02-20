// Написать программу копирования массива.

int InPut(string message)
{
    Console.Write(message);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

int[] ArrayInit(int num)
{
    int[] array = new int[num];
    Random randomNum = new Random();

    for (int i = 0; i < num; i++)
    {
        array[i] = randomNum.Next(0, 10);
    }
    return array;
}

void ArrayPrint(int[] arr)
{
    Console.Write("Полученный массив: ");

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] CopyArray(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    Console.Write("Скопированынй массив: ");
    for (int i = 0; i < arr.Length; i++)  
    {
        copyArray[i] = arr[i];
        Console.Write($"{copyArray[i]} ");
    }
    return copyArray;
}

int number = InPut("Введите размер массива: ");
int[] firstArray = ArrayInit(number);
ArrayPrint(firstArray);
Console.WriteLine();
CopyArray(firstArray);

//Копирование массива стандартными средствами.

Console.WriteLine();

int[] array = new int[5] {1, 2, 3, 4, 5};
int[] copiedArr = new int[5];


Array.Copy(array, copiedArr, array.Length);

foreach (var item in array)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

foreach (var item in copiedArr)
{
    Console.Write($"{item} ");
}

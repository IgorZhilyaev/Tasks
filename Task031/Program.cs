// Задать массив из 8 элементов и вывести их на экран.

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
    
    for(int i = 0; i < num; i++)
    {
        array[i] = randomNum.Next(1,10);
    }
    return array;
}

void ArrayPrint(int[] array)
{
    Console.Write("Полученный массив: ");
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int getInt = InPut("Введите размер задаваемого массива: ");
int[] array = ArrayInit(getInt);
ArrayPrint(array);
// Показать таблицу квадратов чисел от 1 до N.

int InPut(string mess)
{
    Console.Write(mess);
    string? num = Console.ReadLine();
    return int.Parse(num);
}

int[] InitArray(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int n = InPut("Введите число больше 1: ");

var array = InitArray(n);

PrintArray(array);


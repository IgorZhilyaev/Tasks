// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = { "hello", "hi", "world", "cat", "123546", "2898", ":-)" };

string[] newArray = new string[array.Length];

string[] ArrayLessThreeSymbol(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];

        if (str.Length <= 3)
        {
            newArray[count] = str;
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine("Исходный массив: ");
PrintArray(array);
ArrayLessThreeSymbol(array);
Console.WriteLine("Полученный массив: ");
PrintArray(newArray);

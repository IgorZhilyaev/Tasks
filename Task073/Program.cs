/* Написать программу показывающие первые N чисел, для которых каждое следующее 
равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем.*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            checkStatus = false;
            break;
        }
        else
            Console.WriteLine("Ввели не число.");
    }
    return numberInt;
}

int n = GetNumber("Введите количество чисел: ");
int firstNumber = GetNumber("Введите первое число: ");
int secondNumber = GetNumber("Введите второе число: ");

int result = firstNumber + secondNumber;

Console.Write($"{firstNumber} ");
Console.Write($"{secondNumber} ");

for (int i = 0; i < n; i++)
{
    result = firstNumber + secondNumber;
    Console.Write($"{result} ");
    firstNumber = secondNumber;
    secondNumber = result;
}


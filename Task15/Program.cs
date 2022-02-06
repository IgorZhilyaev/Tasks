// Дано число. Проверить кратно ли оно 7 и 23

int number = 161;

bool CheckOfModed(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

if (CheckOfModed(number))
    Console.WriteLine($"Число {number} кратно 7 и 23");
else
    Console.WriteLine($"Число {number}  не кратно 7 и 23");
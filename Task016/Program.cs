// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


int GetNumber()
{
    int randomNumber = new Random().Next(1, 8);
    return randomNumber;
}

string[] dayOfWeek = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

int number = GetNumber();

if(number == 6 || number == 7)
    Console.WriteLine($"{number}-й день недели {dayOfWeek[number-1]}, это выходной день.");
else
    Console.WriteLine($"{number}-й день недели {dayOfWeek[number-1]}, это будний день.");


// // Вывести квадрат числа
Console.Write("Введите число-> "); // выводим на консоль сообщение
string? namberStr = Console.ReadLine(); // вводим строковую переменную 
int namber = int.Parse(namberStr); // преобразуем строковую переменную в int
Console.WriteLine($"Квадрат числа: {namber * namber}"); //Console.WriteLine("Квадрат числа: " + namber * namber);

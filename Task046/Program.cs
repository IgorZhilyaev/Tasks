// Написать программу масштабирования фигуры

string strValue = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель: ");
int k = int.Parse(Console.ReadLine());

strValue = strValue.Replace("(", "").Replace(")","").Replace(","," ");

string[] strArray = strValue.Split(" "); // Разбираем строку на массив, разделитель " ".

string result = string.Empty;

foreach (var item in strArray)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

for (int i = 0; i < strArray.Length; i=i+2)
{
    int x = k * int.Parse(strArray[i]);
    int y = k * int.Parse(strArray[i+1]);

    Console.WriteLine($"X = {x}, Y = {y}");

    result = result + $"({x}, {y}) ";
}

Console.WriteLine();
Console.WriteLine(result);

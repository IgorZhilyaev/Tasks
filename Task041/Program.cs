// Выяснить являются ли три числа сторонами треугольника.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других строн.

int GetNumber()
{
    int randomNumber = new Random().Next(1, 100);
    return randomNumber;
}

bool ThreeNumSideOfTriangle(int a, int b, int c)
{
    return a < (b + c);
}

int numOne = GetNumber();
int numTwo = GetNumber();
int numThree = GetNumber();

Console.WriteLine($"Первое число {numOne}, второе число {numTwo}, третье число {numThree}.");

if (ThreeNumSideOfTriangle(numOne, numTwo, numThree)
&& ThreeNumSideOfTriangle(numTwo, numOne, numThree)
&& ThreeNumSideOfTriangle(numThree, numOne, numTwo))
    Console.WriteLine("Числа являются сторонами сторонами треугольнтка");
else
    Console.WriteLine("Числа не являются сторонами сторонами треугольнтка");



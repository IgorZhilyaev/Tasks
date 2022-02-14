// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.

void Bool(bool x, bool y)
{
    bool a = !(x || y) == (!x && !y);
    Console.WriteLine($"При X = {x}, Y = {y} утверждение принимает значание: {a}");
}

Bool(false, false);
Bool(false, true);
Bool(true, false);
Bool(true, true);
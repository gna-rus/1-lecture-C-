
Console.Clear();
int xa = 40, ya = 1;
int xb = 1, yb = 40;
int xc = 90, yc = 40;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("o");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("o");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("o");

int value1 = 0;
int x = xa, y = ya;
while (value1 < 10000)
{
    int what = new Random().Next(0, 3);

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("o");
    value1 += 1;
}

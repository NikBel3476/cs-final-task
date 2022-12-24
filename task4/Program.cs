using task4;

Point center = new Point(0, -1);
int radius = 2;
double x = 0;
double y = 0;

Console.WriteLine("Введите координату X");
while (true)
{
    if (double.TryParse(Console.ReadLine(), out var number))
    {
        x = number;
        break;
    }
    Console.WriteLine("Введено неверное значение, повторите ввод");
}

Console.WriteLine("Введите координату Y");
while (true)
{
    if (double.TryParse(Console.ReadLine(), out var number))
    {
        y = number;
        break;
    }
    Console.WriteLine("Введено неверное значение, повторите ввод");
}

Point point = new Point(x, y);
Console.WriteLine(
    $"Точка ({x};{y}) {(center.DistanceTo(point) <= 2 ? "" : "не")} лежит внутри круга"
);
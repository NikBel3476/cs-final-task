using task1;

Console.WriteLine("Введите число от 0 до 10000 включительно");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out var number))
    {
        if (number is > 0 and <= 10000)
        {
            Console.WriteLine($"Число {number} {(MathService.IsPrime(number) ? "простое!" : "не является простым")}");
            break;   
        }
        Console.WriteLine("Число не должно быть меньше 0 или больше 10000, повторите ввод");
        continue;
    }
    
    Console.WriteLine("Введено неверное значение, повторите ввод");
}
using task2;

Console.WriteLine("Введите год в формате YYYY");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out var number))
    {
        if (number is >= 1000 and <= 9999)
        {
            Console.WriteLine(
                $"{number} год {(LeapYearService.IsLeapYear(number) ? "- високосный" : "не является високосным")}"
            );
            break;   
        }
        Console.WriteLine("Год не должен быть меньше 1000 или больше 9999, повторите ввод");
        continue;
    }
    
    Console.WriteLine("Введено неверное значение, повторите ввод");
}
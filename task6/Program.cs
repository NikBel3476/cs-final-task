using task6;

try
{
    var array = File.ReadAllText("../../../test.txt").Split(',');

    Console.WriteLine("Неотсортированный массив:");
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
    
    var sortedArray = SortService.Sort(array);

    Console.WriteLine("Отсортированный массив:");
    foreach (var item in sortedArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
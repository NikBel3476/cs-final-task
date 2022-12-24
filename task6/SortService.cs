namespace task6;

public static class SortService
{
    public static string[] Sort(string[] array)
    {
        if (array.Length < 2)
        {
            return array;
        }
        
        var pivot = 0;
        var less = array.Where((s, i) =>
            i != pivot && s.CompareTo(array[pivot]) < 0).ToArray();
        var greaterOrEqual = array.Where((s, i) =>
            i != pivot && s.CompareTo(array[pivot]) >= 0).ToArray();
        
        return Sort(less).Concat(new string[] { array[pivot] }).Concat(Sort(greaterOrEqual)).ToArray();
    }
}
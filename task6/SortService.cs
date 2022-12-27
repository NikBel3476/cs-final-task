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
            i != pivot && String.Compare(s, array[pivot], StringComparison.Ordinal) < 0).ToArray();
        var greaterOrEqual = array.Where((s, i) =>
            i != pivot && String.Compare(s, array[pivot], StringComparison.Ordinal) >= 0).ToArray();
        
        return Sort(less).Concat(new string[] { array[pivot] }).Concat(Sort(greaterOrEqual)).ToArray();
    }

    /*public static string[] Sort2(string[] s)
    {
        if (s.Length < 2) { return s; }
        string p = s[0];
        return Sort2(s.Where(x => x.CompareTo(p) < 0).ToArray())
            .Concat(s.Where(x => x.CompareTo(p) == 0))
            .Concat(Sort2(s.Where(x => x.CompareTo(p) > 0).ToArray()))
            .ToArray();
    }*/
}
namespace task2;

public static class LeapYearService
{
    public static bool IsLeapYear(int year)
    {
        return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
    }
}
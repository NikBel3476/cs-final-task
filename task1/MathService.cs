namespace task1;

public static class MathService
{
    public static bool IsPrime(int number)
    {
        if (number == 0 || number == 1)
            return false;

        if (number == 2)
            return true;

        for (uint i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }   
}
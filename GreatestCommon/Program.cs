static int GreatestCommonFactor(int a, int b)
{
    int result = 0;

    for (int i = 1; i <= Math.Max(a,b); i++)
    {
        if(a % i == 0 && b % i == 0)
            result = i;
    }

        return result;
}
    
Console.WriteLine(GreatestCommonFactor(24,36));

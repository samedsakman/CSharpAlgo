int FirstFactorial (int num)
{
    for (int i = num -1; i > 0; i--)
    {
        num *= i;
    }

    return num;
}

Console.WriteLine(FirstFactorial(int.Parse(Console.ReadLine())));
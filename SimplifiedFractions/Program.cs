using System;
using System.Linq;

// Create a function that returns the simplified version of a fraction.

string Simplify (int num1, int num2)
{
    if(num1 % num2 == 0)
        return $"Simplified Fractions: {num1 / num2}";
    else
    {
        for(int i = 1; i <= Math.Max(num1, num2); )
        {
            while(num1 % i == 0 && num2 % i == 0)
            {
                num1 /= i;
                num2 /= i;
                break;
            }

            i++;
        }
        return $"Simplified Fractions: {num1}/{num2}";
    }
}

Console.WriteLine("Input 2 numbers:");
Console.WriteLine(Simplify(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

/* A briefcase has a 4-digit rolling-lock. Each digit is a number from 0-9 that can be rolled either forwards or backwards. Create a function that returns the smallest number of turns it takes to transform the lock from the current combination to the target combination. One turn is equivalent to rolling a number forwards or backwards by one */

int MinTurns (string current, string target)
{
    int minTurns = 0; //Variable to count the Minimum Turn

    for (int i = 0; i < current.Length; i++)
    {
        int forward = 0;
        int backward = 0;

        for (int j = int.Parse(Convert.ToString(current[i])); j <= 9; j++) //Forward counter
        {
            if(j == int.Parse(Convert.ToString(target[i])))
                break;
            else if (j == 9)
                j = -1;
            forward++; 
        }

        for (int j = int.Parse(Convert.ToString(current[i])); j >= 0; j--) //Backward counter
        {
            if(j == int.Parse(Convert.ToString(target[i])))
                break;
            else if(j == 0)
                j = 10;
            backward++;
        }

        minTurns += Math.Min(forward, backward); //Find the minimum number between forward and backward
        
    }

    return minTurns;
}

Console.WriteLine(MinTurns("1111","1100"));

/* A briefcase has a 4-digit rolling-lock. Each digit is a number from 0-9 that can be rolled either forwards or backwards. Create a function that returns the smallest number of turns it takes to transform the lock from the current combination to the target combination. One turn is equivalent to rolling a number forwards or backwards by one */

int Lock (int x, int y)
{
    int[] xArray = new int[Convert.ToString(x).Length];
    int[] yArray = new int[Convert.ToString(y).Length]; //Creating array for conversion

    int minTurns = 0; //Variable to count the Minimum Turn

    for (int i = 0; i < xArray.Length; i++)
    {
        xArray[i] = Convert.ToInt32(Convert.ToString(Convert.ToString(x)[i]));
        yArray[i] = Convert.ToInt32(Convert.ToString(Convert.ToString(y)[i])); 
        int forward = 0;
        int backward = 0;

        for (int j = xArray[i]; j <= 9; j++) //Forward counter
        {
            if(j == yArray[i])
                break;
            else if (j == 9)
                j = 0;
            forward++; 
        }

        for (int j = xArray[i]; j >= 0; j--) //Backward counter
        {
            if(j == yArray[i])
                break;
            else if(j == 0)
                j = 10;
            backward++;
        }

        minTurns += Math.Min(forward, backward); //Find the minimum number between forward and backward
        
    }

    return minTurns;
}

Console.WriteLine(Lock(2391,4984));

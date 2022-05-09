//Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.

int[] IndexOfCapitals (string str)
{
    int counter = 0;
    string indexes = "";

    for (int i = 0; i < str.Length; i++)
    {
        if (Char.IsUpper(str[i]))
        {
            counter++;

            if (!indexes.Contains(str[i]))
            {
               indexes += i;
            }
        }

    }

    int[] strArray = new int[counter];

    for (int i = 0; i < counter; i++)
    {
        strArray[i] = Convert.ToInt32(Convert.ToString(indexes[i]));
    }

    return strArray;
}

Console.WriteLine(IndexOfCapitals("sAmEdSaKmAn"));
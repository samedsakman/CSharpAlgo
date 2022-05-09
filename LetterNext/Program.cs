// Replace only letters of the characters in the input text with the next letter in the alphabet. If there are vowels, capitalize them.

static string LetterNext(string str)
{
    string letter = "";
    
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] >= 97 && str[i] < 122)
        {
            letter += Convert.ToChar(str[i] + 1);
        }
        else if (str[i] == 122)
        {
            letter += Convert.ToChar(97);
        }
        else
        {
            letter += str[i];
        }

        if (letter[i] == 'a' || letter[i] == 'e' || letter[i] == 'i' || letter[i] == 'o' || letter[i] == 'u')
        {
            letter = letter.Replace(letter[i], Convert.ToChar(Convert.ToString(letter[i]).ToUpper()));
        }
    }

    return letter;
    
}

Console.WriteLine(LetterNext(Console.ReadLine()));
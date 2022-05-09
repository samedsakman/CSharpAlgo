//  Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

 static string ReverseCase(string str) 
    {
			string newStr = "";
			
			for (int i = 0; i < str.Length; i++)
			{
				if(Convert.ToInt32(str[i]) >= 97 && Convert.ToInt32(str[i]) <= 122)
				{
					newStr += Convert.ToChar(Convert.ToInt32(str[i]) - 32);
				} else if (Convert.ToInt32(str[i]) >= 65 && Convert.ToInt32(str[i]) <= 90)
				{
					newStr += Convert.ToChar(Convert.ToInt32(str[i]) + 32);
				} else
				{
					newStr += str[i];
				}
			}
			
			return newStr;

    }
Console.WriteLine(ReverseCase("heLLo World"));
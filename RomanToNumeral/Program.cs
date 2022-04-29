using System;

namespace RomenToNumeral
{
    class RomenToNumeral
    {

        static void Main(string[] args)
        {
            string firstDigit = "";
            string secondDigit = "";
            string thirdDigit = "";
            string fourthDigit = "";
            int quotient = 0;
            int remainer = 0;


            string OneDigitConverter(string num)
            {

                if (int.Parse(Convert.ToString(num)) > 0 && int.Parse(Convert.ToString(num)) < 4)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num[0])), 1, out remainer);
                    for (int j = 0; j < quotient; j++)
                    {
                        firstDigit += "I";
                    }
                }
                else if (int.Parse(Convert.ToString(num)) == 4)
                {
                    firstDigit = "IV";

                }
                else if (int.Parse(Convert.ToString(num)) > 4 && int.Parse(Convert.ToString(num)) < 9)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num[0])), 5, out remainer);
                    for (int j = 0; j < quotient; j++)
                    {
                        firstDigit += "V";

                        for (int l = 0; l < remainer; l++)
                        {
                            firstDigit += "I";
                        }
                    }
                }
                else if (int.Parse(num) == 9)
                {
                    firstDigit = "IX";
                }

                return firstDigit;
            }

            string TwoDigitConverter(string num)
            {

                if (int.Parse(Convert.ToString(num)) >= 0 && int.Parse(Convert.ToString(num)) < 4)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num)), 1, out remainer);

                    for (int j = 0; j < quotient; j++)
                    {
                        secondDigit += "X";
                    }
                }
                else if (int.Parse(Convert.ToString(num)) == 4)
                {
                    secondDigit = "XL";
                }
                else if (int.Parse(Convert.ToString(num)) > 4 && int.Parse(Convert.ToString(num)) < 9)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num)), 5, out remainer);
                    for (int i = 0; i < quotient; i++)
                    {
                        secondDigit += "L";
                        for (int l = 0; l < remainer; l++)
                        {
                            secondDigit += "X";
                        }
                    }
                }
                else if (int.Parse(Convert.ToString(num)) == 9)

                    secondDigit = "XC";

                return secondDigit;
            }

            string ThreeDigitConverter(string num)
            {
                if (int.Parse(Convert.ToString(num)) > 0 && int.Parse(Convert.ToString(num)) < 4)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num)), 1, out remainer);

                    for (int i = 0; i < quotient; i++)
                    {
                        thirdDigit += "C";
                    }

                }
                else if (int.Parse(Convert.ToString(num)) == 4)

                    thirdDigit = "CD";

                else if (int.Parse(Convert.ToString(num)) > 4 && int.Parse(Convert.ToString(num)) < 9)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num)), 5, out remainer);

                    for (int i = 0; i < quotient; i++)
                    {
                        thirdDigit += "D";

                        for (int l = 0; l < remainer; l++)
                        {
                            thirdDigit += "C";
                        }
                    }
                }
                else if (int.Parse(Convert.ToString(num)) == 9)

                    thirdDigit = "CM";

                return thirdDigit;
            }

            string FourDigitConverter(string num)
            {
                if(int.Parse(Convert.ToString(num)) > 0 && int.Parse(Convert.ToString(num)) < 4)
                {
                    quotient = Math.DivRem(int.Parse(Convert.ToString(num)), 1, out remainer);

                    for (int i = 0; i < quotient; i++)
                    {
                        fourthDigit += "M";
                    }
                }

                return fourthDigit;
            }

            Console.WriteLine("Please give me a number to convert Romen Numerals");

            string num = Console.ReadLine();


            if((int.Parse(num) > 0 && int.Parse(num) < 4000))
            {
                if (num.Length == 1)
                {
                    firstDigit = OneDigitConverter(num);
                    Console.WriteLine(firstDigit);

                }
                else if (num.Length == 2)
                {
                    secondDigit = TwoDigitConverter(Convert.ToString(num[0]));
                    firstDigit = OneDigitConverter(Convert.ToString(num[1]));
                    Console.WriteLine(secondDigit + firstDigit);

                }
                else if (num.Length == 3)
                {
                    thirdDigit = ThreeDigitConverter(Convert.ToString(num[0]));
                    secondDigit = TwoDigitConverter(Convert.ToString(num[1]));
                    firstDigit = OneDigitConverter(Convert.ToString(num[2]));
                    Console.WriteLine(thirdDigit + secondDigit + firstDigit);

                }
                else if (num.Length == 4)
                {
                    fourthDigit = FourDigitConverter(Convert.ToString(num[0]));
                    thirdDigit = ThreeDigitConverter(Convert.ToString(num[1]));
                    secondDigit = TwoDigitConverter(Convert.ToString(num[2]));
                    firstDigit = OneDigitConverter(Convert.ToString(num[3]));
                    Console.WriteLine(fourthDigit + thirdDigit + secondDigit + firstDigit);
                }
                

            } else
            {
                Console.WriteLine("Please write a number between 1 and 3999");
            }
        }
    }
}


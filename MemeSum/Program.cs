using System;

namespace MemeSum
{
    class Program
    {
        /* MemeSum(26, 39) ➞ 515
        // 2+3 = 5, 6+9 = 15
        // 26 + 39 = 515

        MemeSum(122, 81) ➞ 1103
        // 1+0 = 1, 2+8 = 10, 2+1 = 3
        // 122 + 81 = 1103

        MemeSum(1222, 30277) ➞ 31499 */
        public static int MemeSum(int a, int b)
        {
            int arraylength = 0;
            string dumyA = "";
            string dumyB = "";
            string result = "";

            if (Convert.ToString(a).Length < Convert.ToString(b).Length)
            {
               arraylength = Convert.ToString(b).Length;

                for (int i = 0; i < (Convert.ToString(b).Length - Convert.ToString(a).Length); i++)
                {
                    dumyA += Convert.ToString(a).Insert(i, "0");
                }

                dumyB = Convert.ToString(b);
            }    

            else if (Convert.ToString(a).Length == Convert.ToString(b).Length)
            {
                arraylength = Convert.ToString(b).Length;
                dumyA = Convert.ToString(a);
                dumyB = Convert.ToString(b);
            }
                

            else
            {
                arraylength = Convert.ToString(a).Length;

                for (int i = 0; i < (Convert.ToString(a).Length - Convert.ToString(b).Length); i++)
                {
                    dumyB += Convert.ToString(b).Insert(i,"0");
                }

                dumyA = Convert.ToString(a);
            }

            for (int i = 0; i < arraylength; i++)
            {
                result += int.Parse(Convert.ToString(Convert.ToString(dumyA)[i])) + int.Parse(Convert.ToString(Convert.ToString(dumyB)[i]));

            }


            return Convert.ToInt32(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MemeSum(49999,49999));
        }
    }
}


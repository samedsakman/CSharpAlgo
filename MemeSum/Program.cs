using System;

namespace MemeSum
{
    class Program
    {
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


namespace MinimumAbsoluteDifferenceInAnArray
{
    internal class Program
    {
        static int MinAbs (int[] arr)
        {
            List<int> minArr = new List<int>();
            
            for (int i = 0; i < arr.Length -1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {  
                   minArr.Add(Math.Abs(arr[i] - arr[j]));
                } 
            }

            return minArr.Min();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the array length");
            int[] arr = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Please input the numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Minimim absolute value is " + MinAbs(arr).ToString());

        }
    }
}
//Take an array of integers(positive or negative or both) and return the sum of the absolute value of each element.

static int GetAbsSum(int[] arr)
{
   int result = 0;
   for (int i = 0; i < arr.Length; i++)
   {
        result += arr[Math.Abs(i)];
   }
    return result;
}

Console.WriteLine("How many numbers do you want in your int array?");
int number = int.Parse(Console.ReadLine());
int[] numberArray = new int[number];

Console.WriteLine($"Please input {number} numbers");

for(int i = 0; i < number; i++)
{
    Console.WriteLine($"Array index number:{i}");
    numberArray[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Absolute sum of your array is: {GetAbsSum(numberArray)}");
using System;

namespace leftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < num; i++)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                leftSum += leftNumber;
            }
            for (int i = 0; i < num; i++)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                rightSum += rightNumber;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}

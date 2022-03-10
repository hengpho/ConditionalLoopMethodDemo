using System;

namespace ConditionalLoopMethodDemo
{
    class MainClass
    {
        static void Main()
        {
            // TODO: Ask the user for the initial number
            // TODO: Ask the user for the target
            // TODO: Ask the user for the range
            // TODO: Write the result by calling IsWithinRange
            Console.Write("What is the initial number: ");
            int startingNum = int.Parse(Console.ReadLine());
            Console.Write("What is the target: ");
            int targetNum = int.Parse(Console.ReadLine());
            Console.Write("What is the range: ");
            int range = int.Parse(Console.ReadLine());

            Console.WriteLine($"Given a starting number of: {startingNum} and a target number: {targetNum}. It's {IsWithinRange(startingNum, targetNum, range)}");

        }

        //access modifier - static (or not) - return type - name(params in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            //make sure the return type is bool like we declared above, cannot return "hello" etc.
            return (num - target) <= range;
        }
    }
}
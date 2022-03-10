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

            //turnary - if it meets requirements ? true do this : false do this;
            string results = IsWithinRange(startingNum, targetNum, range) ? "Its within range." : "It's not within range.";
            Console.WriteLine($"Given a starting number of: {startingNum} and a target number: {targetNum}. {results}");

            //Console.WriteLine($"Given a starting number of: {startingNum} and a target number: {targetNum}. It's {IsWithinRange(startingNum, targetNum, range)}");

        }

        //access modifier - static (or not) - return type - name(params in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            //make sure the return type is bool like we declared above, cannot return "hello" which is a string etc.
            return (num - target) <= range && (num - target) >= -range;
        }
    }
}


/* Once inside the Directory to start
 * git init (initiate, will see (master) in console)
 * git status (show status of files)
 * touch .gitignore (Creates a .gitignore file - if .gitignore file does not exist, paste content from sources into .gitignore)
 * git add . (add all within directory)
 * git commit -m "Initial commit" (for first commit, change name to what was updated) 
 * git log (show all past commits in a log)
 */
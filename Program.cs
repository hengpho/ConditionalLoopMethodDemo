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

            Console.Write("Do we have power? (y/n): ");
            bool hasPower = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Do we have paper? (y/n): ");
            bool hasPaper = Console.ReadLine().ToUpper() == "Y";

            Console.Write("What is the ink level?: ");
            int inkLevel = int.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);

            

        }

        //access modifier - static (or not) - return type - name(params in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            //make sure the return type is bool like we declared above, cannot return "hello" which is a string etc.
            return (num - target) <= range && (num - target) >= -range;
        }

        //TODO: Print a document has Power, hasPaper and the ink level >= 10;
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            //void - we are not returning anything
            string result = hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print";
            Console.Write(result);

            //Console.Write(hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print"); --- Another way to write it
        }
    }
}


/* 
 * cd (goto home)
 * pwd (show working directory, the folder you are in - Print Working Directory)
 * ls (list all files in the current directory)
 * cd Destination (example - cd projects - it will enter projects)
 * -- Once inside the Directory to start
 * git init (initiate, will see (master) in console)
 * git status (show status of files)
 * touch .gitignore (Creates a .gitignore file - if .gitignore file does not exist, paste content from sources into .gitignore)
 * git add . (add all within directory)
 * git commit -m "Initial commit" (for first commit, change name to what was updated) 
 * git log (show all past commits in a log)
 */
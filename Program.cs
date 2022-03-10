using System;

namespace ConditionalLoopMethodDemo
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Do we have power? (y/n): ");
            bool hasPower = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Do we have paper? (y/n): ");
            bool hasPaper = Console.ReadLine().ToUpper() == "Y";

            int inkLevel = PromptUser4Int("What's the ink level?: ");

            PrintDoc(hasPower, hasPaper, inkLevel);

            

        }
        //TODO: Print a document has Power, hasPaper and the ink level >= 10;
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            //void - we are not returning anything
         //   string result = hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print";
          //  Console.Write(result);

            //Console.Write(hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print"); --- Another way to write it
        }
        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static int PromptUser4Int(string message)
        {
            //TODO: While the user's input is not parse-able as an int, continue to ask them to comply.
            int result;
            while (!int.TryParse(PromptUser(message), out result))
            {
                PromptUser("Invalid Input! Press any key to continue");
            }
            return result;
                    
        
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
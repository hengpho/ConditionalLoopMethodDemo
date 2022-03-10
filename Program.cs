using System;

namespace ConditionalLoopMethodDemo
{
    class MainClass
    {
        static void Main()
        {
        

        }

        //access modifier - static (or not) - return type - name(params in here)
        private static bool IsWithinRange(int num, int target, int range)
        {
            //make sure the return type is bool like we declared above, cannot return "hello" etc.
            return (num - target) <= range;
        }
    }
}
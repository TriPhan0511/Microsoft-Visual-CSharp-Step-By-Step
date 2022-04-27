using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run();
            
        }

        void Run()
        {
            Console.WriteLine($"Sum of all integers 1 through 20 that are divisible by 3: {Sum(1, 20)}");
        }

        // Find the sum of all integers 1 through 20 that are divisible by 3.
        private int Sum(int low, int high)
        {
            int result = 0;
            for (int i = low; i <= high; i++)
            {
                if (i % 3 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}

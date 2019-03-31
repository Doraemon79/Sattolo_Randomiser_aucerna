using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcons
{
    class Program
    {
        static 
            void Method(out int answer, out string message, out string stillNull)
        {
            answer = 44;
            message = "I've been returned";
            stillNull == null;
        }



        static void Main(string[] args)
        {
            int argNumber;
            string argMessage, argDefault;
            Method(out argNumber, out argMessage, out argDefault);
            Console.WriteLine(argNumber);
            Console.WriteLine(argMessage);
            Console.WriteLine(argDefault == null);


            Console.ReadKey();

        }

        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int i = 1;
            int result = 0;
            bool isFound = false;
            while(i < 100000 || isFound != true)
        {
                if (!A.Contains(i))
                    result = i;
                isFound = true;
                i++;
            }
        }
    }
}

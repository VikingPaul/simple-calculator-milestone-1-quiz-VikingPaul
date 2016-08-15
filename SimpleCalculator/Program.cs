using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playProgram = true;
            int numOfExpressions = 0;
            while(playProgram)
            {
                Console.Write("[" + numOfExpressions + "]>");
                string newCommand = Console.ReadLine().ToLower();
                numOfExpressions++;
                switch (newCommand)
                {
                    case "quit":
                        playProgram = false;
                        break;
                    case "exit":
                        playProgram = false;
                        break;
                    case "last":
                        break;
                    case "lastq":
                        break;
                    default:
                        break;
                }
                    
            }
        }
    }
}

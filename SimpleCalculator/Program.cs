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
            Stack GetSetLast = new Stack();
            bool playProgram = true;
            int numOfExpressions = 0;
            while(playProgram)
            {
                string whiteSpace = "";
                if (numOfExpressions > 99)
                {
                    whiteSpace = "     ";
                }
                else if (numOfExpressions > 9)
                {
                    whiteSpace = "    ";
                }
                else
                {
                    whiteSpace = "   ";
                }
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
                        Console.WriteLine(whiteSpace + GetSetLast.LastAnswer);
                        break;
                    case "lastq":
                        Console.WriteLine(whiteSpace + GetSetLast.LastQuestion);
                        break;
                    default:
                        string[] trueExpression = new Expression(newCommand).getArray();
                        if (trueExpression[0] == "false")
                        {
                            Console.WriteLine(whiteSpace + "Invalid");
                        }
                        else
                        {
                            int ans = new Maths(int.Parse(trueExpression[1]), trueExpression[2], int.Parse(trueExpression[3])).Answer();
                            GetSetLast.LastAnswer = ans.ToString();
                            GetSetLast.LastQuestion = newCommand;
                            Console.WriteLine(whiteSpace + "=" + ans.ToString());
                        }
                        break;
                }
                    
            }
        }
    }
}

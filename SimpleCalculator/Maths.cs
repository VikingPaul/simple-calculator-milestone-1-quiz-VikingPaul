using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Maths
    {
        int answer;
        public Maths(int first, string thing, int second)
        {
            switch(thing)
            {
                case "+":
                    answer = first + second;
                    break;
                case "-":
                    answer = first - second;
                    break;
                case "*":
                    answer = first * second;
                    break;
                case "/":
                    answer = first / second;
                    break;
                case "%":
                    answer = first % second;
                    break;
                default:
                    break;
            }
        }
        public int Answer()
        {
            return answer;
        }
    }
}

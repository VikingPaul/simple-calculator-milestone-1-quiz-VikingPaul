using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        string[] array = new string[0];
        public Expression(string expression)
        {
            string pattern = "(\\d*)\\s?(\\+?\\-?\\/?\\*?)\\s?(\\d*)";
            array = Regex.Split(expression, pattern);
            array[0] = "true";
            try
            {
                int first = int.Parse(array[1]);
            }
            catch (FormatException)
            {
                
                array[0] = "false";
            }
            try
            {
                int second = int.Parse(array[3]);
            }
            catch (FormatException)
            {
                array[0] = "false";
            }
        }
        public string[] getArray()
        {
            return array;
        }
    }
}

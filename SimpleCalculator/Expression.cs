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
        string[] array = new string[] { "Error" };
        public Expression(string expression, Dictionary<string, string> vars)
        {
            string pattern = @"^(\-?\d*|\w)\s?(\+?\-?\/?\*?\%?)\s?(\-?\d*|\w)$";
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(expression))
            {
                array = Regex.Split(expression, pattern);
                array[0] = "true";

                if (Regex.IsMatch(array[1], "[a-z]") && vars.ContainsKey(array[1]))
                {
                    array[1] = vars[array[1]];
                }
                if (Regex.IsMatch(array[3], "[a-z]") && vars.ContainsKey(array[3]))
                {
                    array[3] = vars[array[3]];
                }
                if (Regex.IsMatch(array[1], "[a-z]") | Regex.IsMatch(array[3], "[a-z]"))
                {
                    array[0] = "Var not accepted";
                }
                if (array[1] == "" | array[2] == "" | array[3] == "")
                {
                    array[0] = "Not Complete Expression";
                }
                if (array[1] == "-" | array[3] == "-")
                {
                    array[0] = "Needs a number to be nagative";
                }
                if ((array[2] == "/" | array[2] == "%") && (array[3] == "0" | array[3] == "-0"))
                {
                    array[0] = "Cannot divide by 0";
                }
            }
            string addVar = @"^([a-z])\s?\=\s?(\-?\d)$";
            Regex rgx2 = new Regex(addVar);
            if (rgx2.IsMatch(expression))
            {
                array = Regex.Split(expression, addVar);
                if (vars.ContainsKey(array[1]))
                {
                    array[0] = "Already a Var by that name";
                }
                else
                {
                    array[0] = "Var";
                    vars[array[1]] = array[2];
                }
            }
        }
        public string[] getArray()
        {
            return array;
        }
    }
}

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
        string[] array = new string[] { "false" };
        public Expression(string expression, Dictionary<string, string> vars)
        {
            string pattern = @"^(\d*|\w)\s?(\+?\-?\/?\*?)\s?(\d*|\w)$";
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
                try
                {
                    int first = int.Parse(array[1]);
                }
                catch (FormatException)
                {

                    array[0] = "Error";
                }
                try
                {
                    int second = int.Parse(array[3]);
                }
                catch (FormatException)
                {
                    array[0] = "Error";
                }
            }
            string addVar = @"^([a-z])\s?\=\s?(\d)$";
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

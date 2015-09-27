using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            if (P.BalancedDelimiter("(){}[]"))
            {

                Console.WriteLine("It is Balanced Delimiter");
            }
            else
            {
                Console.WriteLine("It is Not Balanced Delimiter");

            }
        }


        public bool BalancedDelimiter(String input)
        {
            Stack<char> Stacker = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    Stacker.Push(input[i]);
                }
                else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    if (Stacker.Peek() == '(' || Stacker.Peek() == '[' || Stacker.Peek() == '{')
                    {
                        Stacker.Pop();
                    }

                }
                else
                {
                    Console.WriteLine("Char given is not Opening or closing brackets");

                }

            }

            if (Stacker.Count > 0)
                return false;
            else
                return true;

        }
    }
}

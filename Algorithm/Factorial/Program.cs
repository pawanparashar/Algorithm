using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            int rec = P.RecFact(6);
            int nonrec= P.Fact(6);
        }

        public int RecFact(int number)
        {
            if (number == 0)
                return 1;
            else
            {
                return(number * RecFact(number - 1));
            }
        }

        public int Fact(int number)
        {
            int Temp = 1;
            int Product =1;
            while(Temp <= number)
            {
                Product = Product * Temp;
                Temp++;
            }
            return Product;
        }
    }
}

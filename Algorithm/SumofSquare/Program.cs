using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            Program P = new Program();
            int SumNumber = P.SumofSquareNumber(5);

            Console.Write("Sum of Square Number" + SumNumber);
        }

        public int SumofSquareNumber( int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return (n * n) + SumofSquareNumber(n-1);

            }



        }
    }
}

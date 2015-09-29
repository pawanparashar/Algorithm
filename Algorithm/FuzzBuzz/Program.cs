using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter thr Number: ");
            var Temp = Console.ReadLine();
            int input;

            if(int.TryParse(Temp,out input))
            {

            }
            else
            {
                Console.WriteLine("Not an Interger");
            }

            Program P = new Program();
            P.FuzzBuzz(input);
            Console.ReadKey();

        }

        public void FuzzBuzz(int input)
        {
            int Number = 1;

            while(Number<= input)
            {
                if(Number % 15 ==0)
                {
                    Console.WriteLine("FuzzBuzz");
                }
                else if(Number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (Number % 3 == 0)
                {
                    Console.WriteLine("Fuzz");
                }
                else
                {
                    Console.WriteLine(Number);
                }
                Number++;
            }


        }
    }
}

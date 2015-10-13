using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerofhanoi
{
    class Program
    {
        public int NumberofMoves=0;
        static void Main(string[] args)
        {
            Program P = new Program();

            P.towerofhanoi(10, "Source", "temp", "Destination");

            Console.WriteLine("Total Number of Moves:" + P.NumberofMoves);
        }

        public void towerofhanoi(int n, string Source, string temp, string Destination)
        {
            if (n == 0)
            {
                return;

            }
            NumberofMoves++;
            towerofhanoi(n - 1, Source, Destination, temp);
            Console.WriteLine("Move Element: " + n + " from " + Source + " to " + Destination);
            towerofhanoi(n - 1, temp, Source, Destination);


        }
    }
}

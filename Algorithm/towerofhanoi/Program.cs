using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerofhanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.towerofhanoi(5, "Source", "temp", "Destination");
        }

        public void towerofhanoi(int n, string Source, string temp, string Destination)
        {
            if (n == 0)
            {
                return;

            }

            towerofhanoi(n - 1, Source, Destination, temp);
            Console.WriteLine("Move Element: " + n + " from " + Source + " to " + Destination);
            towerofhanoi(n - 1, temp, Source, Destination);


        }
    }
}

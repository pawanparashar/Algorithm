using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMinimum
{
    class Program
    {

        Stack<int> RealStacker = new Stack<int>();
        Stack<int> MinStacker = new Stack<int>();

        static void Main(string[] args)
        {

            Program P = new Program();

            P.CustomPush(1);
            P.CustomPush(200);
            P.CustomPush(3);
            P.CustomPush(400);
            P.CustomPush(1);
            P.CustomPush(0);

        }

        public void CustomPush(int Content)
        {

            RealStacker.Push(Content);
            if(MinStacker.Count ==0)
            {
                MinStacker.Push(Content);
            }
            else
            {
                if(MinStacker.Peek() <=Content)
                {
                    MinStacker.Push(MinStacker.Peek());
                }
                else
                {
                    MinStacker.Push(Content);
                }
            }
        }


        public void CustomPop()
        {

            RealStacker.Pop();
            MinStacker.Pop();
        }

    }
}

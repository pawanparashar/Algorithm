using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] ArraytobeSorted = { 10,9,8,7};

            int[] ArraytobeSorted1 = { 10, 9, 8, 7 };
            int[] ArraytobeSorted2 = { 10, 9, 7, 8 ,1,5};
            Program P = new Program();
            P.BubbleSort(ArraytobeSorted);

            P.SelectionSort(ArraytobeSorted);

            P.InsertionSort(ArraytobeSorted2);
        }

        public int[] BubbleSort(int[] ArraytobeSorted)
        {

            for(int i=0;i<ArraytobeSorted.Count<int>();i++)
            {

                for(int j=0;j<ArraytobeSorted.Count<int>() - i-1;j++)
                {
                    if(ArraytobeSorted[j] >ArraytobeSorted[j +1])
                    {
                        int Temp = ArraytobeSorted[j];
                        ArraytobeSorted[j] = ArraytobeSorted[j+1];
                        ArraytobeSorted[j+1] = Temp;
                    }

                }
            }
            return ArraytobeSorted;


        } 


        public int[] SelectionSort(int[] ArraytoSorted)
        {

            
            for (int i = 0; i < ArraytoSorted.Count<int>(); i++)
            {
                int Temp =0, position=0;

                for (int j = i; j < ArraytoSorted.Count<int>(); j++)
                {
                   

                    if (Temp ==0)
                    {
                        Temp = ArraytoSorted[j];
                        position = j;

                    }
                    else if (Temp > ArraytoSorted[j])
                    {
                        Temp = ArraytoSorted[j];
                        position = j;

                    }

                }

                ArraytoSorted[position] = ArraytoSorted[i];
                ArraytoSorted[i] = Temp;
                
            }
            return ArraytoSorted;
        }



        public int[] InsertionSort(int[] ArraytobeSorted)
        {


            for(int i=1;i<ArraytobeSorted.Count<int>();i++)
            {

                int Temp = ArraytobeSorted[i];
                for(int j=i-1;j>=0;j--)
                {

                    if(Temp<ArraytobeSorted[j])
                    {
                        ArraytobeSorted[j + 1] = ArraytobeSorted[j];
                        ArraytobeSorted[j] = Temp;

                    }
                    

                }


            }



            return ArraytobeSorted;
        }

    }
}

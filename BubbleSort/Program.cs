using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        private static int[] data = new int[9];

        static void Main(string[] args)
        {
            getRandomNumberArray(9);
            IntArrayBubbleSort();
            Console.ReadLine();
        }

        public static void IntArrayBubbleSort()
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    //exchange (data, i, i + 1);
                    {
                        int temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }

                }
            }
        }

        public static void getRandomNumberArray(int max)
        {
            int[] a = new int[max];
            Random random = new Random();
            bool test = true;
            int n = 0;


            while (n < a.Length)
            {

                a[n] = random.Next(max * 2) + 1;

                for (int i = 0; i < n; i++)
                {
                    if (a[n] == a[i])
                    {
                        test = false;
                        i = n;
                    }
                }

                if (test)
                {
                    n++;
                }
                else
                {
                    test = true;
                }
            }
        }
    }
}

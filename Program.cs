using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2_tablice_wielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1w = new int[] { 1, 2, 3 };
            int[,] tab2w = new int[3, 2];
            int[,,] tab3w = new int[1, 1, 3];
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            jagged[2] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i=0; i<tab1w.Length;i++)
            {
                Console.WriteLine("tab1w[{0}]", i);
            }
            for (int i = 0; i < tab2w.Length; i++)
            {
                Console.WriteLine("tab2w[{0},{0}]", i, i);
            }
            for(int i=0; i<tab3w.Length;i++)
            {
                Console.WriteLine("tab3w[{0},{0},{0}]",i,i,i);
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexample
{
    class Program
    {
        static void Main(string[] args)
        {
            TheClassWithOneParam[] var = new TheClassWithOneParam[5];
            for (int i=0; i< var.Length; i++)
            {
                var[i] = new TheClassWithOneParam(i+1);
                //TheClassWithOneParam whathever = var[i];
                Console.WriteLine(var[i].TheElement);
            }

            int[,] masyv = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int rows = masyv.GetUpperBound(0) + 1;
            int columns = masyv.Length / rows;

            Console.WriteLine(rows);
            Console.WriteLine(masyv.Length);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{masyv[i, j]} ");
                }
                Console.WriteLine();
            }
                Console.ReadKey();
        }
    }

    public class TheClassWithOneParam
    {
        public int TheElement { get; set; }

        public TheClassWithOneParam(int theelement)
        {
            TheElement = theelement;
        }

    }

}

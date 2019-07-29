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

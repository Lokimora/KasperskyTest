using KasperskyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kaspersky
{
    class Program
    {
        public static MegaQueque<int>_que = new MegaQueque<int>();

        static void Main(string[] args)
        {


            //SumOfPairsTest();

            //MegaQuequeTest();
          

        }

        public static void SumOfPairsTest()
        {


            List<int> rr = new List<int>() { 1, 2, 3, 6, 23, 7 };
            
            SumOfPairs p = new SumOfPairs();


            var answerss = p.CalculatePairs(8);


            foreach (var v in answerss)
            {
                Console.WriteLine(v);
            }
        }


        public static void MegaQuequeTest()
        {
            Thread t2 = new Thread(() => Console.WriteLine(Pop()));
            t2.Start();
            Thread t = new Thread(() => Push(1));
            t.Start();
        }


        private static void Push(int i)
                {
                    Thread.Sleep(5000);
            _que.Push(i);
        }

        private static int Pop()
        {
            return _que.Pop();
        }
    }
}

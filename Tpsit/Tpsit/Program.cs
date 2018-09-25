  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpsit
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Console.WriteLine("Ciao");
            Task t = new Task(Write);
            t.Start();
            int i = 10;
            while (i > 0)
            {
                Console.WriteLine("Pippo");
                i = i - 1;
            }
            Console.ReadLine();
        }
        public static void Write()
        {
            int i = 10;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            } 
        }
    }
}

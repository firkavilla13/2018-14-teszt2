using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg 10 számot");
            int[]t= new int[10];
            int legnagyobb = 0;
            for (int i = 0; i <t.Length; i++)
            {
                t[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Az {0}. szám {1}",i+1,t[i]);
                if (legnagyobb<t[i])
                {
                    legnagyobb = t[i];
                }

            }
            Console.WriteLine("Legnagyobb:"+legnagyobb);
            Console.ReadKey();
            

        }

    }
}

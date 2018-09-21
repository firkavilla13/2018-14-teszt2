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
            Console.WriteLine("Kérem adjon meg hány darab  számot szeretne");
            //int db =Convert.ToInt32(Console.ReadLine());
            string dbs = Console.ReadLine();
            int db;
            if (!int.TryParse(dbs, out db))
            {
                Console.WriteLine("Hiba");
                return;
            }           
            int[]t= new int[db];
            int legnagyobb=0;
            int legkisebb=0; 
            
            for (int i = 0; i <t.Length; i++)
            {
                string ts;
                do
                {                    
                     ts = Console.ReadLine();
                   
                } while (!int.TryParse(ts, out t[i]));
                
                 legnagyobb = t.Max();
                 legkisebb = t.Min();
                Console.WriteLine("Az {0}. szám {1}",i+1,t[i]);
                if (legnagyobb<=t[i])
                {
                    legnagyobb = t[i];
                }
                if (legkisebb>t[i])
                {
                    legkisebb = t[i];
                }

            }
            Console.WriteLine("Legnagyobb:"+legnagyobb);
            Console.WriteLine("Legkisebb:" + legkisebb);
            Console.ReadKey();
            

        }

    }
}

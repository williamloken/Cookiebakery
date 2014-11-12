using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4
{
    class Test
    {
        static void Main()
        {
            Thread[] threads = new Thread[10];
            CookieBakery cb = new CookieBakery(0);
            Greg bc = new Greg(0);
            for (int i = 0; i < 3; i++)
            {
                //This is how we create new "Main" methods for each thread. Here, these "Mains" are instances of the method "acc.DoTransactions".
                Thread t = new Thread(new ThreadStart(cb.DoTransactions));
                threads[i] = t;

            }
            for (int i = 0; i < 3; i++)
            {
                //This is how we create new "Main" methods for each thread. Here, these "Mains" are instances of the method "acc.DoTransactions".
                Thread t = new Thread(new ThreadStart(bc.Buy));
                threads[i] = t;

            }
            // Starting the new "thread Mains".
            for (int i = 0; i < 3; i++)
            {
                threads[i].Start();
            }

            
           // Pause();
            
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to continue ...\n");
            Console.ReadKey(true);
        }
    }
}
    
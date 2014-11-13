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
        public static void Main(String [] args)
        {

            CookieBakery cb = new CookieBakery();
            Greg bc = new Greg();

            Thread bakery = new Thread(new ThreadStart(cb.DoTransactions));
            Thread consumer = new Thread(new ThreadStart(bc.Buy));

            try
            {
                bakery.Start();
                consumer.Start();

                bakery.Join();
                consumer.Join();
            }
            
            catch
            {}
                        
           Pause();
            
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to continue ...\n");
            Console.ReadKey(true);
        }
    }
}
    
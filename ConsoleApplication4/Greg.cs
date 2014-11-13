using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4
{
    class Greg
    {
        private Object thisLock = new Object();
        CookieBakery cb = new CookieBakery();

        int Buy(int BuyCookie)
        {

          lock (thisLock)
            {
                for (int i = 1; i < 13; i++ )
                {
                                   
                    Thread.Sleep(1000);
                    new Basket().Consume(i);
                }
                //cb.cookieBalance++;
                //Console.WriteLine("\t" + "\t" + "Greg Kjøpte kake# " + cb.cookieBalance);
                return BuyCookie;
            }          
        }
        public void Buy()
        {
            while (cb.cookieBalance<=13) 
            {

                Buy(1);

            }
        }
    }
}

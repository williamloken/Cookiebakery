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
        Basket b = new Basket();
        public void Buy()
        {

            //lock (thisLock)
            {
                for (int i = 1; i < 13; i++)
                {
                    Thread.Sleep(1000);
                    
                    b.Consume(i);

                }
            }
        }
    }
}

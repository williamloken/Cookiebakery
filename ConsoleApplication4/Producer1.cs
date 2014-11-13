using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4
{
    class CookieBakery
    {
        private Object thisLock = new Object();
        Basket b = new Basket();
        public void Stock()
        {

            lock (thisLock)
            {
                for (int i = 1; i < 13; i++)
                {
                    Thread.Sleep(677);
                    b.Produce(i);

                }
            }
        }
    }
}

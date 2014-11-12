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
        int cookieBuy;
        public Greg (int initial)
            {
                cookieBuy = initial;
            }

        int Buy(int BuyCookie)
        {

            lock (thisLock)
            {

                Thread.Sleep(1000);
                return BuyCookie;
            }
        }
        public void Buy()
        {
            for (int i = 0; i < 100; i++)
            {

                Buy(1);

            }

        }
    }
}

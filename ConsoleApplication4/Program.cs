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
            int cookieBalance;

            public CookieBakery(int initial)
            {
                cookieBalance = initial;
            }

            int Stock(int cookieAmount)
            {
                // This condition never is true unless the lock statement is commented out.


                // Comment out the next line to see the effect of leaving out the lock keyword.
                lock (thisLock)
                {
                    if (cookieAmount < 13)
                    {
                        Thread.Sleep(667);
                        cookieBalance++;
                        cookieAmount++;
                        //Console.WriteLine(Convert.ToString(cookieAmount));
                        Console.WriteLine("Cookie #" + cookieBalance);
                    }
                    //if (cookieBalance > 0)
                    //{
                    //    Console.WriteLine("Grabs Cookie");
                    //    Thread.Sleep(1000);
                    //    //cookieBalance = cookieBalance - cookieAmount;
                    //    cookieAmount--;
 
                    return cookieAmount;
                    //else
                    //{
                    //   return 0; // transaction rejected
                    //}
                }
            }
            public void GrabCookie()
            {

            }

            public void DoTransactions()
            {
                for (int i = 0; i < 100; i++)
                {
                    //Withdraw(1);
                    Stock(cookieBalance);
                    
                }

            }
        }

    }

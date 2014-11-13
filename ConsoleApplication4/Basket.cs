using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4
{
    class Basket
    {
        public void BasketStock()
        {
            
                Console.WriteLine(" Cookies left");
           
      
            
        }
        public void Consume(int consumed)
        {
           // while (/*basketStock*/ > 0)
            {
               Console.WriteLine("\t" + "\t" + "Greg got cookie #" + consumed);
            }            
                  
        }
        public void Produce(int produced)
        {
            Console.WriteLine("Cookie# " + produced);
        }
    }
}


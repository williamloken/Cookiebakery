using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal class Basket
    {
        public int basketStock(int consume, int produce)
        {
                //Console.WriteLine("Cookie#" );
            //Console.WriteLine(stock + " Cookies in basket");
            return consume;
            
        }
        public int Consume(int basket)
        {
            Console.WriteLine("\t" + "\t" + "Greg got Cookie#" + basket);
            
            return basket;
        }
        public int Produce(int basket)
        {
            Consume(basket);

            return basket;
        }
    }
}

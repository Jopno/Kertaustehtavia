using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> shopping = new List<Products>()
            {
                new Products{Name = "Potato", Price = 0.6f},
                new Products{Name = "Minced meat", Price = 2.5f},
                new Products{Name = "Rainbow trout", Price = 11.5f}
            };

            foreach(Products x in shopping)
            {
                Console.WriteLine("Product: {0} {1} euros", x.Name, x.Price);
            }


            Console.ReadLine();
        }
    }
}

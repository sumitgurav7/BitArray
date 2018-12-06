using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayGetEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            BitCollectionClass bitCollectionClass = new BitCollectionClass();
            bitCollectionClass[1] = true;
            bitCollectionClass[3] = true;
            bitCollectionClass[5] = true;
            bitCollectionClass[7] = true;
            

            foreach(bool bit in bitCollectionClass)
            {
                Console.WriteLine(bit);
            }
            Console.ReadKey();
        }
    }
}

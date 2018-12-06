using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayGetEnum
{
    class BitCollectionClass : IEnumerable
    {
        public BitArray bitArray = new BitArray(8);


        public bool this[int index]
        {
            get => bitArray[index];

            set => bitArray[index] = value; // here I am using indexers
        }

        public IEnumerator GetEnumerator()
        {
            
            return bitArray.GetEnumerator();
        }
    }
}

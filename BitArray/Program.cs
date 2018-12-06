using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays
{/// <summary>
/// Constructors of Bit Array:
/// 1) BitArray(bytes[])  ---> this converts the array of bytes to bit array
/// 2) BitArray(boolean[])  ---> as we know booleans are bit only in form of 1 and 0 
/// this converts an array of boolean to bitarray
/// 3) BitArray(BitArray) ---> This initializes newly created BitArray With specific BitArray
/// 4) BitArray(int32) ---> spicifies the length of particular BitArray
/// 5) BitArray(int32[]) ---> This converts the numbers in int array to bits 
/// sort of each number will have 32bits as this is int32 array so from index 0 to 31 will be first num 
/// and 32 to 63 it will be 2nd num so on like this 
/// 6) BitArray(int32,boolean) ---> this initializes size of array using int32 and also initializes its all elements
/// with bool parameter
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool[] arrayOfBits = new bool[8];//creating array of byte
            Console.WriteLine(Marshal.SizeOf(arrayOfBits[0]));//getting size of particular variable

            bool test = true;

            Console.WriteLine("checking size of bool");
            Console.WriteLine(Marshal.SizeOf(test));//getting size of particular variable

            BitArray bitArray = new BitArray(arrayOfBits);//this is syntax for creating bit array

           
            byte[] array1 = { 85 };
            byte[] array2 = { 75 };
            foreach (byte b in array1) { Console.WriteLine(b); }
            BitArray bitArray1 = new BitArray(array1);
            BitArray bitArray2 = new BitArray(array2);
            Console.WriteLine(Marshal.SizeOf(bitArray1.Get(0)));// getting size of element in bitarray
           // bitArray1.Length
            Console.WriteLine("85");
            Console.WriteLine(bitArray1[1].GetType());
            foreach (object b in bitArray1) {  Console.Write(b); }

            Console.WriteLine("75");
            foreach (object b in bitArray2) {  Console.Write(b); } //reading values from bit array

            byte[] arrayChar = { (byte)'a' };
            Console.WriteLine(" bit conversion of 'a'");
            BitArray bitArrayForChar = new BitArray(arrayChar);
            foreach(bool bit in bitArrayForChar)
            {
                Console.Write(bit);
            }

            /*lets try to convert back to byte a whole bit array
             */

            byte convertedToByte = ConvertToByte(bitArrayForChar);
            Console.WriteLine(" converted bit array" + (char)convertedToByte);
            
            Console.ReadKey();
        }

        public static byte ConvertToByte(BitArray bits)
        {
            if (bits.Count != 8)
            {
                throw new ArgumentException(" bits ");
            }
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0); // copy to method to cpy entire bit array to one dimensional compatible array
            //here we are converting the same to byte so we can read
            return bytes[0];
        }
    }
}

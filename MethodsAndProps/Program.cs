using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndProps
{
    class Program
    {

        
        BitArray bitArray = new BitArray(8);
        static void Main(string[] args)
        {
            

            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("we will see Most of the methods and properties of BitArray Class");
                Console.WriteLine("To add at any index enter 1");
                Console.WriteLine("To use 'and' operator on two num enter 2");
                Console.WriteLine("To use 'or' operator on two num enter 3");
                Console.WriteLine("To use not operator on num and its bits enter 4");
                Console.WriteLine("To left shift any numbers bit enter 5");
                Console.WriteLine("To right shift any numbers bit enter 6");
                Console.WriteLine("To use XOR operator enter 7 ");
                Console.WriteLine("enter 0 to exit ");
                Program program = new Program();
                string choiceText = Console.ReadLine();
                if (int.TryParse(choiceText, out int nu))
                { choice = int.Parse(choiceText); }
                else { choice = 8; }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter Index at you want to add bit");
                        int index = int.Parse(Console.ReadLine());
                        int enteringValue = int.Parse(Console.ReadLine());
                        if (enteringValue < 0 || enteringValue > 1)
                        {
                            Console.WriteLine("wrong bit entered taking default bit as True");
                            enteringValue = 1;
                        }

                        program.addAtIndex(index, enteringValue);
                        break;


                    case 2:
                        Console.WriteLine("Enter First number");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        int num2 = int.Parse(Console.ReadLine());
                        //we can use tryparse to validate if givent string converted succesfully or not
                        program.andOperatorTest(num1, num2);


                        break;


                    case 3:
                        Console.WriteLine("Enter First number");
                        int numb1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        int numb2 = int.Parse(Console.ReadLine());
                        //we can use tryparse to validate if givent string converted succesfully or not
                        program.orOperatorTest(numb1, numb2);

                        break;

                    case 4:
                        Console.WriteLine("Enter any number");
                        program.notOperatorTest(int.Parse(Console.ReadLine()));
                        break;


                    case 5:

                        Console.WriteLine("using left shift on an number");
                        Console.WriteLine("mostly we dont do this operation on nrgative num");
                        Console.WriteLine("facts : leftshift 1 on any num result in multiplication by2");
                        Console.WriteLine("facts : rightshift by 1 on any num result division by 2");
                        Console.WriteLine("facts : leftshift of num 1 by any num results in 2 raise to that num 2^num");
                        Console.WriteLine();

                        Console.WriteLine("enter any number to left shift");
                        program.leftshiftTest(int.Parse(Console.ReadLine()));

                        break;

                    case 6:

                        Console.WriteLine("using right shift on an number");
                        Console.WriteLine("mostly we dont do this operation on nrgative num");
                        Console.WriteLine("facts : leftshift 1 on any num result in multiplication by2");
                        Console.WriteLine("facts : rightshift by 1 on any num result division by 2");
                        Console.WriteLine("facts : leftshift of num 1 by any num results in 2 raise to that num 2^num");
                        Console.WriteLine();

                        Console.WriteLine("enter any number to left shift");
                        program.rightshiftTest(int.Parse(Console.ReadLine()));

                        break;


                    case 7:
                        Console.WriteLine("Enter First number");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Second number");
                        int number2 = int.Parse(Console.ReadLine());
                        //we can use tryparse to validate if givent string converted succesfully or not
                        program.xorOperatorTest(number1, number2);

                        break;






                    default:
                        if (choice != 0)
                        {
                            Console.WriteLine("please enter proper input");
                            break;
                        }
                        else
                        { break; }
                } 
            } while (choice!=0);

            

        }

        private BitArray xorOperatorTest(int num1, int num2)
        {
            byte[] byteArrayForNum1 = { (byte)num1 };
            BitArray bitArrayForNum1 = new BitArray(byteArrayForNum1);
            byte[] byteArrayForNum2 = { (byte)num2 };
            BitArray bitArrayForNum2 = new BitArray(byteArrayForNum2);
           
            
            Console.WriteLine();
            Console.WriteLine("bit array of first number " + num1);

            for (int i = 0; i < bitArrayForNum1.Count; i++)
            {
                Console.Write(bitArrayForNum1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("bit array of second number " + num2);

            for (int i = 0; i < bitArrayForNum2.Count; i++)
            {
                Console.Write(bitArrayForNum2[i] + " ");
            }

            BitArray andResult = bitArrayForNum1.Xor(bitArrayForNum2);
            Console.WriteLine();
            Console.WriteLine("Bit array with XOR Operation");
            for (int i = 0; i < andResult.Count; i++)
            {
                Console.Write(andResult[i] + " ");
            }

            Console.WriteLine("new number is : " + ConvertToByte(andResult));
            return andResult;
        }

        private void rightshiftTest(int num1)
        {
            byte[] byteArrayForNum1 = { (byte)num1 };
            BitArray bitArrayForNum1 = new BitArray(byteArrayForNum1);
            Console.WriteLine("left shift method removed after c# 3.0 ");
            Console.WriteLine("WE ARE USING '<<' OPERATOR FOR SHIFTING");
            int newNum = num1 >> 1;
            Console.WriteLine("value after leftshifting " + num1 + " is : {0}", newNum);
            Console.WriteLine("before shifting bit array");
            for (int i = 0; i < bitArrayForNum1.Count; i++)
            {
                Console.Write(bitArrayForNum1[i] + " ");


            }

            Console.WriteLine("after shifting ");
            byte[] byteArrayFornewNum = { (byte)newNum };
            BitArray bitArrayFornewNum = new BitArray(byteArrayFornewNum);
            for (int i = 0; i < bitArrayFornewNum.Count; i++)
            {
                Console.Write(bitArrayFornewNum[i] + " ");


            }
        }

        private void leftshiftTest(int num1)
        {
            byte[] byteArrayForNum1 = { (byte)num1 };
            BitArray bitArrayForNum1 = new BitArray(byteArrayForNum1);
            Console.WriteLine("left shift method removed after c# 3.0 ");
            Console.WriteLine("WE ARE USING '<<' OPERATOR FOR SHIFTING");
            int newNum = num1 << 1;
            Console.WriteLine("value after leftshifting " + num1 + " is : {0}", newNum);
            Console.WriteLine("before shifting bit array");
            for (int i = 0; i < bitArrayForNum1.Count; i++)
            {
                Console.Write(bitArrayForNum1[i] + " ");


            }

            Console.WriteLine("after shifting ");
            byte[] byteArrayFornewNum = { (byte)newNum };
            BitArray bitArrayFornewNum = new BitArray(byteArrayFornewNum);
            for (int i = 0; i < bitArrayFornewNum.Count; i++)
            {
                Console.Write(bitArrayFornewNum[i] + " ");


            }


        }

        private BitArray notOperatorTest(int num1)
        {
            byte[] byteArrayForNum1 = { (byte)num1 };
            BitArray bitArrayForNum1 = new BitArray(byteArrayForNum1);

            BitArray andResult = bitArrayForNum1.Not();
            Console.WriteLine();
            Console.WriteLine("bit array of first number " + num1);

            for (int i = 0; i < bitArrayForNum1.Count; i++)
            {
                Console.Write(bitArrayForNum1[i] + " ");


            }


            Console.WriteLine();
            Console.WriteLine("Bit array with Not Operation");
            for (int i = 0; i < andResult.Count; i++)
            {
                Console.Write(andResult[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("new number is : " + ConvertToByte(andResult));
            return andResult;
        }

        private BitArray orOperatorTest(int num1, int num2)
        {
            byte[] byteArrayForNum1 = { (byte)num1 };
            BitArray bitArrayForNum1 = new BitArray(byteArrayForNum1);
            byte[] byteArrayForNum2 = { (byte)num2 };
            BitArray bitArrayForNum2 = new BitArray(byteArrayForNum2);

            
            Console.WriteLine();
            Console.WriteLine("bit array of first number " + num1);

            for (int i = 0; i < bitArrayForNum1.Count; i++)
            {
                Console.Write(bitArrayForNum1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("bit array of second number " + num2);

            for (int i = 0; i < bitArrayForNum2.Count; i++)
            {
                Console.Write(bitArrayForNum2[i] + " ");
            }

            BitArray andResult = bitArrayForNum1.Or(bitArrayForNum2);
            Console.WriteLine();
            Console.WriteLine("Bit array with OR Operation");
            for (int i = 0; i < andResult.Count; i++)
            {
                Console.Write(andResult[i] + " ");
            }

            Console.WriteLine("new number is : " + ConvertToByte(andResult));
            return andResult;
        }



        private BitArray andOperatorTest(int num1, int num2)
        {
            byte[] byteArrayForNum1 = { (byte)num1 };
            BitArray bitArrayForNum1 = new BitArray(byteArrayForNum1);
            byte[] byteArrayForNum2 = { (byte)num2 };
            BitArray bitArrayForNum2 = new BitArray(byteArrayForNum2);

            
            Console.WriteLine();
            Console.WriteLine("bit array of first number " + num1);
            
                for (int i = 0; i < bitArrayForNum1.Count; i++)
                {
                    Console.Write(bitArrayForNum1[i] + " ");
                }

            Console.WriteLine();
            Console.WriteLine("bit array of second number " + num2);

            for (int i = 0; i < bitArrayForNum2.Count; i++)
            {
                Console.Write(bitArrayForNum2[i] + " ");
            }

            BitArray andResult = bitArrayForNum1.And(bitArrayForNum2);

            Console.WriteLine();
            Console.WriteLine("Bit array with And Operation");
            for(int i =0; i<andResult.Count; i++)
            {
                Console.Write(andResult[i] + " ");
            }

            Console.WriteLine("new number is : " + ConvertToByte(andResult));
            return andResult;
        }



        public static byte ConvertToByte(BitArray bits)
        {
            if (bits.Count != 8)
            {
                throw new ArgumentException("bits");
            }
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0); // copy to method to cpy entire bit array to one dimensional compatible array
            //here we are converting the same to byte so we can read
            return bytes[0];
        }




        private void addAtIndex(int index, int enteringValue)
        {
            bool putValue;
            if(enteringValue==0)
            {
                putValue = false;
            }
            else if(enteringValue == 1)
            {
                putValue = true;
            }
            else
            {
                putValue = true;
            }
            bitArray[index] = putValue;

            Console.WriteLine("diplaying newly added value");
            for(int i = 0; i<bitArray.Count; i++)
            {
                Console.WriteLine("at index " + i + " bit " + bitArray.Get(i));
            }
        }
    }
}

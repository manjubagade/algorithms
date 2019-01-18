using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmspgm
{
    class BinaryDecimal
    {
        /// <summary>
        /// binary decimal number 
        /// </summary>
        public void BenaryToDec()
        {
            try
            {
                Utility ut = new Utility();
                string binnum = ut.ToBinary();
                ////if condition is used for converting the binary number in to 8 bits
                if (binnum.Length < 8)
                {
                    while (binnum.Length < 8)
                    {
                        binnum = 0 + binnum;
                    }
                }

                string n1 = binnum.Substring(0, 4);
                string n2 = binnum.Substring(4);

                string newBinaryNumber = n2 + n1;
                int decimalnum = 0;
                int pos = 0;
                ////this for loop is used for converting binary number in to decimal number
                for (int i = newBinaryNumber.Length - 1; i >= 0; i--)
                {
                    string numform= newBinaryNumber[pos] + string.Empty;
                    int number = Convert.ToInt32(numform);
                    pos++;
                    decimalnum = (int)((number * Math.Pow(2, i)) + decimalnum);
                }

                //// added code in binary
                Console.WriteLine("new decimal number is " + decimalnum);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
 }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmspgm
{
    class Decimaltobinary
    {
        public void BinToDec()
        {
            Utility uts = new Utility();
            string binaryNumber = uts.ToBinary();
            Console.WriteLine("THE BINARY NUMBER is  " + binaryNumber);
        }
    }
    
}

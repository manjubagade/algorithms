using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmspgm
{
    class BinarySearchword
    {
        public void BinSeF()
        {
            Utility uttss = new Utility();
            string t = null;
            try
            {

                t = System.IO.File.ReadAllText(@"C:\Users\Admin\Documents\BinarySearchOfWord.txt");

                string[] words = t.Split(new char[] { ' ' });
                Array.Sort(words);
                uttss.BinarySearchOfString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

            
        }
    }
}

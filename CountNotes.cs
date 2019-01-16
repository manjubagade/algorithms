using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmspgm
{
   public class CountNotes
    {
        public void CountTheNotes()
        {
            Utility utility = new Utility();
            int count = 0;
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            Console.WriteLine("enter ammount of notes");
            int ammount = utility.GetInt();
            for (int i = 0; i < notes.Length; i++)
            {
                while ((ammount / notes[i] > 0) && ammount >= 1)
                {
                    int change = ammount / notes[i];
                    Console.WriteLine("number of " + notes[i] + " is " + change);
                    count = count + change;
                    ammount = ammount % notes[i];
                }
            }

            Console.WriteLine("minimum number of notes " + count);
        }
    }
 }


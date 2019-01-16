//-----------------------------------------------------------------------
// <copyright file="Anagram.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithmspgm
{
    using System;

    /// <summary>
    /// this class is used to find the anagram of a string
    /// </summary>
    public class Anagram
    {
        /// <summary>
        ///  to find anagram.
        /// </summary>
       public void FindAnagram()
        {
            try
            {
                ////take the input from user
                Console.WriteLine("ENTER THE FIRST STRING");
                string fstring = Console.ReadLine();
                ////take the input from user
                Console.WriteLine("ENTER THE SECOND STRING");
                string sstring = Console.ReadLine();
                ////converting first string in to character array
                char[] firstString = fstring.ToLower().ToCharArray();
                ////converting first string in to character array
                char[] secondString = sstring.ToLower().ToCharArray();
                ////sorting the first String Charactres 
                Array.Sort(firstString);
                ////sorting the first String Charactres 
                Array.Sort(secondString);
                ////converting back the character array to string
                string s1 = new string(firstString);
                ////converting back the character array to string
                string s2 = new string(secondString);
                ////if condition is used to find whether two strings anagrams or not
                if (s1.Equals(s2))
                {
                    Console.WriteLine("THE GIVEN STRING IS ANAGRAM");
                }
                else
                {
                    Console.WriteLine("THE GIVEN STRING IS NOT ANAGRAM");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

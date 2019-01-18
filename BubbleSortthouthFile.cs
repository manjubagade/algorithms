//-----------------------------------------------------------------------
// <copyright file="BubbleSortthouthFile.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithmspgm
{
    using System;

    /// <summary>
    /// bubble sort function file
    /// </summary>
    public class BubbleSortthouthFile
    {
        /// <summary>
        /// bubblesort function
        /// </summary>
        public void Bfile()
        {
            try
            {

                Utility uttt = new Utility();
                string t = null;


                t = System.IO.File.ReadAllText(@"C: \Users\Admin\Documents\BubbleSort.txt");

                string[] na = t.Split(new char[] { ' ' });
                int[] num = Array.ConvertAll(na, int.Parse);
                uttt.BubbleSortLogic(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

    }
    }
}

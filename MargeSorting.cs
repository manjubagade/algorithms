using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmspgm
{
    class MargeSorting
    {
        /// <summary>
        /// Array declared to store numbers
        /// </summary>
        private string[] array;

        /// <summary>
        /// Array declared to copy the divide elements of array
        /// </summary>
        private string[] tempMergeArray;

        /// <summary>
        /// declaring instance variable length
        /// </summary>
        private int length;

        /// <summary>
        /// This method is declared and defined to 
        /// initialized instance array and variable
        /// </summary>
        /// /// <param name="inputArr">string array</param>
        public void Sort(string[] inputArr)
        {
            try
            {  
              
                ////initialising instance array and variable
                this.array = inputArr;
                this.length = inputArr.Length;
                this.tempMergeArray = new string[this.length];
                ////calling method recursively to sort all the data
                this.DivideArray(0, this.length - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// this method will divide the array in parts
        /// </summary>
        /// <param name="lowerIndex"> lower index</param>
        /// <param name="higherIndex"> higher index</param>
        public void DivideArray(int lowerIndex, int higherIndex)
        {
            try
            {
                if (lowerIndex < higherIndex)
                {
                    //// finding middle element by adding lower 
                    //// and highest and dividing by 2
                    int middle = (lowerIndex + (higherIndex - lowerIndex)) / 2;
                    ////calling method recursively 
                    ////first will divide till lower to middle
                    this.DivideArray(lowerIndex, middle);
                    ////this recusive method will divide from middle+1 to higherIndex
                    this.DivideArray(middle + 1, higherIndex);
                    ////this recursive method will 
                    this.MergeArray(lowerIndex, middle, higherIndex);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// mergeArray is use to merge two array
        /// </summary>
        /// <param name="lowerIndex">zero index</param>
        /// <param name="middle">middle index</param>
        /// <param name="higherIndex">last index</param>
        public void MergeArray(int lowerIndex, int middle, int higherIndex)
        {
            try
            {
                for (int m = lowerIndex; m <= higherIndex; m++)
                {
                    this.tempMergeArray[m] = this.array[m];
                }

                int i = lowerIndex;
                int j = middle + 1;
                int k = lowerIndex;
                while (i <= middle && j <= higherIndex)
                {
                    if (string.Compare(this.tempMergeArray[i], this.tempMergeArray[j]) <= 0)
                    {
                        this.array[k] = this.tempMergeArray[i];
                        i++;
                    }
                    else
                    {
                        this.array[k] = this.tempMergeArray[j];
                        j++;
                    }

                    k++;
                }

                while (i <= middle)
                {
                    this.array[k] = this.tempMergeArray[i];
                    k++;
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
    


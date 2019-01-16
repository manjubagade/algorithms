//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Brigdelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithmspgm
{
    using System;
    using System.Collections;
    using System.Diagnostics;

    /// <summary>
    /// this class is used for writing the common logics that are required by other class
    /// </summary>
    class Utility
    {
        /// <summary>
        /// Gets the integer. 
        /// </summary>
        /// <returns> it returns the integer that is required</returns>
        private Stopwatch stopwatch = new Stopwatch();
        public int GetInt()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Double GetDouble()
        {
            Double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }
        /// <summary>
        /// 
        /// </summary>
        public void PrimeNum()
        {
            Console.WriteLine("enter the range of prime numbers ");
            int n = GetInt();
            ArrayList ar = new ArrayList();
            bool isprime = true;
            Console.WriteLine("range between the primes numbers");
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= n; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write("\t" + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }

        public void DayOFWeek()
        {
            //formula for year between 0000 to 9999
            Console.WriteLine("enter the year");
            int year = this.GetInt();
            Console.WriteLine("enter the month");
            int month = this.GetInt();
            Console.WriteLine("enter the days");
            int date = this.GetInt();
            int year1 = year - (14 - month) / 12;
            int x = year1 + (year1 / 4) - (year1 / 100) + (year1 / 400);
            int month1 = month + 12 * ((14 - month) / 12) - 2;
            int date1 = (date + x + 31 * month1 / 12) % 7;

            String[] day = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


            for (int i = 0; i < day.Length; i++)
            {
                if (i == date1)
                    Console.WriteLine("the day is : " + day[i]);
            }
        }
        public void MonthlyPayments()
        {
            Console.WriteLine("enter the payment");
            Double p = this.GetDouble();
            Console.WriteLine("enter the year");
            Double y = this.GetDouble();
            Console.WriteLine("enter the interest");
            Double inte = this.GetDouble();
            double n = 12 * y;
            double r = inte / (12 * 100);
            double payment = (p * r) / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("the monthly payment is " + payment);
            Console.ReadLine();
        }
        public void SquareRoot()
        {
            Utility ut = new Utility();
            Console.WriteLine("enter number");
            double d = ut.GetDouble();
            double t = d;
            double epsilon = 1e-15;

            while (Math.Abs(t - (d / t)) > (epsilon * t))
            {
                t = ((d / t) + t) / 2.0;
            }

            Console.WriteLine(t);
        }
        public int SizeOfArray()
        {
            Utility utility = new Utility();
            Console.WriteLine("enter number of array size");
            int size = utility.GetInt();
            return size;
        }
        public void InsertionSortOfIteger()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            int[] numbers = new int[size];
            Console.WriteLine("enter integer array elements ");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = utility.GetInt();
            }

            this.insertionSortlLogic(numbers);
        }
        public void InsertionSortOfString()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            string[] words = new string[size];
            Console.WriteLine("enter string array elements");
            for (int i = 0; i < size; i++)
            {
                words[i] = Console.ReadLine();
            }

            this.LogicOfInsertionSortOfString(words);
        }
        public void BubbleSortInt()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            int[] num = new int[size];
            Console.WriteLine("enter integer array elements");
            for (int i = 0; i < size; i++)
            {
                num[i] = utility.GetInt();
            }

            this.BubbleSortLogic(num);
        }
        public void BinarySearchInt()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            int[] num = new int[size];
            Console.WriteLine("enter integer array elements");
            for (int i = 0; i < size; i++)
            {
                num[i] = utility.GetInt();
            }

            this.BinarySearch(num);
        }

        public void BubbleSortOfString()
        {
            Utility utility = new Utility();
            int size = this.SizeOfArray();
            string[] words = new string[size];
            Console.WriteLine("enter string array elements");
            for (int i = 0; i < size; i++)
            {
                words[i] = Console.ReadLine();
            }
            this.BubbleSortString(words);
        }

        public void BubbleSortLogic(int[] array)
        {
            this.stopwatch.Start();
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            this.stopwatch.Stop();
            Console.WriteLine("B SORT TIME TAKEN BY INTEGER  " + this.stopwatch.Elapsed);
            Console.WriteLine("GIVEN ARRAY IS SORTED  ");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
        public void BubbleSortString(string[] word)
        {
            this.stopwatch.Start();
            for (int i = 0; i <= word.Length - 1; i++)
            {
                for (int j = 0; j <= word.Length - 2; j++)
                {
                    if (word[j].CompareTo(word[j + 1]) > 0)
                    {
                        string temp = word[j];
                        word[j] = word[j + 1];
                        word[j + 1] = temp;
                    }
                }
            }

            this.stopwatch.Start();
            Console.WriteLine("BUBBLE SORT TIME TAKEN BY STRING " + this.stopwatch.Elapsed);
            Console.WriteLine("GIVEN ARRAY IS SORTED");
            for (int i = 0; i <= word.Length - 1; i++)
            {
                Console.WriteLine(word[i]);
            }

            Console.ReadLine();
        }
        public void BinarySearch(int[] numbers)
        {
            int firstind = 0;
            int lastind = numbers.Length - 1;
            Console.WriteLine("enter the numbers");
            int binary = this.GetInt();
            this.stopwatch.Start();
            while (firstind <= lastind)
            {
                int midind =firstind + lastind / 2;
                if (numbers[midind] == binary)
                {
                    Console.WriteLine("THE SEARCHING POSition" +(midind + 1));
                    break;
                }
                if (binary > numbers[midind])
                {
                    firstind = midind + 1;
                }
                else
                {
                    lastind = midind - 1;
                }
            }
            Console.WriteLine("BINARY SEARCH TIME TAKEN BY INTEGERS" + this.stopwatch.Elapsed);
        }
        public void BinarySearchOfString()
        {
            Console.WriteLine("enter string");
            string words = Console.ReadLine();
            string[] wordsInArray = words.Split(new char[] { ' ' });
            Array.Sort(wordsInArray);
            this.BinarySearchString(wordsInArray);
        }
        public void BinarySearchString(string[] wordsInArray)
        {
            Console.WriteLine("ente search element");
            string searchElement = Console.ReadLine();
            int firstIndex = 0;
            int lastIndex = wordsInArray.Length - 1;
            this.stopwatch.Start();
            while (firstIndex <= lastIndex)
            {
                int middleIndex = (firstIndex + lastIndex) / 2;
                if (wordsInArray[middleIndex].Equals(searchElement))
                {
                    Console.WriteLine("the search element found at position " + (middleIndex + 1));
                    break;
                }

                if (searchElement.CompareTo(wordsInArray[middleIndex]) > 0)
                {
                    firstIndex = middleIndex + 1;
                }
                else
                {
                    lastIndex = middleIndex - 1;
                }
            }

            this.stopwatch.Stop();
            Console.WriteLine("time taken for binary search of string is " + this.stopwatch.Elapsed);
        }
        public void insertionSortlLogic(int[] numbers)
        {
            this.stopwatch.Start();
            for (int j = 1; j <= numbers.Length - 1; j++)
            {
                int value = numbers[j];
                int index = j;
                while (index > 0 && numbers[index - 1] > value)
                {
                    numbers[index] = numbers[index - 1];
                    index--;
                }

                numbers[index] = value;
            }

            this.stopwatch.Stop();
            Console.WriteLine("time taken for insertion sort of integer is " + this.stopwatch.Elapsed);
            Console.WriteLine("sorted list");
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
        public void LogicOfInsertionSortOfString(string[] words)
        {
            this.stopwatch.Start();
            for (int j = 1; j <= words.Length - 1; j++)
            {
                string value = words[j];
                int index = j;
                while (index > 0 && words[index - 1].CompareTo(value) > 0)
                {
                    words[index] = words[index - 1];
                    index--;
                }

                words[index] = value;
            }

            this.stopwatch.Start();
            Console.WriteLine("time taken for insertion sort of string is " + this.stopwatch.Elapsed);

            Console.WriteLine("sorted list");
            for (int i = 0; i <= words.Length - 1; i++)
            {
                Console.WriteLine(words[i]);
            }

            Console.ReadLine();
        }
        public String ToBinary()
        {
            Console.WriteLine("ENTER THE NUM TO CONVERT BINARY TO DECIMAL");
            int dn = this.GetInt();
            int temp = dn;
            string binaryNum = string.Empty;
            while (dn != 0)
            {
                int rem = dn % 2;
                binaryNum = rem + binaryNum;
                dn = dn / 2;
            }
            return binaryNum;
        }
        
        
    }
}

    






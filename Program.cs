﻿//-----------------------------------------------------------------------
// <copyright file="program.cs" company="bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Algorithmspgm
{
    using System;
    /// <summary>
    /// this class is used to execute all algorithm programs
    /// </summary>
    class Program
    {

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {

            string condition = "null";
            do
            {
                Console.WriteLine("ENTER PRESS 1 : FOR ANAGRAM");
                Console.WriteLine("ENTER PRESS 2 : FOR 0 to 1000 prime num");
                Console.WriteLine("ENTER PRESS 3 : FOR DAYSOFWEEKS");
                Console.WriteLine("ENTER PRESS 4 : FOR MONTHLYPAYMENTS");
                Console.WriteLine("ENTER PRESS 5 : FOR SQUREROOT");
                Console.WriteLine("ENTER PRESS 6 OF SORTANDSEARCHING");
                Console.WriteLine("ENTER PRESS 7 FOR DECIMAL TO BINARY");
                Console.WriteLine("ENTER PRESS 8: VENDINGMACHINE ");
                Console.WriteLine("ENTER PRESS 9: BINARYSEARCH");
                Console.WriteLine("ENTER PRESS 10: BINARYSEARCH SREING");
                Console.WriteLine("ENTER PRESS 11: Bubble thouth file");
                Console.WriteLine("ENTER PRESS  12 : binarysearch thouth file");
                Console.WriteLine("ENTER PRESS 13:INSERTION SORT");
                Console.WriteLine("ENTER PREESS 14 : FINDING NUMBER");
                Console.WriteLine("ENTER PRESS 15 :MARGESORT ");
                Console.WriteLine("ENTER PRESS 16 : TEMPRATURE CONVERTIONN");
                Console.WriteLine("ENTER PRESS 17 : FOR BINARY NIBBALE ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Anagram an = new Anagram();
                        an.FindAnagram();
                        break;
                    case 2:
                        CountPrime cp = new CountPrime();
                        cp.CountPrimeNum();
                        break;
                    case 3:
                        WeekDays wd = new WeekDays();
                        wd.FindDayWeek();
                        break;
                    case 4:
                        MonthlyPay mp = new MonthlyPay();
                        mp.MonthlyPayments();
                        break;
                    case 5:
                        SqureRoot sr = new SqureRoot();
                        sr.SqureRoots();
                        break;
                    case 6:
                        SortingAndSearching sas = new SortingAndSearching();
                        sas.SortingSearchingarray();
                        break;
                    case 7:
                        Decimaltobinary db= new Decimaltobinary();
                        db.BinToDec();
                        break;
                    case 8:
                        CountNotes cn = new CountNotes();
                        cn.CountTheNotes();
                        break;
                    case 9:
                        BinarySearch2 uts = new BinarySearch2();
                        uts.BinSer();
                        break;
                    case 10:
                        BinarySearchS bs = new BinarySearchS();
                        bs.BinSerS();
                        break;
                    case 11:
                        BubbleSortthouthFile bsf = new BubbleSortthouthFile();
                        bsf.Bfile();
                        break;
                    case 12:
                        BinarySearchword bw = new BinarySearchword();
                        bw.BinSeF();
                        break;
                    case 13:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.InserTionSortNum();
                        break;
                    case 14:
                        Utility u = new Utility();
                        u.Guessnum();
                        break;
                    case 15:
                        Utility ur = new Utility();
                        MargeSorting sc = new MargeSorting();
                        Console.WriteLine("Enter size of array:");
                        int mst =ur.GetInt();
                        string[] mss = new string[mst];
                        Console.WriteLine("Enter " + mst + " elements");
                        for (int i = 0; i < mss.Length; i++)
                        {
                            mss[i] = Utility.GetString();
                        }

                        Console.WriteLine("Sorted Arrays:");

                       
                        foreach (string line in mss)
                        {
                            Console.WriteLine(line + " ");
                        }

                        break;
                       case 16:
                            TemparetureCon tc = new TemparetureCon();
                           tc.TempCon();
                           break;
                    case 17:
                        BinaryDecimal bc = new BinaryDecimal();
                        bc.BenaryToDec();
                        break;
                }

                Console.WriteLine("ENTER YES FOR CONTINUES NO FOR STOP");
                condition = Console.ReadLine();
            }
            while (condition == "y");
        }

    }
}

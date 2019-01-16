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
                Console.WriteLine("ENTER PRESS 7 FOR decimaltobinary");
                Console.WriteLine("ENTER PRESS 8: for hasg ");

                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Anagram an = new Anagram();
                        an.FindAnagram();
                        break;
                    case 2:
                        Utility ut = new Utility();
                        ut.PrimeNum();
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




                }

                Console.WriteLine("ENTER YES FOR CONTINUES NO FOR STOP");
                condition = Console.ReadLine();
            }
            while (condition == "y");
        }

    }
}
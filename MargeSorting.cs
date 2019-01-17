using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmspgm
{
    class MargeSorting
    {
        private static int[] MargeSort(int[] number)
        {
            if (number.Length <= 1) return number;
            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(number[i]);
                }
                else
                {
                    right.Add(number[i]);
                }
            }
            left = MargeSort(left.ToArray()).ToList();
            right = MargeSort(right.ToArray()).ToList();
            return Marge(left, right);
        }
        private static int[] Marge(List<int> left ,List<int> right)
        {
            var result = new List<int>();
            while (NotEmpty(left) && NotEmpty(right))
            {
                if (left.First() <= right.First())
                    MoveValuesFromSouceToResouce(left, result);
                else
                    MoveValuesFromSouceToResouce(right, result);
            }
        }

        private static int NotEmpty(List<int> List)
        {
            return List.Count;
        }

        private static void MoveValuesFromSouceToResouce(List<int> left, List<int> result)
        {
            result.Add(left.First());
            left.RemoveAt(0);
        }
    }
}

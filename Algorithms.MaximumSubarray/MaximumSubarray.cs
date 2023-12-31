﻿namespace Algorithms.MaximumSubarray.MaxSubarray
{
    public static class MaximumSubarray
    {
        public static int KadaneAlgorithm(int[] a)
        {
            int max = int.MinValue, currentMax = 0;

            foreach (var item in a)
            {
                currentMax += item;

                if (max < currentMax) max = currentMax;

                if (currentMax < 0) currentMax = 0;
            }

            return max;
        }
    }
}